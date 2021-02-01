using System;
using System.IO;
using System.Net;
using System.Xml.XPath;

namespace codeql_example
{
    class Program
    {
        public static string password = "arpan@123";

        public static XPathNavigator AuthorizedOperations { get; set; }

        static void Main(string[] args)
        {
            try
            {
                XPathNavigator node = AuthorizedOperations.SelectSingleNode(
            "//authorizedOperation[@username = 'anonymous' and @operationName = '" + args[0].ToString() + "']");

                throw new ArgumentException("Thrown in " + AppDomain.CurrentDomain.FriendlyName);
            }
            finally
            {

            }
            var txtSQL = "SELECT * FROM Users WHERE UserId = " + args[0];


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
