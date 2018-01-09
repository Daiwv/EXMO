using ExmoData;
using ExmoData.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmoData
{
    public class ExmoDt
    {
        const string KeyAPI = "K-d4585758b1faaa6b407788c3d9b360c0ca7c3536";
        const string SecretAPI = "S-7fbcbfb53f8069a84214990e61ac2e2386ed8c10";

        public ExmoApi exmoApi;
        public ExmoDt()
        {
            exmoApi = new ExmoApi(KeyAPI, SecretAPI);
        }

        public UserInfo GetUserInfo()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            var task = exmoApi.ApiQueryAsync("user_info", res);

            return JsonConvert.DeserializeObject<UserInfo>(task.Result);
             
        }

        public Dictionary<string, Ticker> GetTicker()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            return Ticker.FromJson(exmoApi.ApiQuery("ticker", res));
        }
    }
}
