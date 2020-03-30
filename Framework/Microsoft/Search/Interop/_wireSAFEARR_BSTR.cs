namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct _wireSAFEARR_BSTR
    {
        public uint Size;
        [ComConversionLoss]
        public IntPtr aBstr;
    }
}

