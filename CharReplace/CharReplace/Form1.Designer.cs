namespace CharReplace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtINPUT = new System.Windows.Forms.TextBox();
            this.txtSearchStr = new System.Windows.Forms.TextBox();
            this.txtReplaceStr = new System.Windows.Forms.TextBox();
            this.chkTabSearch = new System.Windows.Forms.CheckBox();
            this.chkCRLFSearch = new System.Windows.Forms.CheckBox();
            this.chkCRLFReplace = new System.Windows.Forms.CheckBox();
            this.chkTABReplace = new System.Windows.Forms.CheckBox();
            this.btnMakeItSo = new System.Windows.Forms.Button();
            this.txtOUTPUT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cbNothing = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtINPUT
            // 
            this.txtINPUT.Location = new System.Drawing.Point(23, 40);
            this.txtINPUT.Multiline = true;
            this.txtINPUT.Name = "txtINPUT";
            this.txtINPUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtINPUT.Size = new System.Drawing.Size(350, 422);
            this.txtINPUT.TabIndex = 0;
            this.txtINPUT.WordWrap = false;
            // 
            // txtSearchStr
            // 
            this.txtSearchStr.Location = new System.Drawing.Point(394, 75);
            this.txtSearchStr.Name = "txtSearchStr";
            this.txtSearchStr.Size = new System.Drawing.Size(100, 20);
            this.txtSearchStr.TabIndex = 2;
            // 
            // txtReplaceStr
            // 
            this.txtReplaceStr.Location = new System.Drawing.Point(394, 214);
            this.txtReplaceStr.Name = "txtReplaceStr";
            this.txtReplaceStr.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceStr.TabIndex = 3;
            // 
            // chkTabSearch
            // 
            this.chkTabSearch.AutoSize = true;
            this.chkTabSearch.Location = new System.Drawing.Point(394, 101);
            this.chkTabSearch.Name = "chkTabSearch";
            this.chkTabSearch.Size = new System.Drawing.Size(47, 17);
            this.chkTabSearch.TabIndex = 4;
            this.chkTabSearch.Text = "TAB";
            this.chkTabSearch.UseVisualStyleBackColor = true;
            // 
            // chkCRLFSearch
            // 
            this.chkCRLFSearch.AutoSize = true;
            this.chkCRLFSearch.Location = new System.Drawing.Point(394, 124);
            this.chkCRLFSearch.Name = "chkCRLFSearch";
            this.chkCRLFSearch.Size = new System.Drawing.Size(53, 17);
            this.chkCRLFSearch.TabIndex = 5;
            this.chkCRLFSearch.Text = "CRLF";
            this.chkCRLFSearch.UseVisualStyleBackColor = true;
            // 
            // chkCRLFReplace
            // 
            this.chkCRLFReplace.AutoSize = true;
            this.chkCRLFReplace.Location = new System.Drawing.Point(394, 263);
            this.chkCRLFReplace.Name = "chkCRLFReplace";
            this.chkCRLFReplace.Size = new System.Drawing.Size(53, 17);
            this.chkCRLFReplace.TabIndex = 7;
            this.chkCRLFReplace.Text = "CRLF";
            this.chkCRLFReplace.UseVisualStyleBackColor = true;
            // 
            // chkTABReplace
            // 
            this.chkTABReplace.AutoSize = true;
            this.chkTABReplace.Location = new System.Drawing.Point(394, 240);
            this.chkTABReplace.Name = "chkTABReplace";
            this.chkTABReplace.Size = new System.Drawing.Size(47, 17);
            this.chkTABReplace.TabIndex = 6;
            this.chkTABReplace.Text = "TAB";
            this.chkTABReplace.UseVisualStyleBackColor = true;
            // 
            // btnMakeItSo
            // 
            this.btnMakeItSo.Location = new System.Drawing.Point(394, 309);
            this.btnMakeItSo.Name = "btnMakeItSo";
            this.btnMakeItSo.Size = new System.Drawing.Size(75, 23);
            this.btnMakeItSo.TabIndex = 8;
            this.btnMakeItSo.Text = "Make it So";
            this.btnMakeItSo.UseVisualStyleBackColor = true;
            this.btnMakeItSo.Click += new System.EventHandler(this.btnMakeItSo_Click);
            // 
            // txtOUTPUT
            // 
            this.txtOUTPUT.Location = new System.Drawing.Point(523, 40);
            this.txtOUTPUT.Multiline = true;
            this.txtOUTPUT.Name = "txtOUTPUT";
            this.txtOUTPUT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOUTPUT.Size = new System.Drawing.Size(350, 422);
            this.txtOUTPUT.TabIndex = 9;
            this.txtOUTPUT.WordWrap = false;
            this.txtOUTPUT.TextChanged += new System.EventHandler(this.txtOUTPUT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "OUTPUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search for:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Replace with:";
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(394, 439);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(123, 23);
            this.btnCopy.TabIndex = 14;
            this.btnCopy.Text = "Results to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cbNothing
            // 
            this.cbNothing.AutoSize = true;
            this.cbNothing.Location = new System.Drawing.Point(394, 286);
            this.cbNothing.Name = "cbNothing";
            this.cbNothing.Size = new System.Drawing.Size(63, 17);
            this.cbNothing.TabIndex = 15;
            this.cbNothing.Text = "Nothing";
            this.cbNothing.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Parse Filename Strings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Find Distincts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNothing);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOUTPUT);
            this.Controls.Add(this.btnMakeItSo);
            this.Controls.Add(this.chkCRLFReplace);
            this.Controls.Add(this.chkTABReplace);
            this.Controls.Add(this.chkCRLFSearch);
            this.Controls.Add(this.chkTabSearch);
            this.Controls.Add(this.txtReplaceStr);
            this.Controls.Add(this.txtSearchStr);
            this.Controls.Add(this.txtINPUT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtINPUT;
        private System.Windows.Forms.TextBox txtSearchStr;
        private System.Windows.Forms.TextBox txtReplaceStr;
        private System.Windows.Forms.CheckBox chkTabSearch;
        internal System.Windows.Forms.CheckBox chkCRLFSearch;
        private System.Windows.Forms.CheckBox chkCRLFReplace;
        private System.Windows.Forms.CheckBox chkTABReplace;
        private System.Windows.Forms.Button btnMakeItSo;
        private System.Windows.Forms.TextBox txtOUTPUT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbNothing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

