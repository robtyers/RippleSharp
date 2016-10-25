using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RippleSharp.Rippled.Tests.RpcJson.TestData.MessageHandler
{
    public class RippleSharpMessageHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var method = GetRequestMethod(request);
            var apiMethod = ConvertToPascalCase(method);
            var response = GetResponseContent(apiMethod);

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);

            return tsc.Task;  
        }

        private static string GetRequestMethod(HttpRequestMessage request)
        {
            var requestContent = request.Content.ReadAsStringAsync().Result;
            var content = JObject.Parse(requestContent);
            var method = content["method"]?.ToString();

            if(string.IsNullOrEmpty(method))
                throw new ArgumentException("Field 'Method' not found in request!");

            return method;
        }

        private static string ConvertToPascalCase(string snakeCase)
        {
            var info = CultureInfo.CurrentCulture.TextInfo;

            return info
                .ToTitleCase(snakeCase.Replace("_", " "))
                .Replace(" ", string.Empty);
        }

        private static HttpResponseMessage GetResponseContent(string method)
        {
            var content = GetContent(method);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(content)
            };
        }

        private static string GetContent(string method)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"RippleSharp.Rippled.Tests.RpcJson.TestData.{method}.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
                if (stream != null)
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }

            throw new ArgumentException($"{method} not found!");
        }
    }
}
