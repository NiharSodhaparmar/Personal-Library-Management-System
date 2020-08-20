using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(LibraryManagement.BooksService)))
            {
                sh.Open();
                Console.WriteLine("Host has started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
