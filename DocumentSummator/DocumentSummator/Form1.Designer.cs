namespace DocumentSummator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.chkFirm = new System.Windows.Forms.CheckBox();
            this.chkJurCIty = new System.Windows.Forms.CheckBox();
            this.chkPostCIty = new System.Windows.Forms.CheckBox();
            this.cmbFirm = new System.Windows.Forms.ComboBox();
            this.cmbJurCity = new System.Windows.Forms.ComboBox();
            this.cmbPostCity = new System.Windows.Forms.ComboBox();
            this.radFirmCmb = new System.Windows.Forms.RadioButton();
            this.txtFirm = new System.Windows.Forms.TextBox();
            this.radFirmTxt = new System.Windows.Forms.RadioButton();
            this.radJurCityCmb = new System.Windows.Forms.RadioButton();
            this.txtJurCity = new System.Windows.Forms.TextBox();
            this.txtPostCity = new System.Windows.Forms.TextBox();
            this.radJurCityTxt = new System.Windows.Forms.RadioButton();
            this.radPostCityCmb = new System.Windows.Forms.RadioButton();
            this.radPostCityTxt = new System.Windows.Forms.RadioButton();
            this.groupFirm = new System.Windows.Forms.GroupBox();
            this.groupJurCIty = new System.Windows.Forms.GroupBox();
            this.groupPostCIty = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupFirm.SuspendLayout();
            this.groupJurCIty.SuspendLayout();
            this.groupPostCIty.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(477, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkFirm
            // 
            this.chkFirm.AutoSize = true;
            this.chkFirm.Location = new System.Drawing.Point(843, 22);
            this.chkFirm.Name = "chkFirm";
            this.chkFirm.Size = new System.Drawing.Size(15, 14);
            this.chkFirm.TabIndex = 5;
            this.chkFirm.UseVisualStyleBackColor = true;
            this.chkFirm.CheckedChanged += new System.EventHandler(this.chkFirm_CheckedChanged);
            // 
            // chkJurCIty
            // 
            this.chkJurCIty.AutoSize = true;
            this.chkJurCIty.Location = new System.Drawing.Point(843, 108);
            this.chkJurCIty.Name = "chkJurCIty";
            this.chkJurCIty.Size = new System.Drawing.Size(15, 14);
            this.chkJurCIty.TabIndex = 6;
            this.chkJurCIty.UseVisualStyleBackColor = true;
            this.chkJurCIty.CheckedChanged += new System.EventHandler(this.chkJurCIty_CheckedChanged);
            // 
            // chkPostCIty
            // 
            this.chkPostCIty.AutoSize = true;
            this.chkPostCIty.Location = new System.Drawing.Point(843, 190);
            this.chkPostCIty.Name = "chkPostCIty";
            this.chkPostCIty.Size = new System.Drawing.Size(15, 14);
            this.chkPostCIty.TabIndex = 7;
            this.chkPostCIty.UseVisualStyleBackColor = true;
            this.chkPostCIty.CheckedChanged += new System.EventHandler(this.chkPostCIty_CheckedChanged);
            // 
            // cmbFirm
            // 
            this.cmbFirm.FormattingEnabled = true;
            this.cmbFirm.Location = new System.Drawing.Point(6, 19);
            this.cmbFirm.Name = "cmbFirm";
            this.cmbFirm.Size = new System.Drawing.Size(180, 21);
            this.cmbFirm.TabIndex = 8;
            // 
            // cmbJurCity
            // 
            this.cmbJurCity.FormattingEnabled = true;
            this.cmbJurCity.Location = new System.Drawing.Point(6, 19);
            this.cmbJurCity.Name = "cmbJurCity";
            this.cmbJurCity.Size = new System.Drawing.Size(180, 21);
            this.cmbJurCity.TabIndex = 9;
            // 
            // cmbPostCity
            // 
            this.cmbPostCity.FormattingEnabled = true;
            this.cmbPostCity.Location = new System.Drawing.Point(6, 21);
            this.cmbPostCity.Name = "cmbPostCity";
            this.cmbPostCity.Size = new System.Drawing.Size(180, 21);
            this.cmbPostCity.TabIndex = 10;
            // 
            // radFirmCmb
            // 
            this.radFirmCmb.AutoSize = true;
            this.radFirmCmb.Checked = true;
            this.radFirmCmb.Location = new System.Drawing.Point(192, 19);
            this.radFirmCmb.Name = "radFirmCmb";
            this.radFirmCmb.Size = new System.Drawing.Size(123, 17);
            this.radFirmCmb.TabIndex = 11;
            this.radFirmCmb.TabStop = true;
            this.radFirmCmb.Text = "Выбрать из списка";
            this.radFirmCmb.UseVisualStyleBackColor = true;
            this.radFirmCmb.CheckedChanged += new System.EventHandler(this.radFirmCmb_CheckedChanged);
            // 
            // txtFirm
            // 
            this.txtFirm.Enabled = false;
            this.txtFirm.Location = new System.Drawing.Point(6, 54);
            this.txtFirm.Name = "txtFirm";
            this.txtFirm.Size = new System.Drawing.Size(180, 20);
            this.txtFirm.TabIndex = 12;
            // 
            // radFirmTxt
            // 
            this.radFirmTxt.AutoSize = true;
            this.radFirmTxt.Location = new System.Drawing.Point(192, 54);
            this.radFirmTxt.Name = "radFirmTxt";
            this.radFirmTxt.Size = new System.Drawing.Size(112, 17);
            this.radFirmTxt.TabIndex = 13;
            this.radFirmTxt.Text = "Набрать вручную";
            this.radFirmTxt.UseVisualStyleBackColor = true;
            this.radFirmTxt.CheckedChanged += new System.EventHandler(this.radFirmTxt_CheckedChanged);
            // 
            // radJurCityCmb
            // 
            this.radJurCityCmb.AutoSize = true;
            this.radJurCityCmb.Checked = true;
            this.radJurCityCmb.Location = new System.Drawing.Point(192, 22);
            this.radJurCityCmb.Name = "radJurCityCmb";
            this.radJurCityCmb.Size = new System.Drawing.Size(123, 17);
            this.radJurCityCmb.TabIndex = 14;
            this.radJurCityCmb.TabStop = true;
            this.radJurCityCmb.Text = "Выбрать из списка";
            this.radJurCityCmb.UseVisualStyleBackColor = true;
            this.radJurCityCmb.CheckedChanged += new System.EventHandler(this.radJurCityCmb_CheckedChanged);
            // 
            // txtJurCity
            // 
            this.txtJurCity.Enabled = false;
            this.txtJurCity.Location = new System.Drawing.Point(6, 47);
            this.txtJurCity.Name = "txtJurCity";
            this.txtJurCity.Size = new System.Drawing.Size(180, 20);
            this.txtJurCity.TabIndex = 15;
            // 
            // txtPostCity
            // 
            this.txtPostCity.Enabled = false;
            this.txtPostCity.Location = new System.Drawing.Point(6, 49);
            this.txtPostCity.Name = "txtPostCity";
            this.txtPostCity.Size = new System.Drawing.Size(180, 20);
            this.txtPostCity.TabIndex = 16;
            // 
            // radJurCityTxt
            // 
            this.radJurCityTxt.AutoSize = true;
            this.radJurCityTxt.Location = new System.Drawing.Point(192, 50);
            this.radJurCityTxt.Name = "radJurCityTxt";
            this.radJurCityTxt.Size = new System.Drawing.Size(112, 17);
            this.radJurCityTxt.TabIndex = 17;
            this.radJurCityTxt.Text = "Набрать вручную";
            this.radJurCityTxt.UseVisualStyleBackColor = true;
            this.radJurCityTxt.CheckedChanged += new System.EventHandler(this.radJurCityTxt_CheckedChanged);
            // 
            // radPostCityCmb
            // 
            this.radPostCityCmb.AutoSize = true;
            this.radPostCityCmb.Checked = true;
            this.radPostCityCmb.Location = new System.Drawing.Point(192, 25);
            this.radPostCityCmb.Name = "radPostCityCmb";
            this.radPostCityCmb.Size = new System.Drawing.Size(123, 17);
            this.radPostCityCmb.TabIndex = 18;
            this.radPostCityCmb.TabStop = true;
            this.radPostCityCmb.Text = "Выбрать из списка";
            this.radPostCityCmb.UseVisualStyleBackColor = true;
            this.radPostCityCmb.CheckedChanged += new System.EventHandler(this.radPostCityCmb_CheckedChanged);
            // 
            // radPostCityTxt
            // 
            this.radPostCityTxt.AutoSize = true;
            this.radPostCityTxt.Location = new System.Drawing.Point(192, 50);
            this.radPostCityTxt.Name = "radPostCityTxt";
            this.radPostCityTxt.Size = new System.Drawing.Size(112, 17);
            this.radPostCityTxt.TabIndex = 19;
            this.radPostCityTxt.Text = "Набрать вручную";
            this.radPostCityTxt.UseVisualStyleBackColor = true;
            this.radPostCityTxt.CheckedChanged += new System.EventHandler(this.radPostCityTxt_CheckedChanged);
            // 
            // groupFirm
            // 
            this.groupFirm.Controls.Add(this.radFirmCmb);
            this.groupFirm.Controls.Add(this.cmbFirm);
            this.groupFirm.Controls.Add(this.radFirmTxt);
            this.groupFirm.Controls.Add(this.txtFirm);
            this.groupFirm.Enabled = false;
            this.groupFirm.Location = new System.Drawing.Point(497, 3);
            this.groupFirm.Name = "groupFirm";
            this.groupFirm.Size = new System.Drawing.Size(327, 80);
            this.groupFirm.TabIndex = 20;
            this.groupFirm.TabStop = false;
            this.groupFirm.Text = "Название фирмы";
            // 
            // groupJurCIty
            // 
            this.groupJurCIty.Controls.Add(this.cmbJurCity);
            this.groupJurCIty.Controls.Add(this.radJurCityCmb);
            this.groupJurCIty.Controls.Add(this.txtJurCity);
            this.groupJurCIty.Controls.Add(this.radJurCityTxt);
            this.groupJurCIty.Enabled = false;
            this.groupJurCIty.Location = new System.Drawing.Point(497, 89);
            this.groupJurCIty.Name = "groupJurCIty";
            this.groupJurCIty.Size = new System.Drawing.Size(327, 74);
            this.groupJurCIty.TabIndex = 21;
            this.groupJurCIty.TabStop = false;
            this.groupJurCIty.Text = "Юридический адрес";
            // 
            // groupPostCIty
            // 
            this.groupPostCIty.Controls.Add(this.radPostCityTxt);
            this.groupPostCIty.Controls.Add(this.cmbPostCity);
            this.groupPostCIty.Controls.Add(this.txtPostCity);
            this.groupPostCIty.Controls.Add(this.radPostCityCmb);
            this.groupPostCIty.Enabled = false;
            this.groupPostCIty.Location = new System.Drawing.Point(497, 169);
            this.groupPostCIty.Name = "groupPostCIty";
            this.groupPostCIty.Size = new System.Drawing.Size(327, 76);
            this.groupPostCIty.TabIndex = 22;
            this.groupPostCIty.TabStop = false;
            this.groupPostCIty.Text = "Почтовый адрес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 369);
            this.Controls.Add(this.groupPostCIty);
            this.Controls.Add(this.groupJurCIty);
            this.Controls.Add(this.groupFirm);
            this.Controls.Add(this.chkPostCIty);
            this.Controls.Add(this.chkJurCIty);
            this.Controls.Add(this.chkFirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "DocumentSummator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupFirm.ResumeLayout(false);
            this.groupFirm.PerformLayout();
            this.groupJurCIty.ResumeLayout(false);
            this.groupJurCIty.PerformLayout();
            this.groupPostCIty.ResumeLayout(false);
            this.groupPostCIty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkFirm;
        private System.Windows.Forms.CheckBox chkJurCIty;
        private System.Windows.Forms.CheckBox chkPostCIty;
        private System.Windows.Forms.ComboBox cmbFirm;
        private System.Windows.Forms.ComboBox cmbJurCity;
        private System.Windows.Forms.ComboBox cmbPostCity;
        private System.Windows.Forms.RadioButton radFirmCmb;
        private System.Windows.Forms.TextBox txtFirm;
        private System.Windows.Forms.RadioButton radFirmTxt;
        private System.Windows.Forms.RadioButton radJurCityCmb;
        private System.Windows.Forms.TextBox txtJurCity;
        private System.Windows.Forms.TextBox txtPostCity;
        private System.Windows.Forms.RadioButton radJurCityTxt;
        private System.Windows.Forms.RadioButton radPostCityCmb;
        private System.Windows.Forms.RadioButton radPostCityTxt;
        private System.Windows.Forms.GroupBox groupFirm;
        private System.Windows.Forms.GroupBox groupJurCIty;
        private System.Windows.Forms.GroupBox groupPostCIty;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

