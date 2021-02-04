using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeItSo_Click(object sender, EventArgs e)
        {
            var input = txtINPUT.Text.Trim();

            var sa = input.Split('\r');

            if (input == string.Empty)
            {
                MessageBox.Show("THERE AINT NO INPUT");
                return;
            }

            var findStr = txtSearchStr.Text;

            if (chkTabSearch.Checked)
            {
                findStr += "\t";
            }

            if (chkCRLFSearch.Checked)
            {
                findStr += "\r\n";
            }

            if (findStr == "")
            {
                MessageBox.Show("THERE AINT NO SEARCH CRITERIA");
                return;
            }

            var replaceStr = txtReplaceStr.Text;

            if (chkTABReplace.Checked)
            {
                replaceStr += "\t";
            }

            if (chkCRLFReplace.Checked)
            {
                replaceStr += "\r\n";
            }

            if (cbNothing.Checked)
            {
                replaceStr = "";
            }
            else if (replaceStr == "")
            {
                MessageBox.Show("THERE AINT NO REPLACE CRITERIA");
                return;
            }

            txtOUTPUT.Text = input.Replace(findStr, replaceStr);


            
        }

        private void txtOUTPUT_TextChanged(object sender, EventArgs e)
        {
            btnCopy.Enabled = txtOUTPUT.Text != "";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOUTPUT.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOUTPUT.Clear();

            var sa = txtINPUT.Text.Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var str in sa.ToList())
            {                
                txtOUTPUT.Text += str.Substring(0, str.IndexOf("(")) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOUTPUT.Clear();

            var sa = txtINPUT.Text.Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var str in sa.ToList().Distinct())
            {
                txtOUTPUT.Text += str + Environment.NewLine;
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            txtINPUT.Text = txtOUTPUT.Text;
        }
    }
}
