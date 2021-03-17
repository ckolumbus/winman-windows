﻿using System;
using System.ComponentModel;

namespace WinMan.Implementation.Win32
{
    internal static class ExceptionExtensions
    {
        internal static bool IsInvalidWindowHandleException(this Exception e)
        {
            return e is Win32Exception && (e.Message == "Invalid window handle" || e.Message == "The handle is invalid");
        }
        internal static bool IsInvalidMonitorHandleException(this Exception e)
        {
            return e is Win32Exception && (e.Message == "Invalid monitor handle" || e.Message == "The handle is invalid");
        }
    }
}
