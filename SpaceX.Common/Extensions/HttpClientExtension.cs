namespace SpaceX.Common.Extensions
{
    public static class HttpClientExtension
    {
        public static HttpClient AddHttpHeaders(
            this HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
            return httpClient;
        }
    }
}
