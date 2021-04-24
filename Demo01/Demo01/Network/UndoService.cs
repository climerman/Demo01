using System;
using System.Net.Http;
using System.Threading.Tasks;
using Demo01.Models;
using Newtonsoft.Json;

namespace Demo01.Network
{
    public class UndoService : IUndoService
    {
        #region "Fields"

        public static HttpClient _instance { get; set; }

        #endregion

        public UndoService()
        {
            if (_instance == null)
                _instance = new HttpClient { BaseAddress = new Uri("https://api.undoapp.com/api/v1/") };
        }

        public async Task<HealthCheckModel> GetHeathCheck()
        {
            var response = await _instance.GetAsync("healthcheck");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    return JsonConvert.DeserializeObject<HealthCheckModel>(content);
                }
            }
            return new HealthCheckModel();
        }

        public async Task<TestErrorModel> GetTestError()
        {
            var response = await _instance.GetAsync("healthcheck/testerror");

            var content = await response?.Content?.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TestErrorModel>(content);
        }
    }
}
