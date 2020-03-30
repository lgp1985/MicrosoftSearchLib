namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct _SHORT_SIZEDARR
    {
        public uint clSize;
        [ComConversionLoss]
        public IntPtr pData;
    }
}

