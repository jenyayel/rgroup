using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace Rg.ClientApp
{
    public static class RgApiJenyaAppServiceExtensions
    {
        public static RgApiJenya CreateRgApiJenya(this IAppServiceClient client)
        {
            return new RgApiJenya(client.CreateHandler());
        }

        public static RgApiJenya CreateRgApiJenya(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new RgApiJenya(client.CreateHandler(handlers));
        }

        public static RgApiJenya CreateRgApiJenya(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new RgApiJenya(uri, client.CreateHandler(handlers));
        }

        public static RgApiJenya CreateRgApiJenya(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new RgApiJenya(rootHandler, client.CreateHandler(handlers));
        }
    }
}
