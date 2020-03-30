﻿namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct tagCAUL
    {
        public uint cElems;
        [ComConversionLoss]
        public IntPtr pElems;
    }
}

