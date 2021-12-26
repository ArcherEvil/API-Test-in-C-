using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace API_Testing
{
    class Program
    {
        
        static async Task Main(string[] args)
        {
            
        }
    
      
        public async Task GetTodoItems()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(
                "http://api.exchangeratesapi.io/v1/latest?access_key=22fb21fe653bebe97e7b54023f57c006&format=1");
            Console.WriteLine(response);
        }
    }

}
