using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetMonitor
{
    public partial class Form1 : Form
    {
        private int DisconnectionCount = 0;
        private Timer actionTimer = new Timer();
        private bool isRunning = false;
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            actionTimer.Tick += actionTimer_Tick;
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherAddress.Enabled = rbOther.Checked;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;

                actionTimer.Stop();
                txtOutput.AppendText(string.Format("{0} {1}   \tMonitoring paused{2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToString("HH:mm:ss"), Environment.NewLine));
            }
            else
            {
                isRunning = true;
                actionTimer.Interval = (int)nFrequency.Value * 1000;
                actionTimer.Start();

                txtOutput.AppendText(string.Format("{0} {1}   \tMonitoring started{2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToString("HH:mm:ss"), Environment.NewLine));
                //tick immediately
                actionTimer_Tick(this, EventArgs.Empty);
            }

            gbAddress.Enabled = !isRunning;
            gbOptions.Enabled = !isRunning;
            btnAction.Text = string.Format("{0} Monitoring", isRunning ? "Pause" : "Resume");

            

            

        }

        private async void actionTimer_Tick(object sender, EventArgs e)
        {
            var p = new Ping();

            var fail = false;
            var address = GetAddress();

            try
            {
                var reply = await p.SendPingAsync(address);
                if (reply.Status != IPStatus.Success)
                {
                    fail = true;
                }
            }
            catch(Exception ex)
            {
                fail = true;
            }

            if (fail)
            {
                if (isConnected)
                {
                    isConnected = false;
                    DisconnectionCount++;
                    lblDisconnections.Text = string.Format("Disconnections: {0}", DisconnectionCount);

                    if (cbPlayOnDisconnect.Checked)
                    {
                        SoundPlayer simpleSound = new SoundPlayer("Disconnected.wav");
                        simpleSound.Play();
                    }

                }
                LogOutput(address, "NOT CONNECTED");
            }
            else
            {
                if (!isConnected && cbPlayOnReconnect.Checked)
                {
                    SoundPlayer simpleSound = new SoundPlayer("Connected.wav");
                    simpleSound.Play();
                }

                isConnected = true;
                LogOutput(address, "OK");
            } 
        }

        void PingCompleted(object sender, PingCompletedEventArgs e)
        {
          
        }

        private void LogOutput(string address, string status)
        {
            txtOutput.AppendText(string.Format("{0} {1}   \t{2} \t\t{3} {4}", DateTime.Now.ToShortDateString(), DateTime.Now.ToString("HH:mm:ss"), address, status,Environment.NewLine));
        }

        private string GetAddress()
        {
            if (rbGoogle.Checked)
            {
                return "www.google.com";
            }
            else if (rbDevDB.Checked)
            {
                return "dev1.atlasrfid.com";
            }
            else if (rbDevDBIP.Checked)
            {
                return "172.16.0.6";
            }
            else //(rbOther.Checked)
            {
                return txtOtherAddress.Text;
            }
            
        }

    }
}
