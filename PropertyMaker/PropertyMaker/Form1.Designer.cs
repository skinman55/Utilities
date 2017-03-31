namespace PropertyMaker
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVisibility = new System.Windows.Forms.RadioButton();
            this.rbRelayCommand = new System.Windows.Forms.RadioButton();
            this.txtType = new System.Windows.Forms.TextBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbDecimalN = new System.Windows.Forms.RadioButton();
            this.rbDecimal = new System.Windows.Forms.RadioButton();
            this.rbString = new System.Windows.Forms.RadioButton();
            this.rbBoolN = new System.Windows.Forms.RadioButton();
            this.rbBool = new System.Windows.Forms.RadioButton();
            this.rbIntN = new System.Windows.Forms.RadioButton();
            this.rbInt = new System.Windows.Forms.RadioButton();
            this.rbGuidN = new System.Windows.Forms.RadioButton();
            this.rbGuid = new System.Windows.Forms.RadioButton();
            this.btnMakeItSo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIncludePropertyInRaise = new System.Windows.Forms.CheckBox();
            this.btnCopyResults = new System.Windows.Forms.Button();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.cbVirtual = new System.Windows.Forms.CheckBox();
            this.cbMapProperty = new System.Windows.Forms.CheckBox();
            this.cbMapReference = new System.Windows.Forms.CheckBox();
            this.cbDropDatabase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(10, 28);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(270, 555);
            this.txtInput.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(567, 28);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(270, 555);
            this.txtResult.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(13, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(104, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Properties To Create";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVisibility);
            this.groupBox1.Controls.Add(this.rbRelayCommand);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbDecimalN);
            this.groupBox1.Controls.Add(this.rbDecimal);
            this.groupBox1.Controls.Add(this.rbString);
            this.groupBox1.Controls.Add(this.rbBoolN);
            this.groupBox1.Controls.Add(this.rbBool);
            this.groupBox1.Controls.Add(this.rbIntN);
            this.groupBox1.Controls.Add(this.rbInt);
            this.groupBox1.Controls.Add(this.rbGuidN);
            this.groupBox1.Controls.Add(this.rbGuid);
            this.groupBox1.Location = new System.Drawing.Point(286, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 291);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Type";
            // 
            // rbVisibility
            // 
            this.rbVisibility.AutoSize = true;
            this.rbVisibility.Location = new System.Drawing.Point(18, 235);
            this.rbVisibility.Name = "rbVisibility";
            this.rbVisibility.Size = new System.Drawing.Size(61, 17);
            this.rbVisibility.TabIndex = 12;
            this.rbVisibility.TabStop = true;
            this.rbVisibility.Text = "Visibility";
            this.rbVisibility.UseVisualStyleBackColor = true;
            // 
            // rbRelayCommand
            // 
            this.rbRelayCommand.AutoSize = true;
            this.rbRelayCommand.Location = new System.Drawing.Point(18, 212);
            this.rbRelayCommand.Name = "rbRelayCommand";
            this.rbRelayCommand.Size = new System.Drawing.Size(99, 17);
            this.rbRelayCommand.TabIndex = 11;
            this.rbRelayCommand.TabStop = true;
            this.rbRelayCommand.Text = "RelayCommand";
            this.rbRelayCommand.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(38, 258);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(184, 20);
            this.txtType.TabIndex = 10;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(18, 261);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(14, 13);
            this.rbOther.TabIndex = 9;
            this.rbOther.TabStop = true;
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // rbDecimalN
            // 
            this.rbDecimalN.AutoSize = true;
            this.rbDecimalN.Location = new System.Drawing.Point(18, 126);
            this.rbDecimalN.Name = "rbDecimalN";
            this.rbDecimalN.Size = new System.Drawing.Size(67, 17);
            this.rbDecimalN.TabIndex = 8;
            this.rbDecimalN.TabStop = true;
            this.rbDecimalN.Text = "decimal?";
            this.rbDecimalN.UseVisualStyleBackColor = true;
            // 
            // rbDecimal
            // 
            this.rbDecimal.AutoSize = true;
            this.rbDecimal.Location = new System.Drawing.Point(18, 104);
            this.rbDecimal.Name = "rbDecimal";
            this.rbDecimal.Size = new System.Drawing.Size(61, 17);
            this.rbDecimal.TabIndex = 7;
            this.rbDecimal.TabStop = true;
            this.rbDecimal.Text = "decimal";
            this.rbDecimal.UseVisualStyleBackColor = true;
            // 
            // rbString
            // 
            this.rbString.AutoSize = true;
            this.rbString.Location = new System.Drawing.Point(18, 192);
            this.rbString.Name = "rbString";
            this.rbString.Size = new System.Drawing.Size(50, 17);
            this.rbString.TabIndex = 6;
            this.rbString.TabStop = true;
            this.rbString.Text = "string";
            this.rbString.UseVisualStyleBackColor = true;
            // 
            // rbBoolN
            // 
            this.rbBoolN.AutoSize = true;
            this.rbBoolN.Location = new System.Drawing.Point(18, 170);
            this.rbBoolN.Name = "rbBoolN";
            this.rbBoolN.Size = new System.Drawing.Size(51, 17);
            this.rbBoolN.TabIndex = 5;
            this.rbBoolN.TabStop = true;
            this.rbBoolN.Text = "bool?";
            this.rbBoolN.UseVisualStyleBackColor = true;
            // 
            // rbBool
            // 
            this.rbBool.AutoSize = true;
            this.rbBool.Location = new System.Drawing.Point(18, 148);
            this.rbBool.Name = "rbBool";
            this.rbBool.Size = new System.Drawing.Size(45, 17);
            this.rbBool.TabIndex = 4;
            this.rbBool.TabStop = true;
            this.rbBool.Text = "bool";
            this.rbBool.UseVisualStyleBackColor = true;
            // 
            // rbIntN
            // 
            this.rbIntN.AutoSize = true;
            this.rbIntN.Location = new System.Drawing.Point(18, 82);
            this.rbIntN.Name = "rbIntN";
            this.rbIntN.Size = new System.Drawing.Size(42, 17);
            this.rbIntN.TabIndex = 3;
            this.rbIntN.TabStop = true;
            this.rbIntN.Text = "int?";
            this.rbIntN.UseVisualStyleBackColor = true;
            // 
            // rbInt
            // 
            this.rbInt.AutoSize = true;
            this.rbInt.Location = new System.Drawing.Point(18, 60);
            this.rbInt.Name = "rbInt";
            this.rbInt.Size = new System.Drawing.Size(36, 17);
            this.rbInt.TabIndex = 2;
            this.rbInt.TabStop = true;
            this.rbInt.Text = "int";
            this.rbInt.UseVisualStyleBackColor = true;
            // 
            // rbGuidN
            // 
            this.rbGuidN.AutoSize = true;
            this.rbGuidN.Location = new System.Drawing.Point(18, 38);
            this.rbGuidN.Name = "rbGuidN";
            this.rbGuidN.Size = new System.Drawing.Size(53, 17);
            this.rbGuidN.TabIndex = 1;
            this.rbGuidN.TabStop = true;
            this.rbGuidN.Text = "Guid?";
            this.rbGuidN.UseVisualStyleBackColor = true;
            // 
            // rbGuid
            // 
            this.rbGuid.AutoSize = true;
            this.rbGuid.Location = new System.Drawing.Point(18, 16);
            this.rbGuid.Name = "rbGuid";
            this.rbGuid.Size = new System.Drawing.Size(47, 17);
            this.rbGuid.TabIndex = 0;
            this.rbGuid.TabStop = true;
            this.rbGuid.Text = "Guid";
            this.rbGuid.UseVisualStyleBackColor = true;
            // 
            // btnMakeItSo
            // 
            this.btnMakeItSo.Location = new System.Drawing.Point(286, 530);
            this.btnMakeItSo.Name = "btnMakeItSo";
            this.btnMakeItSo.Size = new System.Drawing.Size(263, 23);
            this.btnMakeItSo.TabIndex = 5;
            this.btnMakeItSo.Text = "Make it so --->";
            this.btnMakeItSo.UseVisualStyleBackColor = true;
            this.btnMakeItSo.Click += new System.EventHandler(this.btnMakeItSo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "┻━┻ ︵ヽ(`Д´)ﾉ︵﻿ ┻━┻";
            // 
            // cbIncludePropertyInRaise
            // 
            this.cbIncludePropertyInRaise.AutoSize = true;
            this.cbIncludePropertyInRaise.Location = new System.Drawing.Point(286, 398);
            this.cbIncludePropertyInRaise.Name = "cbIncludePropertyInRaise";
            this.cbIncludePropertyInRaise.Size = new System.Drawing.Size(254, 17);
            this.cbIncludePropertyInRaise.TabIndex = 9;
            this.cbIncludePropertyInRaise.Text = "Include PropertyName in RaisePropertyChanged";
            this.cbIncludePropertyInRaise.UseVisualStyleBackColor = true;
            // 
            // btnCopyResults
            // 
            this.btnCopyResults.Location = new System.Drawing.Point(286, 559);
            this.btnCopyResults.Name = "btnCopyResults";
            this.btnCopyResults.Size = new System.Drawing.Size(263, 23);
            this.btnCopyResults.TabIndex = 10;
            this.btnCopyResults.Text = "Results To Clipboard";
            this.btnCopyResults.UseVisualStyleBackColor = true;
            this.btnCopyResults.Click += new System.EventHandler(this.btnCopyResults_Click);
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.BackColor = System.Drawing.SystemColors.Control;
            this.cbReadOnly.Location = new System.Drawing.Point(286, 373);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(76, 17);
            this.cbReadOnly.TabIndex = 11;
            this.cbReadOnly.Text = "Read Only";
            this.cbReadOnly.UseVisualStyleBackColor = false;
            // 
            // cbVirtual
            // 
            this.cbVirtual.AutoSize = true;
            this.cbVirtual.Location = new System.Drawing.Point(286, 423);
            this.cbVirtual.Name = "cbVirtual";
            this.cbVirtual.Size = new System.Drawing.Size(190, 17);
            this.cbVirtual.TabIndex = 12;
            this.cbVirtual.Text = "Virtual  (NHibernate entity property)";
            this.cbVirtual.UseVisualStyleBackColor = true;
            // 
            // cbMapProperty
            // 
            this.cbMapProperty.AutoSize = true;
            this.cbMapProperty.Location = new System.Drawing.Point(286, 446);
            this.cbMapProperty.Name = "cbMapProperty";
            this.cbMapProperty.Size = new System.Drawing.Size(86, 17);
            this.cbMapProperty.TabIndex = 13;
            this.cbMapProperty.Text = "MapProperty";
            this.cbMapProperty.UseVisualStyleBackColor = true;
            this.cbMapProperty.CheckedChanged += new System.EventHandler(this.cbMapProperty_CheckedChanged);
            // 
            // cbMapReference
            // 
            this.cbMapReference.AutoSize = true;
            this.cbMapReference.Location = new System.Drawing.Point(286, 469);
            this.cbMapReference.Name = "cbMapReference";
            this.cbMapReference.Size = new System.Drawing.Size(97, 17);
            this.cbMapReference.TabIndex = 14;
            this.cbMapReference.Text = "MapReference";
            this.cbMapReference.UseVisualStyleBackColor = true;
            this.cbMapReference.CheckedChanged += new System.EventHandler(this.cbMapReference_CheckedChanged);
            // 
            // cbDropDatabase
            // 
            this.cbDropDatabase.AutoSize = true;
            this.cbDropDatabase.Location = new System.Drawing.Point(286, 492);
            this.cbDropDatabase.Name = "cbDropDatabase";
            this.cbDropDatabase.Size = new System.Drawing.Size(98, 17);
            this.cbDropDatabase.TabIndex = 15;
            this.cbDropDatabase.Text = "Drop Database";
            this.cbDropDatabase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 585);
            this.Controls.Add(this.cbDropDatabase);
            this.Controls.Add(this.cbMapReference);
            this.Controls.Add(this.cbMapProperty);
            this.Controls.Add(this.cbVirtual);
            this.Controls.Add(this.cbReadOnly);
            this.Controls.Add(this.btnCopyResults);
            this.Controls.Add(this.cbIncludePropertyInRaise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMakeItSo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbString;
        private System.Windows.Forms.RadioButton rbBoolN;
        private System.Windows.Forms.RadioButton rbBool;
        private System.Windows.Forms.RadioButton rbIntN;
        private System.Windows.Forms.RadioButton rbInt;
        private System.Windows.Forms.RadioButton rbGuidN;
        private System.Windows.Forms.RadioButton rbGuid;
        private System.Windows.Forms.Button btnMakeItSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDecimalN;
        private System.Windows.Forms.RadioButton rbDecimal;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.CheckBox cbIncludePropertyInRaise;
        private System.Windows.Forms.Button btnCopyResults;
        private System.Windows.Forms.RadioButton rbRelayCommand;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.RadioButton rbVisibility;
        private System.Windows.Forms.CheckBox cbVirtual;
        private System.Windows.Forms.CheckBox cbMapProperty;
        private System.Windows.Forms.CheckBox cbMapReference;
        private System.Windows.Forms.CheckBox cbDropDatabase;
    }
}

