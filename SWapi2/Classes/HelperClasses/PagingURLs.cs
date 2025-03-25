namespace SWapi2.Classes.HelperClasses

{
    internal static class PagingURLs
    {
        ///<Summary>
        ///    Gets a List of page URLs. swapi.dev returns 10 results per page
        ///    Can be used generically for any reponse that has a count over 10
        ///</Summary>
        public static List<string> GetPagingURLs(int resourceRootCount)
        {
            List<string> pagingURLs = new List<string>();

            // Work out how many pages of resource results there are
            // 10 results per page. Add 1 extra page for any modulus remainder
            int numberOfPages = resourceRootCount / 10 + (resourceRootCount % 10 == 0 ? 0 : 1);

            for (int iCount = 1; iCount != numberOfPages + 1; iCount++)
            {
                string pagingURL = $"?page={iCount}";
                pagingURLs.Add(pagingURL);
            }
            return pagingURLs;
        }
    }
}
