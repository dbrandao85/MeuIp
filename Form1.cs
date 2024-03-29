using System.Net.NetworkInformation;

namespace MeuIp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            try
            {
                List<NetworkInterface> interfaces = NetworkInterface.GetAllNetworkInterfaces().Where(i =>
                    i.OperationalStatus == OperationalStatus.Up &&
                    i.NetworkInterfaceType != NetworkInterfaceType.Loopback).ToList();

                txtBoxResult.Text = "";

                foreach (var networkInterface in interfaces)
                {
                    foreach (var ip in networkInterface.GetIPProperties().UnicastAddresses.Where(i =>
                        i.Address.AddressFamily is System.Net.Sockets.AddressFamily.InterNetwork))
                    {
                        txtBoxResult.Text += $"{networkInterface.Name}: {ip.Address}\r";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
