namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF65"), InterfaceType((short) 1)]
    public interface ISearchViewChangedSink
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void OnChange([In] ref int pdwDocID, [In] ref _SEARCH_ITEM_CHANGE pChange, [In] ref int pfInView);
    }
}

