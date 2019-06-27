using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
namespace SQLIntruder
{
    /// <summary>
    /// IP地址服务提供类
    /// </summary>
    class IPSrvProvider
    {
      
        private Ping ping;
        private bool Connected;
        public IPSrvProvider()
        {
            ping = new Ping();
            Connected = false;
        }

        /// <summary>
        /// 网络测试，用于判断本地计算机是否与网络联通,但不能判断网线是否断开
        /// </summary>
        /// <returns>返回一个bool值，为true则已经联网，否则为断开网络连接</returns>
        public bool IsConnected()
        {
            try
            {
                if (ping.Send("www.qq.com", 2500).Status == IPStatus.Success)
                    this.Connected = true;
                else
                    Connected = false;
            }
            catch (Exception)
            {
                return false;
            }
            return Connected;
        }
       
        public string GetLocalIP()
        {
            string hostName = Dns.GetHostName();
            string LocalIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return LocalIP;
        }

        public string GetLocalhostName()
        {
            return Dns.GetHostName();
        }

        /// <summary>
        /// 根据远程计算机ip地址，获取远程主机的计算机名
        /// </summary>
        /// <param name="RemoteIP">需要的远程计算机的IP地址</param>
        /// <returns>string，返回远程计算机名称</returns>
        public string GetRemoteHostNameByIP(string RemoteIP)
        {
                return Dns.GetHostByAddress(RemoteIP).HostName;
        }


        public string[] GetSplitedIP(string IP)
        {
            string temp = IP;
            return temp.Split('.');
        }
    }
}
