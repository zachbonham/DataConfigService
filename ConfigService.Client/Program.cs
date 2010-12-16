using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfigService.Client.ConfigService;

namespace ConfigService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ConfigEntities(new System.Uri("http://localhost/configservice/configservice.svc"));

            var cs = client.ConnectionStrings.Where(c => c.Name == "GenesisLogging").FirstOrDefault();

            if (cs != null)
            {
                Console.WriteLine("The 'GenesisLogging' connection string is: " + cs.Data);
            }

            Console.ReadLine();
        }
    }
}
