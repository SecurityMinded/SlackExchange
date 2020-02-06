using Microsoft.AspNetCore.Http;

namespace SlackExchange.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            
            // Resolve angular cors errors
            // response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            // response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}