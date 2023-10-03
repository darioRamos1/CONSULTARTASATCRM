using ConsoleApp2.TcrmService;
using System;
using System.ServiceModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            EndpointAddress address = new EndpointAddress("https://www.superfinanciera.gov.co/SuperfinancieraWebServiceTRM/TCRMServicesWebService/TCRMServicesWebService?WSDL");
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport; // Usando HTTPS
            TcrmServicesInterfaceClient client = new TcrmServicesInterfaceClient(binding, address);

            try
            {
                //  var result = client.queryTCRM(DateTime.Parse("2023-06-23").ToString());
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");

                var result = client.queryTCRM(fecha);
                Console.WriteLine(result.value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }


}
