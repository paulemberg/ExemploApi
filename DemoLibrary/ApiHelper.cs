using System.Net.Http;
using System.Net.Http.Headers;

namespace DemoLibrary
{
    public static class ApiHelper
    {
        //http://xkcd.com/info.0.json 
        //http://xkcd.com/614/info.0.json 
        public static HttpClient ApiClient { get;set;}

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();            
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
