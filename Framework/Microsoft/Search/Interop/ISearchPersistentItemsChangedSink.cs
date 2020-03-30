namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("A2FFDF9B-4758-4F84-B729-DF81A1A0612F"), InterfaceType((short) 1)]
    public interface ISearchPersistentItemsChangedSink
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void StartedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void StoppedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void OnItemsChanged([In] uint dwNumberOfChanges, [In] ref _SEARCH_ITEM_PERSISTENT_CHANGE DataChangeEntries, [MarshalAs(UnmanagedType.Error)] out int hrCompletionCodes);
    }
}

