namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct tagSAFEARRAYBOUND
    {
        public uint cElements;
        public int lLbound;
    }
}

