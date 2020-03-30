namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct tagBSTRBLOB
    {
        public uint cbSize;
        [ComConversionLoss]
        public IntPtr pData;
    }
}

