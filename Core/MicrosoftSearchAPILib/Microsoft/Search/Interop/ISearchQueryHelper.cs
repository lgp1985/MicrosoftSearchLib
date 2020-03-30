namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF63"), InterfaceType((short) 1)]
    public interface ISearchQueryHelper
    {
        [DispId(0x60010000)]
        string ConnectionString { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [DispId(0x60010001)]
        uint QueryContentLocale { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x60010003)]
        uint QueryKeywordLocale { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x60010005)]
        _SEARCH_TERM_EXPANSION QueryTermExpansion { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x60010007)]
        _SEARCH_QUERY_SYNTAX QuerySyntax { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x60010009)]
        string QueryContentProperties { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x6001000b)]
        string QuerySelectColumns { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x6001000d)]
        string QueryWhereRestrictions { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x6001000f)]
        string QuerySorting { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [return: MarshalAs(UnmanagedType.LPWStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        string GenerateSQLFromUserQuery([In, MarshalAs(UnmanagedType.LPWStr)] string pszQuery);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void WriteProperties([In] int itemID, [In] uint dwNumberOfColumns, [In] ref _tagpropertykey pColumns, [In] ref _SEARCH_COLUMN_PROPERTIES pValues, [In] ref _FILETIME pftGatherModifiedTime);
        [DispId(0x60010013)]
        int QueryMaxResults { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

