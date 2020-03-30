﻿namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct tagCAI
    {
        public uint cElems;
        [ComConversionLoss]
        public IntPtr pElems;
    }
}

