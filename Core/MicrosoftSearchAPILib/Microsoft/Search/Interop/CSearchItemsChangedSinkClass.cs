namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, ClassInterface((short) 0), Guid("A5270F6C-19EC-4E17-9EA1-A7074276B9B9")]
    public class CSearchItemsChangedSinkClass : ISearchItemsChangedSink, CSearchItemsChangedSink
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void OnItemsChanged([In] uint dwNumberOfChanges, [In] ref _SEARCH_ITEM_CHANGE rgDataChangeEntries, out uint rgdwDocIds, [MarshalAs(UnmanagedType.Error)] out int rghrCompletionCodes);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void StartedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void StoppedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
    }
}

