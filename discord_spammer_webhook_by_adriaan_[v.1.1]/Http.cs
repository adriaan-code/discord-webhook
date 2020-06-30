using System.Net;

namespace discord_spammer_webhook_by_adriaan__v._1._1_
{
    class Http
    {
        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            using (WebClient webClient = new WebClient())
                return webClient.UploadValues(uri, pairs);
        }
    }
}
