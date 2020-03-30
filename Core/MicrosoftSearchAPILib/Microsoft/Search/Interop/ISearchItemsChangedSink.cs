namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF58"), InterfaceType((short) 1)]
    public interface ISearchItemsChangedSink
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void StartedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void StoppedMonitoringScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void OnItemsChanged([In] uint dwNumberOfChanges, [In] ref _SEARCH_ITEM_CHANGE rgDataChangeEntries, out uint rgdwDocIds, [MarshalAs(UnmanagedType.Error)] out int rghrCompletionCodes);
    }
}

