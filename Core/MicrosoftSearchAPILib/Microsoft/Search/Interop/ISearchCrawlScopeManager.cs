namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF55"), InterfaceType((short) 1)]
    public interface ISearchCrawlScopeManager
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void AddDefaultScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, [In] int fInclude, [In] uint fFollowFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void AddRoot([In, MarshalAs(UnmanagedType.Interface)] CSearchRoot pSearchRoot);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoveRoot([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        CEnumSearchRoots EnumerateRoots();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void AddHierarchicalScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, [In] int fInclude, [In] int fDefault, [In] int fOverrideChildren);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void AddUserScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, [In] int fInclude, [In] int fOverrideChildren, [In] uint fFollowFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoveScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszRule);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        CEnumSearchScopeRules EnumerateScopeRules();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int HasParentScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int HasChildScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int IncludedInCrawlScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void IncludedInCrawlScopeEx([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, out int pfIsIncluded, [ComAliasName("Microsoft.Search.Interop.CLUSION_REASON")] out CLUSION_REASON pReason);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RevertToDefaultScopes();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void SaveAll();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int GetParentScopeVersionId([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoveDefaultScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
    }
}

