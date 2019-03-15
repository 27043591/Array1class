using System;
using System.Net;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://uinames.com/api/?amount=2";

            string json = new WebClient().DownloadString(url);

            Console.WriteLine(json);

            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);

            foreach(CustomObject x in data)
            {
                Console.WriteLine("Name: {0}\nsuername :{1}\nGender: {2}\nRegion: {3}\nage: {4}\ntittle: {5}\nphone: {6}\n", x.name, x.surname, x.gender, x.region, x.age, x.tittle,x.phone);
            }

            Console.ReadLine();
        }

        public class CustomObject
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string gender { get; set; }
            public string region { get; set; }
            public int age { get; set; }
            public string tittle { get; set; }
            public int phone { get; set; }
            public CreditCard credit_card { get; set; }
            public Birthday birthday { get; set; }
            public string photo { get; set; }

            
        }
         public class CreditCard
        {
            public string number { get; set; }
            public string expiration { get; set; }
            public int pin { get; set; }
            public int security { get; set; }
        }

        public class Birthday
        {
            public string dmy { get; set; }
            public string mdy { get; set; }
            public int raw { get; set; }
        }
        
    }
}
