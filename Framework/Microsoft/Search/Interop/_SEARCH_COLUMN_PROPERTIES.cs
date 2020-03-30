namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=8)]
    public struct _SEARCH_COLUMN_PROPERTIES
    {
        public tag_inner_PROPVARIANT Value;
        public uint lcid;
    }
}

