using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Client;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Tests
{
    public static class Constants
    {
        public static string API_URL = "https://app.vindi.com.br/api/";
        public static string API_KEY = "YOUR_API_KEY";
        public static string API_VERSION = "v1";

        public static IVindiHttpClient CreateClient()
        {
            return new VindiHttpClient(new Uri(API_URL), API_KEY, API_VERSION);
        }
    }
}
