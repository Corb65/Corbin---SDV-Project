using System;
using System.ServiceModel;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Main program initialization. Added code to write lines of text in the console

namespace Selfhost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a ServiceHost
            using (ServiceHost serviceHost = new ServiceHost(typeof(Service1)))
            {
                // Open the ServiceHost to create listeners
                // and start listening for messages
                serviceHost.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
