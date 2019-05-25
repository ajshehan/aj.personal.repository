using System;
using WCF_TestClient.ServiceReference1;

namespace WCF_TestClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new Service1Client();
            proxy.Open();

            Console.WriteLine(proxy.GetData(42));

            var compositeResult = proxy.GetDataUsingDataContract(new CompositeType
            {
                BoolValue = true,
                StringValue = "Test"
            });

            Console.WriteLine($"Composite Result Bool Value: {compositeResult.BoolValue}");
            Console.WriteLine($"Composite Result String Value: {compositeResult.StringValue}");
            proxy.Close();
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
