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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace Dynastream.Fit
{
    /// <summary>
    /// Extends System.Exception to provide application specific exceptions.
    /// </summary>
    public class FitException : Exception
    {
        #region Constructors
        public FitException()
            : base()
        {
        }

        public FitException(string message)
            : base(message)
        {
        }

        public FitException(string str, Exception e)
            : base(str, e)
        {
        }
        #endregion
    }
} // namespace
