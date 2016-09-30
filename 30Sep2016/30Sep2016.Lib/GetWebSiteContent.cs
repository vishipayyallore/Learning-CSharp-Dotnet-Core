using System;
using System.Net.Http;
using static System.Console;

namespace _30Sep2016.Lib
{
    public class GetWebSiteContent
    {

        public async void Run(string urlOfWebSite, string pageName)
        {
            var httpClient = new HttpClient {BaseAddress = new Uri(urlOfWebSite)};
            var output = await httpClient.GetAsync(pageName);

            WriteLine($"{output.StatusCode}");

            WriteLine($"{output.Content.Headers.GetValues("Content-Type")}");

            WriteLine($"{output.Content.ReadAsStringAsync()}");
        }

    }
}
