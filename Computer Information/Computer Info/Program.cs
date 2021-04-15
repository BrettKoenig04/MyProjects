using System;
using System.IO;
using System.Management;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Computer_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Basic Computer Information - v1.0]\n");

            do
            {
                Console.WriteLine("Select the number of your choice to find more information on the following:");
                Console.WriteLine("1: OS");
                Console.WriteLine("2: BIOS");
                Console.WriteLine("3: CPU");
                Console.WriteLine("4: GPU");
                Console.WriteLine("5: DISK");
                Console.WriteLine("6: RAM");
                Console.WriteLine("7: NET");
                Console.WriteLine("8: SOUND");
                Console.WriteLine("9: MONITOR");
                Console.WriteLine("10: USB");
                Console.WriteLine("11: QUIT");
                Console.Write("Enter the number of your choice: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        OperatingSystemInfo();
                        break;
                    case "2":
                        Console.Clear();
                        BiosInformation();
                        break;
                    case "3":
                        Console.Clear();
                        CpuInformation();
                        break;
                    case "4":
                        Console.Clear();
                        GpuInformation();
                        break;
                    case "5":
                        Console.Clear();
                        DiskInformation();
                        break;
                    case "6":
                        Console.Clear();
                        ramInformation();
                        break;
                    case "7":
                        Console.Clear();
                        NetworkInformation();
                        break;
                    case "8":
                        Console.Clear();
                        SoundInformation();
                        break;
                    case "9":
                        Console.Clear();
                        MonitorInformation();
                        break;
                    case "10":
                        Console.Clear();
                        usbInformation();
                        break;
                    case "11":
                        Console.Clear();
                        Quit();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nError has occured, please try again.\n");
                        break;
                }
            } while (true);
        }


        private static void OperatingSystemInfo()
        {
            const string columnFormat = "| {0,-35} | {1,-55} |";
            ManagementObjectSearcher operatingSystemObj = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            string result = new String('-', 95);

            try
            {
                foreach (ManagementObject obj in operatingSystemObj.Get())
                {
                    Console.WriteLine(" " + result);
                    Console.WriteLine(String.Format(columnFormat, "Name", obj["Caption"]));
                    Console.WriteLine(String.Format(columnFormat, "Windows Directory", obj["WindowsDirectory"]));
                    Console.WriteLine(String.Format(columnFormat, "Product Type", obj["ProductType"]));
                    Console.WriteLine(String.Format(columnFormat, "Serial Number", obj["SerialNumber"]));
                    Console.WriteLine(String.Format(columnFormat, "System Directory", obj["SystemDirectory"]));
                    Console.WriteLine(String.Format(columnFormat, "Encryption Level", obj["EncryptionLevel"]));
                    Console.WriteLine(String.Format(columnFormat, "OS Type", obj["OSType"]));
                    Console.WriteLine(String.Format(columnFormat, "Version", obj["Version"]));
                    Console.WriteLine(" " + result);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }


        private static void BiosInformation()
        {
            const string columnFormat = "| {0,-35} | {1,-55} |";
            ManagementObjectSearcher biosObj = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            string result = new String('-', 95);

            try
            {
                foreach (ManagementObject obj in biosObj.Get())
                {
                    Console.WriteLine(" " + result);
                    Console.WriteLine(String.Format(columnFormat, "Manufacturer", obj["Manufacturer"]));
                    Console.WriteLine(String.Format(columnFormat, "Primary BIOS", obj["PrimaryBIOS"]));
                    Console.WriteLine(String.Format(columnFormat, "Serial Number", obj["SerialNumber"]));
                    Console.WriteLine(String.Format(columnFormat, "Status", obj["Status"]));
                    Console.WriteLine(String.Format(columnFormat, "BIOS Version", obj["Version"]));
                    Console.WriteLine(" " + result);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }


        private static void CpuInformation()
        {
            const string columnFormat = "| {0,-35} | {1,-55} |";
            ManagementObjectSearcher cpuObj = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            string result = new String('-', 95);

            try
            {
                foreach (ManagementObject obj in cpuObj.Get())
                {
                    Console.WriteLine(" " + result);
                    Console.WriteLine(String.Format(columnFormat, "Name", obj["Name"]));
                    Console.WriteLine(String.Format(columnFormat, "Device ID", obj["DeviceID"]));
                    Console.WriteLine(String.Format(columnFormat, "Manufacturer", obj["Manufacturer"]));
                    Console.WriteLine(String.Format(columnFormat, "Current ClockSpeed", obj["CurrentClockSpeed"]));
                    Console.WriteLine(String.Format(columnFormat, "Core Count", obj["NumberOfCores"]));
                    Console.WriteLine(String.Format(columnFormat, "Enabled Cores", obj["NumberOfEnabledCore"]));
                    Console.WriteLine(String.Format(columnFormat, "Logical Processors", obj["NumberOfLogicalProcessors"]));
                    Console.WriteLine(String.Format(columnFormat, "Architecture", obj["Architecture"]));
                    Console.WriteLine(String.Format(columnFormat, "Family", obj["Family"]));
                    Console.WriteLine(String.Format(columnFormat, "Processor Type", obj["ProcessorType"]));
                    Console.WriteLine(String.Format(columnFormat, "Characteristics", obj["Characteristics"]));
                    Console.WriteLine(String.Format(columnFormat, "Address Width", obj["NumberOfLogicalProcessors"]));
                    Console.WriteLine(" " + result);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }


        private static void GpuInformation()
        {
            const string columnFormat = "| {0,-35} | {1,-55} |";
            ManagementObjectSearcher gpuObj = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            string result = new String('-', 95);

            try
            {
                foreach (ManagementObject obj in gpuObj.Get())
                {
                    Console.WriteLine(" " + result);
                    Console.WriteLine(String.Format(columnFormat, "Name", obj["Name"]));
                    Console.WriteLine(String.Format(columnFormat, "Status", obj["Status"]));
                    Console.WriteLine(String.Format(columnFormat, "Device ID", obj["DeviceID"]));
                    Console.WriteLine(String.Format(columnFormat, "Adapter RAM", obj["AdapterRAM"]));
                    Console.WriteLine(String.Format(columnFormat, "Adapter DAC Type", obj["AdapterDACType"]));
                    Console.WriteLine(String.Format(columnFormat, "Driver Version", obj["DriverVersion"]));
                    Console.WriteLine(String.Format(columnFormat, "Video Processor", obj["VideoProcessor"]));
                    Console.WriteLine(String.Format(columnFormat, "Video Architecture", obj["VideoArchitecture"]));
                    Console.WriteLine(String.Format(columnFormat, "Video Memory Type", obj["VideoMemoryType"]));
                    Console.WriteLine(" " + result);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }


        private static void DiskInformation()
        {
            const string columnFormat = "| {0,-35} | {1,-55} |";
            DriveInfo[] totalDrives = DriveInfo.GetDrives();
            string result = new String('-', 95);

            try
            {
                foreach (DriveInfo d in totalDrives)
                {
                    if (d.IsReady == true)
                    {
                        Console.WriteLine(" " + result);
                        Console.WriteLine(String.Format(columnFormat, "Drive", d.Name));
                        Console.WriteLine(String.Format(columnFormat, "Drive Type", d.DriveType));
                        Console.WriteLine(String.Format(columnFormat, "Volume Label", d.VolumeLabel));
                        Console.WriteLine(String.Format(columnFormat, "File System", d.DriveFormat));
                        Console.WriteLine(String.Format(columnFormat, "Total Available Space", SizeSuffix(d.TotalFreeSpace)));
                        Console.WriteLine(String.Format(columnFormat, "Total Drive Size", SizeSuffix(d.TotalSize)));
                        Console.WriteLine(String.Format(columnFormat, "Root Directory}", d.RootDirectory));
                        Console.WriteLine(" " + result);
                    }
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }


        private static void ramInformation()
        {
            const string columnFormat = "| {0,-35} | {1,-55} |";
            ManagementObjectSearcher memObj = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            string result = new String('-', 95);

            try
            {
                foreach (ManagementObject obj in memObj.Get())
                {
                    Console.WriteLine(" " + result);
                    Console.WriteLine(String.Format(columnFormat, "Description", obj["Description"]));
                    Console.WriteLine(String.Format(columnFormat, "Part Number", obj["PartNumber"]));
                    Console.WriteLine(String.Format(columnFormat, "Serial Number", obj["SerialNumber"]));
                    Console.WriteLine(String.Format(columnFormat, "Capacity", obj["Capacity"])); // Note: Create suffix system later
                    Console.WriteLine(String.Format(columnFormat, "Configured ClockSpeed", obj["ConfiguredClockSpeed"]));
                    Console.WriteLine(String.Format(columnFormat, "Configured Voltage", obj["ConfiguredVoltage"]));
                    Console.WriteLine(String.Format(columnFormat, "Max Voltage", obj["MaxVoltage"]));
                    Console.WriteLine(String.Format(columnFormat, "Min Voltage", obj["MinVoltage"]));
                    Console.WriteLine(String.Format(columnFormat, "Speed", obj["Speed"]));
                    Console.WriteLine(String.Format(columnFormat, "Memory Type", obj["MemoryType"]));
                    Console.WriteLine(String.Format(columnFormat, "SMBIOS Memory Type", obj["SMBIOSMemoryType"]));
                    Console.WriteLine(String.Format(columnFormat, "Version", obj["Version"]));
                    Console.WriteLine(" " + result);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }


        private static void NetworkInformation()
        {
            const string columnFormat = "| {0,-25} | {1,-25} |";
            NetworkInterface[] netInterface = NetworkInterface.GetAllNetworkInterfaces();
            string result = new String('-', 55);

            try
            {
                if (netInterface == null || netInterface.Length < 1)
                {
                    Console.WriteLine("  No network interfaces found.");
                }
                else
                {
                    foreach (NetworkInterface adapter in netInterface)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        Console.WriteLine(" " + adapter.Description);
                        Console.WriteLine(" " + result);
                        Console.WriteLine(String.Format(columnFormat, "Interface Type", adapter.NetworkInterfaceType));
                        Console.WriteLine(String.Format(columnFormat, "Physical Address", adapter.GetPhysicalAddress().ToString()));
                        Console.WriteLine(String.Format(columnFormat, "Operational Ttatus", adapter.OperationalStatus));

                        string internetProtocolVersions = "";

                        if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                        {
                            internetProtocolVersions = "IPv4";
                        }
                        if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                        {
                            if (internetProtocolVersions.Length > 0)
                            {
                                internetProtocolVersions += " / IPv6";
                            }
                        }

                        Console.WriteLine(String.Format(columnFormat, "DNS Enabled", properties.IsDnsEnabled));
                        Console.WriteLine(String.Format(columnFormat, "Dynamically DNS", properties.IsDynamicDnsEnabled));
                        Console.WriteLine(String.Format(columnFormat, "Receive Only", adapter.IsReceiveOnly));
                        Console.WriteLine(String.Format(columnFormat, "Multicast", adapter.SupportsMulticast));
                        Console.WriteLine(" " + result);
                        Console.WriteLine("\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }


        private static void SoundInformation()
        {
            Console.WriteLine("Coming Soon\n");
            // Note for later - Win32_SoundDevice
        }


        private static void MonitorInformation()
        {
            const string columnFormat = "| {0,-35} | {1,-55} |";
            ManagementObjectSearcher monitorObj = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
            string result = new String('-', 95);

            try
            {
                foreach (ManagementObject obj in monitorObj.Get())
                {
                    foreach (var screen in Screen.AllScreens)
                    {
                        Console.WriteLine(" " + result);
                        Console.WriteLine(String.Format(columnFormat, "Monito rManufacturer", obj["MonitorManufacturer"]));
                        Console.WriteLine(String.Format(columnFormat, "Name", obj["name"]));
                        Console.WriteLine(String.Format(columnFormat, "Device ID", obj["DeviceID"]));
                        Console.WriteLine(String.Format(columnFormat, "Primary Display", screen.Primary));
                        Console.WriteLine(String.Format(columnFormat, "Resolution", SystemInformation.VirtualScreen.Width + "x" + SystemInformation.VirtualScreen.Height));
                        Console.WriteLine(String.Format(columnFormat, "PixelsPerXLogicalInch", obj["PixelsPerXLogicalInch"]));
                        Console.WriteLine(String.Format(columnFormat, "PixelsPerYLogicalInch", obj["PixelsPerYLogicalInch"]));
                        Console.WriteLine(" " + result);
                        Console.WriteLine("\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: ", e);
            }
        }

        private static void usbInformation()
        {
            Console.WriteLine("Coming Soon\n");
            // Note for later - Win32_USBController
        }


        static string SizeSuffix(Int64 value)
        {
            String[] SizeSuffixes = new String[] { "B", "KB", "MB", "GB", "TB", "PB" };

            if (value < 0)
            {
                return "-" + SizeSuffix(-value);
            }
            if (value == 0)
            {
                return "0.0 bytes";
            }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }


        private static void Quit()
        {
            Environment.Exit(0);
        }
    }
}
