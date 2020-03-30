namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct tagPARAMDESC
    {
        [ComConversionLoss]
        public IntPtr pparamdescex;
        public ushort wParamFlags;
    }
}

