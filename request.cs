using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace API_Testing
{
    class Request
    {
        public string response;
        public async void GetTodoItems()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(
                "http://api.exchangeratesapi.io/v1/latest?access_key=22fb21fe653bebe97e7b54023f57c006&format=1");
            Console.WriteLine(response);
        }
    }
}