namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct _wireSAFEARR_DISPATCH
    {
        public uint Size;
        [ComConversionLoss]
        public IntPtr apDispatch;
    }
}

