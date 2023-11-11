using System;
using System.Collections;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace appFelxMax.appClass.clsProgOptions
{
    class clsCopyDetails
    {

        // MAC Address
        #region MAC 

        public static PhysicalAddress fnGetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

        #endregion


        // Motherboard
        #region Motherboard

        public void fnMotherboardInfo(TextBox vtextMotherboard)
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            foreach (ManagementObject getserial in MOS.Get())
            {
                vtextMotherboard.Text = getserial["SerialNumber"].ToString();
            }
        }

        #endregion


        // Hard Disk 
        #region Hard Disk

        private string model = null;
        private string type = null;
        private string serialNo = null;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

        public void fnGetHDD(TextBox textSig)
        {
            // Declare Array
            ArrayList vHDDetails = new ArrayList();

            // Get HDDSerial
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                clsCopyDetails vHDD = new clsCopyDetails();
                //Model Number
                vHDD.Model = wmi_HD["Model"].ToString();
                //Interface Type
                vHDD.Type = wmi_HD["InterfaceType"].ToString();
                //Serial Number
                vHDD.SerialNo = wmi_HD["SerialNumber"].ToString();
                vHDDetails.Add(vHDD);
                textSig.Text = vHDD.Model + vHDD.Type;
            }
        }

        #endregion


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
