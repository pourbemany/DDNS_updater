using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace noip_updater
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "http://dynupdate.no-ip.com/nic/update?hostname=" + ddns_add.Text + "&myip=" + ip.Text;
            //MessageBox.Show(str);

            string html = string.Empty;
            string url = str;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Basic "+ Base64Encode(user.Text+":"+pass.Text));
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            status.Text = html;
            last_update.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Shown(object sender, EventArgs e)
        {
            get_ip();
            
            timer1.Interval = 60000;
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            get_ip();
            button2.PerformClick();
        }

        private void get_ip()
        {
            String address = "";
            try
            {
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    address = stream.ReadToEnd();
                }

                int first = address.IndexOf("Address: ") + 9;
                int last = address.LastIndexOf("</body>");
                address = address.Substring(first, last - first);
                ip.Text = address;
            }
            catch (Exception ex)
            {
                ip.Text = "not found";
                throw new ApplicationException("Error:", ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = Send_via_third_party_add();
            //MessageBox.Show(result);
            status.Text = result;
            last_update.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
        }

        private string Send_via_third_party_add()
        {
            string str = third_pa.Text + "?hostname=" + ddns_add.Text + "&myip=" + ip.Text + "&user=" + user.Text + "&pass=" + pass.Text;
            //messagebox.show(str);

            string html = string.Empty;
            string url = str;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }

        private void interval_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void interval_KeyUp(object sender, KeyEventArgs e)
        {
            if (interval.Text != "")
            {
                timer1.Stop();
                timer1.Interval = 1000 * Int16.Parse(interval.Text);
                timer1.Start();
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
