﻿using System;
using System.IO;
using System.Net;

namespace codeql_example
{
    class Program
    {
        public static string str = "adfwaefrSSS#3444F^%^&FFFdjfsgdsngAAAAAPPFPDSfdsfdsf45$$$=F";

        static void Main(string[] args)
        {
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
