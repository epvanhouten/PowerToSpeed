using Dynastream.Fit;
using System;
using System.IO;

public class SpeedRewriter
{
    private readonly Decode _decoder;
    private readonly Encode _encoder;
    private readonly SpeedCalculator _speedCalculator = new SpeedCalculator();

    private State _lastState = new State(0, 0);

    public SpeedRewriter()
    {
        _decoder = new Dynastream.Fit.Decode();
        _decoder.MesgEvent += OnMesgEvent;
        _decoder.DeveloperFieldDescriptionEvent += OnDeveloperFieldDescriptionEvent;
        _decoder.MesgDefinitionEvent += OnMesgDefinitionEvent;
        
        _encoder = new Dynastream.Fit.Encode(ProtocolVersion.V20);        
    }

    private void OnMesgDefinitionEvent(object sender, MesgDefinitionEventArgs e)
    {
        _encoder.OnMesgDefinition(e.mesgDef);
    }

    private void OnDeveloperFieldDescriptionEvent(object sender, DeveloperFieldDescriptionEventArgs e)
    {
        
    }

    private void OnMesgEvent(object sender, MesgEventArgs e)
    {
        var rewrittenMessage = new Mesg(e.mesg);
        _encoder.OnMesg(rewrittenMessage);
    }

    public Stream AddSpeedData(Stream originalFit)
    {
        var outputStream = new MemoryStream();
        _encoder.Open(outputStream);

        var readSucceeded = _decoder.Read(originalFit);

        if(!readSucceeded)
        {
            throw new System.IO.InvalidDataException("Reading the fit stream failed.");
        }

        return outputStream;
    }
}