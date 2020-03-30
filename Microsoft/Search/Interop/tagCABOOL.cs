namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct tagCABOOL
    {
        public uint cElems;
        [ComConversionLoss]
        public IntPtr pElems;
    }
}

