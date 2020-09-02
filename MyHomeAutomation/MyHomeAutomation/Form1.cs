using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (checkInternet())
            {
                if (bunifuiOSSwitch1.Value == true)
            {
                lightOn();
                pictureBox3.Show();
                pictureBox5.Hide();
            }
            else {
                lightOff();
                pictureBox3.Hide();
                pictureBox5.Show();
            }
            }
        }

        private void lightOn() {
            string url = "https://188.166.206.43/20MOrdfADZ3yHxb-tyDRzxdndaZ8j2XT/update/D16?value=1";
            WebResponse response = null;
            string data = string.Empty;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new
                RemoteCertificateValidationCallback
                (
                    delegate { return true; }
                );

                WebRequest request = WebRequest.Create(url);
                response = request.GetResponse();
            }
            catch (WebException ee)
            {
                MessageBox.Show("No Internet Connection");
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Internet Connection");
            }
            finally
            {
                if (response != null) response.Close();
            }
        }

        private void lightOff()
        {
            string url = "https://188.166.206.43/20MOrdfADZ3yHxb-tyDRzxdndaZ8j2XT/update/D16?value=0";
            WebResponse response = null;
            string data = string.Empty;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new
                RemoteCertificateValidationCallback
                (
                    delegate { return true; }
                );

                WebRequest request = WebRequest.Create(url);
                response = request.GetResponse();
            }
            catch (WebException ee)
            {
                MessageBox.Show("No Internet Connection");
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Internet Connection");
            }
            finally
            {
                if (response != null) response.Close();
            }
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (checkInternet())
            {
                if (bunifuiOSSwitch2.Value == true)
            {
                fanOn();
                pictureBox2.Show();
                pictureBox4.Hide();
            }
            else
            {
                fanOff();
                pictureBox2.Hide();
                pictureBox4.Show();
            }
            }
        }

        private void fanOn()
        {
            string url = "https://188.166.206.43/20MOrdfADZ3yHxb-tyDRzxdndaZ8j2XT/update/D0?value=1";
            WebResponse response = null;
            string data = string.Empty;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new
                RemoteCertificateValidationCallback
                (
                    delegate { return true; }
                );

                WebRequest request = WebRequest.Create(url);
                response = request.GetResponse();
            }
            catch (WebException ee)
            {
                MessageBox.Show("No Internet Connection");
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Internet Connection");
            }
            finally
            {
                if (response != null) response.Close();
            }
        }

        private void fanOff()
        {
            string url = "https://188.166.206.43/20MOrdfADZ3yHxb-tyDRzxdndaZ8j2XT/update/D0?value=0";
            WebResponse response = null;
            string data = string.Empty;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new
                RemoteCertificateValidationCallback
                (
                    delegate { return true; }
                );

                WebRequest request = WebRequest.Create(url);
                response = request.GetResponse();
            }
            catch (WebException ee)
            {
                MessageBox.Show("No Internet Connection");
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Internet Connection");
            }
            finally
            {
                if (response != null) response.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkInternet();
        }

        private Boolean checkInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com"))

                label5.ForeColor = Color.Green;
                label5.Text = "Online";
                return true;
            }
            catch
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Offline";

                pictureBox2.Hide();
                pictureBox4.Show();

                pictureBox3.Hide();
                pictureBox5.Show();

                //bunifuiOSSwitch1.Value = false;
                //bunifuiOSSwitch2.Value = false;
            }
            return false;
        }
    }
}
