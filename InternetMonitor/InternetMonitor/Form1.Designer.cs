namespace InternetMonitor
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
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtOtherAddress = new System.Windows.Forms.TextBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbDevDBIP = new System.Windows.Forms.RadioButton();
            this.rbDevDB = new System.Windows.Forms.RadioButton();
            this.rbGoogle = new System.Windows.Forms.RadioButton();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbPlayOnReconnect = new System.Windows.Forms.CheckBox();
            this.cbPlayOnDisconnect = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nFrequency = new System.Windows.Forms.NumericUpDown();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblDisconnections = new System.Windows.Forms.Label();
            this.gbAddress.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.txtOtherAddress);
            this.gbAddress.Controls.Add(this.rbOther);
            this.gbAddress.Controls.Add(this.rbDevDBIP);
            this.gbAddress.Controls.Add(this.rbDevDB);
            this.gbAddress.Controls.Add(this.rbGoogle);
            this.gbAddress.Location = new System.Drawing.Point(33, 25);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(295, 216);
            this.gbAddress.TabIndex = 0;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Monitor Address";
            // 
            // txtOtherAddress
            // 
            this.txtOtherAddress.Enabled = false;
            this.txtOtherAddress.Location = new System.Drawing.Point(28, 168);
            this.txtOtherAddress.Name = "txtOtherAddress";
            this.txtOtherAddress.Size = new System.Drawing.Size(228, 20);
            this.txtOtherAddress.TabIndex = 4;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(28, 144);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(51, 17);
            this.rbOther.TabIndex = 3;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // rbDevDBIP
            // 
            this.rbDevDBIP.AutoSize = true;
            this.rbDevDBIP.Checked = true;
            this.rbDevDBIP.Location = new System.Drawing.Point(28, 106);
            this.rbDevDBIP.Name = "rbDevDBIP";
            this.rbDevDBIP.Size = new System.Drawing.Size(76, 17);
            this.rbDevDBIP.TabIndex = 2;
            this.rbDevDBIP.TabStop = true;
            this.rbDevDBIP.Text = "172.16.0.6";
            this.rbDevDBIP.UseVisualStyleBackColor = true;
            // 
            // rbDevDB
            // 
            this.rbDevDB.AutoSize = true;
            this.rbDevDB.Location = new System.Drawing.Point(28, 68);
            this.rbDevDB.Name = "rbDevDB";
            this.rbDevDB.Size = new System.Drawing.Size(111, 17);
            this.rbDevDB.TabIndex = 1;
            this.rbDevDB.Text = "dev1.atlasrfid.com";
            this.rbDevDB.UseVisualStyleBackColor = true;
            // 
            // rbGoogle
            // 
            this.rbGoogle.AutoSize = true;
            this.rbGoogle.Location = new System.Drawing.Point(28, 30);
            this.rbGoogle.Name = "rbGoogle";
            this.rbGoogle.Size = new System.Drawing.Size(107, 17);
            this.rbGoogle.TabIndex = 0;
            this.rbGoogle.Text = "www.google.com";
            this.rbGoogle.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbPlayOnReconnect);
            this.gbOptions.Controls.Add(this.cbPlayOnDisconnect);
            this.gbOptions.Controls.Add(this.label2);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.nFrequency);
            this.gbOptions.Location = new System.Drawing.Point(33, 261);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(294, 151);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // cbPlayOnReconnect
            // 
            this.cbPlayOnReconnect.AutoSize = true;
            this.cbPlayOnReconnect.Checked = true;
            this.cbPlayOnReconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPlayOnReconnect.Location = new System.Drawing.Point(28, 101);
            this.cbPlayOnReconnect.Name = "cbPlayOnReconnect";
            this.cbPlayOnReconnect.Size = new System.Drawing.Size(144, 17);
            this.cbPlayOnReconnect.TabIndex = 5;
            this.cbPlayOnReconnect.Text = "Play sound on reconnect";
            this.cbPlayOnReconnect.UseVisualStyleBackColor = true;
            // 
            // cbPlayOnDisconnect
            // 
            this.cbPlayOnDisconnect.AutoSize = true;
            this.cbPlayOnDisconnect.Checked = true;
            this.cbPlayOnDisconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPlayOnDisconnect.Location = new System.Drawing.Point(28, 69);
            this.cbPlayOnDisconnect.Name = "cbPlayOnDisconnect";
            this.cbPlayOnDisconnect.Size = new System.Drawing.Size(148, 17);
            this.cbPlayOnDisconnect.TabIndex = 4;
            this.cbPlayOnDisconnect.Text = "Play sound on disconnect";
            this.cbPlayOnDisconnect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frequency";
            // 
            // nFrequency
            // 
            this.nFrequency.Location = new System.Drawing.Point(88, 26);
            this.nFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFrequency.Name = "nFrequency";
            this.nFrequency.Size = new System.Drawing.Size(59, 20);
            this.nFrequency.TabIndex = 1;
            this.nFrequency.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(33, 428);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(294, 23);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "Start Monitoring";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(357, 25);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(406, 466);
            this.txtOutput.TabIndex = 3;
            // 
            // lblDisconnections
            // 
            this.lblDisconnections.AutoSize = true;
            this.lblDisconnections.Location = new System.Drawing.Point(26, 478);
            this.lblDisconnections.Name = "lblDisconnections";
            this.lblDisconnections.Size = new System.Drawing.Size(92, 13);
            this.lblDisconnections.TabIndex = 4;
            this.lblDisconnections.Text = "Disconnections: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 526);
            this.Controls.Add(this.lblDisconnections);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Monitor";
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox txtOtherAddress;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbDevDBIP;
        private System.Windows.Forms.RadioButton rbDevDB;
        private System.Windows.Forms.RadioButton rbGoogle;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox cbPlayOnReconnect;
        private System.Windows.Forms.CheckBox cbPlayOnDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nFrequency;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblDisconnections;
    }
}

