﻿namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct tagTLIBATTR
    {
        public Guid guid;
        public uint lcid;
        public tagSYSKIND syskind;
        public ushort wMajorVerNum;
        public ushort wMinorVerNum;
        public ushort wLibFlags;
    }
}

