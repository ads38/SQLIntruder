using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.Net.NetworkInformation;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
         //   EnumComputers();
            myclass d = new myclass();
            d.addEle();
            d.Getstr();
            EnumComputers();
        }


        private static void EnumComputers()

        {
           
                for (int i = 1; i <= 255; i++)
                {
                    Ping myPing;
                    myPing = new Ping();
                    myPing.PingCompleted += new PingCompletedEventHandler(_myPing_PingCompleted);

                    string pingIP = "192.168.42." + i.ToString();
                    myPing.SendAsync(pingIP, 100);
                }
           
        }

       static void _myPing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Reply.Status == IPStatus.Success)
            {
                Console.WriteLine(e.Reply.Address.ToString() + "|" + Dns.GetHostByAddress(IPAddress.Parse(e.Reply.Address.ToString())).HostName);
            }

        }

    }

    class myclass
    {
        private  List<string> strs;
        public myclass()
        {
            this.strs = new List<string>();   
        }

        public void addEle()
        {
            strs.Add("ddddd");
            strs.Add("8gf9d");
        }

        public List<string> Getstr()
        {
            return strs;
        }
    }
}

