using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace testApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            GetHardwareDetails();
        }

        public void GetHardwareDetails()
        {
            byte[] myDeviceID = (byte[])Microsoft.Phone.Info.DeviceExtendedProperties.GetValue("DeviceUniqueId");
            string macAddress = BitConverter.ToString(myDeviceID);
            string idAsString = Convert.ToBase64String(myDeviceID);
            string Manufacturer = (string)Microsoft.Phone.Info.DeviceExtendedProperties.GetValue("DeviceManufacturer");
            string DeviceName = (string)Microsoft.Phone.Info.DeviceExtendedProperties.GetValue("DeviceName");
            MessageBox.Show("myDeviceMAC:" + macAddress + "\nmyDeviceID:" + idAsString + "\nManufacturer:" + Manufacturer + "\nDeviceName:" + DeviceName);
        }
    }
}