using System;
using System.Linq;
using System.Net.Http;
using static System.Console;

namespace _30Sep2016.Lib
{
    public class GetWebSiteContent
    {
        private const string ContentType = "Content-Type";

        #region Methods
        public async void Run(string urlOfWebSite, string pageName)
        {
            try
            {
                using (var httpClient = new HttpClient { BaseAddress = new Uri(urlOfWebSite) })
                {
                    var output = await httpClient.GetAsync(pageName);

                    WriteLine($"{output.StatusCode}");

                    WriteLine($"{output.Content.Headers.GetValues(ContentType).FirstOrDefault()}");

                    WriteLine($"{output.Content.ReadAsStringAsync().Result}");
                }
            }
            catch (Exception errorObject)
            {
                WriteLine($"{errorObject.Message}");
            }
            
        }
        #endregion

    }
}
