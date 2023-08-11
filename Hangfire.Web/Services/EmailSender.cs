using System.Net.Http.Headers;

namespace Hangfire.Web.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string userId, string message)
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://rapidprod-sendgrid-v1.p.rapidapi.com/mail/send"),
                Headers =
                {
                    {"X-RapidAPI-Key", "d9d753e652msh3d599c792f5943ep1cdf35jsn7dd24c9a95c6"},
                    {"X-RapidAPI-Host", "rapidprod-sendgrid-v1.p.rapidapi.com"},
                },
                Content = new StringContent(
                    $"{{\r\n    \"personalizations\": [\r\n        {{\r\n            \"to\": [\r\n                {{\r\n                    \"email\": \"abdullahdinler35@gmail.com\"\r\n                }}\r\n            ],\r\n            \"subject\": \"Hello, World!\"\r\n        }}\r\n    ],\r\n    \"from\": {{\r\n        \"email\": \"contact@abdullahdinler.dev\"\r\n    }},\r\n    \"content\": [\r\n        {{\r\n            \"type\": \"text/plain\",\r\n            \"value\": \"{message}!\"\r\n        }}\r\n    ]\r\n}}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
