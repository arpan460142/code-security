using System;
using System.IO;
using System.Net;

namespace codeql_example
{
    class Program
    {
        public static string password = "arpan@123";

        static void Main(string[] args)
        {
            var txtSQL = "SELECT * FROM Users WHERE UserId = " + args[0];

            throw new ArgumentException("Thrown in " + AppDomain.CurrentDomain.FriendlyName);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google.com"); // Noncompliant

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();
            //var data = Content(responseFromServer);

            Console.WriteLine("Hello World!");
        }
    }
}
