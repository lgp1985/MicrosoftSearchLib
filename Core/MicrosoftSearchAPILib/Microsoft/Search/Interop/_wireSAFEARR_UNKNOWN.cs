namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct _wireSAFEARR_UNKNOWN
    {
        public uint Size;
        [ComConversionLoss]
        public IntPtr apUnknown;
    }
}

