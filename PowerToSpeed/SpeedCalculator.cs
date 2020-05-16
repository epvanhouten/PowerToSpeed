using System;

internal class SpeedCalculator
{
    public SpeedCalculator()
    {

    }

    public State CalculateNextState(State currentState)
    {
        return new State(
            speedInMetersPerSecond: currentState.SpeedInMetersPerSecond,
            powerInWatts: currentState.PowerInWatts
        );
    }
}

internal class State
{
    public double SpeedInMetersPerSecond { get; }
    public double PowerInWatts { get; }

    public State(double speedInMetersPerSecond, double powerInWatts)
    {
        if(speedInMetersPerSecond < 0)
        {
            throw new ArgumentOutOfRangeException("Speed must be positive.");
        }

        if(powerInWatts < 0)
        {
            throw new ArgumentOutOfRangeException("Power must be positive.");
        }

        SpeedInMetersPerSecond = speedInMetersPerSecond;
        PowerInWatts = powerInWatts;
    }
}