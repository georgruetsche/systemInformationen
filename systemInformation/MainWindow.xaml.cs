using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace systemInformation
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string test = "Systeminformation";

        public string Test

        {

            get { return test; }

            set { test = value; }

        }

        public List<String> Items
        {
            get { return list; }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DriveSpace();
            this.DataContext = this;
           
        }

        public List<string> list = new List<string>();

        public void DriveSpace()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            //List<string> list = new List<string>();
            foreach (DriveInfo d in allDrives)
            {
                list.Add($"Drive { d.Name}");
                list.Add($"Drive type { d.DriveType}");
                if (d.IsReady == true)

                list.Add($"Volume label: { d.VolumeLabel}");
                list.Add($"File system: { d.DriveFormat}");
                list.Add($"Available space to current user: bytes,{ d.AvailableFreeSpace}");
                list.Add($"Total available space: bytes, { d.TotalFreeSpace} ");
                list.Add($"Total size of drive: bytes { d.TotalSize}");
                list.Add($"-----------------------------------------");
                list.Add($" OSVersion:  { Environment.OSVersion.ToString()}");
                list.Add($" OSVersion.Platform:  { Environment.OSVersion.Platform }");
                list.Add($" OSVersion.Version:  { Environment.OSVersion.VersionString }");
                list.Add($" CurrentCulture:  { Application.CurrentCulture.ToString() }");
                list.Add($" Bootmode:  { SystemInformation.BootMode.ToString() }");

            }
            }
        }
    }

