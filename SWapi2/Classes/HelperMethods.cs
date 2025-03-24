namespace SWapi2.Classes
{
    ///<Summary>
    ///    Contains Helper methods for the application
    ///</Summ
    internal static class HelperMethods
    {
        ///<Summary>
        ///    Gets a List of page URLs
        ///</Summary>
        public static List<string> GetPagingURLs(int resourceRootCount)
        {
            List<string> pagingURLs = new List<string>();

            // Work out how many pages of resource results there are
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
