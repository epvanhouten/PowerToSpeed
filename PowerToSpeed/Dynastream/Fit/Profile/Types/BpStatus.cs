#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2020 Garmin Canada Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.30Release
// Tag = production/akw/21.30.00-0-g324900c
////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile BpStatus type as an enum
    /// </summary>
    public enum BpStatus : byte
    {
        NoError = 0,
        ErrorIncompleteData = 1,
        ErrorNoMeasurement = 2,
        ErrorDataOutOfRange = 3,
        ErrorIrregularHeartRate = 4,
        Invalid = 0xFF


    }
}

