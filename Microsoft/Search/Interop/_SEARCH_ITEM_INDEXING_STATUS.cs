namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct _SEARCH_ITEM_INDEXING_STATUS
    {
        public uint dwDocID;
        [MarshalAs(UnmanagedType.Error)]
        public int hrIndexingStatus;
    }
}

