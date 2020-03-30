namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("D0F268B5-EA7A-4B35-BF2F-E1A091B80D51"), ClassInterface((short) 0)]
    public class CSearchPersistentItemsChangedSinkClass : ISearchPersistentItemsChangedSink, CSearchPersistentItemsChangedSink
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void OnItemsChanged([In] uint dwNumberOfChanges, [In] ref _SEARCH_ITEM_PERSISTENT_CHANGE DataChangeEntries, [MarshalAs(UnmanagedType.Error)] out int hrCompletionCodes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void StartedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void StoppedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
    }
}

