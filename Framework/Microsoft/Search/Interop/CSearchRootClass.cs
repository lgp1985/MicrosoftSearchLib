namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, TypeLibType((short) 2), Guid("30766BD2-EA1C-4F28-BF27-0B44E2F68DB7"), ClassInterface((short) 0)]
    public class CSearchRootClass : ISearchRoot, CSearchRoot
    {
        [DispId(0x60010000)]
        public virtual extern string Schedule { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010002)]
        public virtual extern string RootURL { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010004)]
        public virtual extern int IsHierarchical { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010006)]
        public virtual extern int ProvidesNotifications { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010008)]
        public virtual extern int UseNotificationsOnly { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000a)]
        public virtual extern uint EnumerationDepth { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000c)]
        public virtual extern uint HostDepth { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000e)]
        public virtual extern int FollowDirectories { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010010)]
        public virtual extern _AUTH_TYPE AuthenticationType { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010012)]
        public virtual extern string User { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010014)]
        public virtual extern string Password { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010000)]
        extern string Microsoft.Search.Interop.ISearchRoot.Schedule { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010002)]
        extern string Microsoft.Search.Interop.ISearchRoot.RootURL { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010004)]
        extern int Microsoft.Search.Interop.ISearchRoot.IsHierarchical { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010006)]
        extern int Microsoft.Search.Interop.ISearchRoot.ProvidesNotifications { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010008)]
        extern int Microsoft.Search.Interop.ISearchRoot.UseNotificationsOnly { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000a)]
        extern uint Microsoft.Search.Interop.ISearchRoot.EnumerationDepth { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000c)]
        extern uint Microsoft.Search.Interop.ISearchRoot.HostDepth { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000e)]
        extern int Microsoft.Search.Interop.ISearchRoot.FollowDirectories { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010010)]
        extern _AUTH_TYPE Microsoft.Search.Interop.ISearchRoot.AuthenticationType { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010012)]
        extern string Microsoft.Search.Interop.ISearchRoot.User { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010014)]
        extern string Microsoft.Search.Interop.ISearchRoot.Password { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

