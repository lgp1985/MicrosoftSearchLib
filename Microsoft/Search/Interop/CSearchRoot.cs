namespace Microsoft.Search.Interop
{
    using System.Runtime.InteropServices;

    [ComImport, Guid("04C18CCF-1F57-4CBD-88CC-3900F5195CE3"), CoClass(typeof(CSearchRootClass))]
    public interface CSearchRoot : ISearchRoot
    {
    }
}

