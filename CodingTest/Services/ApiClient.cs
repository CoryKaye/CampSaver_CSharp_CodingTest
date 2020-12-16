using CodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Services
{
    public class ApiClient
    {
        private HttpClient _apiClient;

        public ApiClient()
        {
            _apiClient = new HttpClient();
        }

        public IEnumerable<YesNoResponse> GetYesNoResponses(string api, string numResults)
        {
            throw new NotImplementedException();
        }
    }
}
