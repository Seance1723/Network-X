using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace Network_X
{
    public partial class networkX : Form
    {
        public networkX()
        {
            InitializeComponent();
        }

        private void networkX_Load(object sender, EventArgs e)
        {
            string ipAddress = GetIPAddress();
            string defaultGateway = GetDefaultGateway();
            string dnsServers = GetDNSServers();
            if (!string.IsNullOrEmpty(ipAddress))
            {
                sysIP.Text = ipAddress;
            }
            else
            {
                sysIP.Text = "No IP address found.";
            }
            if (!string.IsNullOrEmpty(defaultGateway))
            {
                sysGateway.Text = defaultGateway;
            }
            else
            {
                sysGateway.Text = "No default gateway found.";
            }
            if (!string.IsNullOrEmpty(dnsServers))
            {
                sysDNSServers.Text = dnsServers;
            }
            else
            {
                sysDNSServers.Text = "No DNS servers found.";
            }
        }

        private string GetIPAddress()
        {
            var card = NetworkInterface.GetAllNetworkInterfaces()
            .Where(n => n.OperationalStatus == OperationalStatus.Up)
            .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .SelectMany(n => n.GetIPProperties()?.UnicastAddresses)
            .Where(a => a.Address.AddressFamily == AddressFamily.InterNetwork)
            .FirstOrDefault();
            return card?.Address.ToString();
        }

        private string GetDefaultGateway()
        {
            var card = NetworkInterface.GetAllNetworkInterfaces()
            .Where(n => n.OperationalStatus == OperationalStatus.Up)
            .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
            .FirstOrDefault(g => g?.Address != null);
            return card?.Address.ToString();
        }

        private string GetDNSServers()
        {
            var card = NetworkInterface.GetAllNetworkInterfaces()
            .Where(n => n.OperationalStatus == OperationalStatus.Up)
            .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .SelectMany(n => n.GetIPProperties()?.DnsAddresses)
            .FirstOrDefault();
            return string.Join(", ", card);
        }

        private void checkNIC_Click(object sender, EventArgs e)
        {
            string ipAddress = "127.0.0.1";
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(ipAddress, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                netXResult.Text = "Ping to " + ipAddress + " was successful." + " RoundTrip time: " + reply.RoundtripTime + "ms";
            }
            else
            {
                netXResult.Text = "Ping to " + ipAddress + " failed. Status: " + reply.Status;
            }
        }

        private void networkStatus_Click(object sender, EventArgs e)
        {
            string hostname = "google.com";
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(hostname, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                netXResult.Text = "Ping to " + hostname + " was successful." + " RoundTrip time: " + reply.RoundtripTime + "ms";
            }
            else
            {
                netXResult.Text = "Ping to " + hostname + " failed. Status: " + reply.Status;
            }
        }

        private void flushDNS_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c ipconfig /flushdns");

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                MessageBox.Show("DNS cache flushed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error flushing DNS cache: " + ex.Message);
            }
        }

        private void releaseRenewIP_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo releaseProcStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c ipconfig /release");

                releaseProcStartInfo.RedirectStandardOutput = true;
                releaseProcStartInfo.UseShellExecute = false;
                releaseProcStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process releaseProc = new System.Diagnostics.Process();
                releaseProc.StartInfo = releaseProcStartInfo;
                releaseProc.Start();
                string releaseResult = releaseProc.StandardOutput.ReadToEnd();

                System.Diagnostics.ProcessStartInfo renewProcStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c ipconfig /renew");

                renewProcStartInfo.RedirectStandardOutput = true;
                renewProcStartInfo.UseShellExecute = false;
                renewProcStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process renewProc = new System.Diagnostics.Process();
                renewProc.StartInfo = renewProcStartInfo;
                renewProc.Start();
                string renewResult = renewProc.StandardOutput.ReadToEnd();

                MessageBox.Show("IP address released and renewed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error releasing and renewing IP address: " + ex.Message);
            }
        }

        private void checkBandwidth_Click(object sender, EventArgs e)
        {
            //URL of file to download
            string downloadUrl = "http://speedtest.ftp.otenet.gr/files/test100k.db";
            //URL of file to upload
            string uploadUrl = "https://file.io/";

            //Check download speed
            using (HttpClient downloadClient = new HttpClient())
            {
                Stopwatch downloadStopwatch = new Stopwatch();
                downloadStopwatch.Start();
                byte[] downloadData = await downloadClient.GetByteArrayAsync(downloadUrl);
                downloadStopwatch.Stop();
                double downloadBytesPerSecond = downloadData.Length / downloadStopwatch.Elapsed.TotalSeconds;
                double downloadKiloBytesPerSecond = downloadBytesPerSecond / 1024;
                double downloadMegaBytesPerSecond = downloadKiloBytesPerSecond / 1024;
                downloadSpeed.Text = downloadMegaBytesPerSecond.ToString("0.00") + " MB/s";
            }

            //Check upload speed
            using (HttpClient uploadClient = new HttpClient())
            {
                Stopwatch uploadStopwatch = new Stopwatch();
                uploadStopwatch.Start();
                byte[] uploadData = Encoding.ASCII.GetBytes("Test file");
                using (ByteArrayContent byteContent = new ByteArrayContent(uploadData))
                {
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    await uploadClient.PostAsync(uploadUrl, byteContent);
                }
                uploadStopwatch.Stop();
                double uploadBytesPerSecond = uploadData.Length / uploadStopwatch.Elapsed.TotalSeconds;
                double uploadKiloBytesPerSecond = uploadBytesPerSecond / 1024;
                double uploadMegaBytesPerSecond = uploadKiloBytesPerSecond / 1024;
                uploadSpeed.Text = uploadMegaBytesPerSecond.ToString("0.00") + " MB/s";
            }
        }
    }
}