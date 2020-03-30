namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, ClassInterface((short) 0), Guid("321069D2-2D7A-4AA1-9DC3-BA97CDF9AFB4")]
    public class CSearchCrawlScopeManagerClass : ISearchCrawlScopeManager, CSearchCrawlScopeManager
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void AddDefaultScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, [In] int fInclude, [In] uint fFollowFlags);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void AddHierarchicalScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, [In] int fInclude, [In] int fDefault, [In] int fOverrideChildren);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void AddRoot([In, MarshalAs(UnmanagedType.Interface)] CSearchRoot pSearchRoot);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void AddUserScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, [In] int fInclude, [In] int fOverrideChildren, [In] uint fFollowFlags);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CEnumSearchRoots EnumerateRoots();
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CEnumSearchScopeRules EnumerateScopeRules();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern int GetParentScopeVersionId([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern int HasChildScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern int HasParentScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern int IncludedInCrawlScope([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void IncludedInCrawlScopeEx([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl, out int pfIsIncluded, [ComAliasName("Microsoft.Search.Interop.CLUSION_REASON")] out CLUSION_REASON pReason);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void RemoveDefaultScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void RemoveRoot([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void RemoveScopeRule([In, MarshalAs(UnmanagedType.LPWStr)] string pszRule);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void RevertToDefaultScopes();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void SaveAll();
    }
}

