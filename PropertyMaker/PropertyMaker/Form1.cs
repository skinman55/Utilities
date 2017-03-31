using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeItSo_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("WHY U NO ENTER ANY INPUT?");
                return;
            }

            var dataType = GetDataType();

            if (dataType == "")
            {
                MessageBox.Show("WHY U NO SELECT A DATATYPE?");
                return;
            }

            txtResult.Clear();

            var properties = txtInput.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in properties)
            {
                GenerateProperty(p.Trim(), dataType);
            }

            

        }

        private string GetDataType()
        {
            if (rbGuid.Checked)
            {
                return "Guid";
            }
            if (rbGuidN.Checked)
            {
                return "Guid?";
            }
            if (rbInt.Checked)
            {
                return "int";
            }
            if (rbIntN.Checked)
            {
                return "int?";
            }
            if (rbDecimal.Checked)
            {
                return "decimal";
            }
            if (rbDecimalN.Checked)
            {
                return "decimal?";
            }
            if (rbBool.Checked)
            {
                return "bool";
            }
            if (rbBoolN.Checked)
            {
                return "bool?";
            }
            if (rbString.Checked)
            {
                return "string";
            }
            if (rbRelayCommand.Checked)
            {
                return "RelayCommand";
            }
            if (rbVisibility.Checked)
            {
                return "Visibility";
            }
            if (rbOther.Checked)
            {
                return txtType.Text;
            }

            return "";
        }

        private void GenerateProperty(string name, string dataType)
        {
            if(cbDropDatabase.Checked)
            {
                GenerateDropDBScript(name);
            }
            else if (dataType == "RelayCommand")
            {
                GenerateRelayCommand(name);
            }
            else if (cbReadOnly.Checked)
            {
                var sb = new StringBuilder();
                sb.AppendFormat("public {0} {1}{2}", dataType, name.UpperFirstLetter(), Environment.NewLine);
                sb.AppendLine("{");
                sb.AppendFormat("   get {2}return x; {3}{1}", name.LowerFirstLetter(), Environment.NewLine, "{", "}");
                sb.AppendLine("}");
                sb.AppendLine("");

                txtResult.Text += sb.ToString();
            }
            else
            {

                var sb = new StringBuilder();
                sb.AppendFormat("private {0} {1};{2}", dataType, name.LowerFirstLetter(), Environment.NewLine);
                
                if (cbMapProperty.Checked)
                {
                    sb.AppendFormat("[MapProperty(\"{0}\")]{1}", name.UpperFirstLetter(), Environment.NewLine);
                }

                if (cbMapReference.Checked)
                {
                    sb.AppendFormat("[MapReferences(\"{0}\")]{1}", name.UpperFirstLetter() + "ID", Environment.NewLine);
                }
                
                sb.AppendFormat("public {0}{1} {2}{3}", cbVirtual.Checked ? "virtual " : "", dataType, name.UpperFirstLetter(), Environment.NewLine);
                sb.AppendLine("{");
                sb.AppendFormat("   get {2}return {0}; {3}{1}", name.LowerFirstLetter(), Environment.NewLine, "{", "}");

                if (cbIncludePropertyInRaise.Checked)
                    sb.AppendFormat("   set {3} {0} = value; RaisePropertyChanged(\"{1}\"); {4}{2}", name.LowerFirstLetter(), name.UpperFirstLetter(), Environment.NewLine, "{", "}");
                else
                    sb.AppendFormat("   set {3} {0} = value; RaisePropertyChanged({1}); {4}{2}", name.LowerFirstLetter(), "", Environment.NewLine, "{", "}");

                sb.AppendLine("}");
                sb.AppendLine("");

                txtResult.Text += sb.ToString();
            }

        }

        private void GenerateDropDBScript(string name)
        {
           
            var sb = new StringBuilder();
            sb.AppendFormat("EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'{0}'{1}", name, Environment.NewLine);
            sb.AppendLine("GO");
            sb.AppendLine("USE [master]");
            sb.AppendLine("GO");
            sb.AppendFormat("DROP DATABASE [{0}]{1}", name, Environment.NewLine);
            sb.AppendLine("GO");
            sb.AppendLine("");

            txtResult.Text += sb.ToString();
        }

        private void GenerateRelayCommand(string name)
        {
            var dataType = "RelayCommand";

            var methodName = name.UpperFirstLetter().Replace("Command","");

            var sb = new StringBuilder();
            sb.AppendFormat("private {0} {1};{2}", dataType, name.LowerFirstLetter(), Environment.NewLine);
            sb.AppendFormat("public {0} {1}{2}", dataType, name.UpperFirstLetter(), Environment.NewLine);
            sb.AppendLine("{");
            sb.AppendLine("   get ");
            sb.AppendLine("     {");
            sb.AppendFormat("       if({0} == null){1}", name.LowerFirstLetter(), Environment.NewLine);
            sb.AppendFormat("           {0} = new RelayCommand({1}, {2});{3}", name.LowerFirstLetter(), methodName, "CanExecute" + methodName + "Command", Environment.NewLine);
            sb.AppendFormat("       return {0};{1}", name.LowerFirstLetter(), Environment.NewLine);
            sb.AppendLine("     }");
            sb.AppendLine("}");
            sb.AppendLine("");

            txtResult.Text += sb.ToString();
        }

        
        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            txtType.Enabled = rbOther.Checked;
        }

        private void btnCopyResults_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void cbMapProperty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMapProperty.Checked)
            {
                cbVirtual.Checked = true;
                cbMapReference.Checked = false;
            }
        }

        private void cbMapReference_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMapReference.Checked)
            {
                cbVirtual.Checked = true;
                cbMapProperty.Checked = false;
            }
        }

        
       



    }


    public static class StringExtensions
    {

        public static string LowerFirstLetter(this string input)
        {
            if (String.IsNullOrEmpty(input))
                return input;

            return input.First().ToString().ToLower() + String.Join("", input.Skip(1));

        }

        public static string UpperFirstLetter(this string input)
        {
            if (String.IsNullOrEmpty(input))
                return input;

            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }
    }
}
