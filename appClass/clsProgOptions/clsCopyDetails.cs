using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace appFelxMax.appClass.clsProgOptions
{
    class clsCopyDetails
    {

        public string vMac;

        public void GetMACAddress(TextBox vTXT)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                    vMac = sMacAddress.ToString();
                    vTXT.Text = vMac;
                }
            }
        }


        // IPV4 
        #region IPV4

        // IPV4 Strings
        private string vLocalIP;
        private IPHostEntry iPHost;

        // IPV4 Get
        public void fnGetIPV4(Label label)
        {
            iPHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in iPHost.AddressList)
            {
                if (iPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    vLocalIP = iPAddress.ToString();
                    label.Text = vLocalIP;
                }
            }

        }

        #endregion



    }
}
