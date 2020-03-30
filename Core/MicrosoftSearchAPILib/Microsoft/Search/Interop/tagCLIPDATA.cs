namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct tagCLIPDATA
    {
        public uint cbSize;
        public int ulClipFmt;
        [ComConversionLoss]
        public IntPtr pClipData;
    }
}

