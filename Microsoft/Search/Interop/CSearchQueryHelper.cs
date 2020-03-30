namespace Microsoft.Search.Interop
{
    using System.Runtime.InteropServices;

    [ComImport, Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF63"), CoClass(typeof(CSearchQueryHelperClass))]
    public interface CSearchQueryHelper : ISearchQueryHelper
    {
    }
}

