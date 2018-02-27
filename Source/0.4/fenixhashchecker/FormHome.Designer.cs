namespace fenixhashchecker
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbEnterFile2 = new System.Windows.Forms.GroupBox();
            this.btnCopyHash2 = new System.Windows.Forms.Button();
            this.cmbType2 = new System.Windows.Forms.ComboBox();
            this.btnLoadFile2 = new System.Windows.Forms.Button();
            this.txtFilename2 = new System.Windows.Forms.TextBox();
            this.gbEnterFile1 = new System.Windows.Forms.GroupBox();
            this.btnCopyHash1 = new System.Windows.Forms.Button();
            this.btnLoadFile1 = new System.Windows.Forms.Button();
            this.txtFilename1 = new System.Windows.Forms.TextBox();
            this.cmbType1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mmCopyRight = new System.Windows.Forms.RichTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbEnterFile2.SuspendLayout();
            this.gbEnterFile1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage2);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 110);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(575, 247);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCheck);
            this.tabPage1.Controls.Add(this.gbEnterFile2);
            this.tabPage1.Controls.Add(this.gbEnterFile1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Index";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(140, 181);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(283, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gbEnterFile2
            // 
            this.gbEnterFile2.Controls.Add(this.btnCopyHash2);
            this.gbEnterFile2.Controls.Add(this.cmbType2);
            this.gbEnterFile2.Controls.Add(this.btnLoadFile2);
            this.gbEnterFile2.Controls.Add(this.txtFilename2);
            this.gbEnterFile2.Location = new System.Drawing.Point(19, 93);
            this.gbEnterFile2.Name = "gbEnterFile2";
            this.gbEnterFile2.Size = new System.Drawing.Size(529, 68);
            this.gbEnterFile2.TabIndex = 1;
            this.gbEnterFile2.TabStop = false;
            this.gbEnterFile2.Text = "Enter File";
            // 
            // btnCopyHash2
            // 
            this.btnCopyHash2.Location = new System.Drawing.Point(439, 29);
            this.btnCopyHash2.Name = "btnCopyHash2";
            this.btnCopyHash2.Size = new System.Drawing.Size(75, 23);
            this.btnCopyHash2.TabIndex = 4;
            this.btnCopyHash2.Text = "Copy Hash";
            this.btnCopyHash2.UseVisualStyleBackColor = true;
            this.btnCopyHash2.Click += new System.EventHandler(this.btnCopyHash2_Click);
            // 
            // cmbType2
            // 
            this.cmbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType2.FormattingEnabled = true;
            this.cmbType2.Items.AddRange(new object[] {
            "Hash",
            "File"});
            this.cmbType2.Location = new System.Drawing.Point(17, 28);
            this.cmbType2.Name = "cmbType2";
            this.cmbType2.Size = new System.Drawing.Size(121, 21);
            this.cmbType2.TabIndex = 3;
            this.cmbType2.SelectedValueChanged += new System.EventHandler(this.cmbType2_SelectedValueChanged);
            // 
            // btnLoadFile2
            // 
            this.btnLoadFile2.Location = new System.Drawing.Point(358, 29);
            this.btnLoadFile2.Name = "btnLoadFile2";
            this.btnLoadFile2.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile2.TabIndex = 2;
            this.btnLoadFile2.Text = "...";
            this.btnLoadFile2.UseVisualStyleBackColor = true;
            this.btnLoadFile2.Click += new System.EventHandler(this.btnLoadFile2_Click);
            // 
            // txtFilename2
            // 
            this.txtFilename2.AllowDrop = true;
            this.txtFilename2.Location = new System.Drawing.Point(145, 29);
            this.txtFilename2.Name = "txtFilename2";
            this.txtFilename2.ReadOnly = true;
            this.txtFilename2.Size = new System.Drawing.Size(207, 20);
            this.txtFilename2.TabIndex = 1;
            this.txtFilename2.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFilename2_DragDrop);
            this.txtFilename2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFilename2_DragEnter);
            // 
            // gbEnterFile1
            // 
            this.gbEnterFile1.Controls.Add(this.btnCopyHash1);
            this.gbEnterFile1.Controls.Add(this.btnLoadFile1);
            this.gbEnterFile1.Controls.Add(this.txtFilename1);
            this.gbEnterFile1.Controls.Add(this.cmbType1);
            this.gbEnterFile1.Location = new System.Drawing.Point(19, 19);
            this.gbEnterFile1.Name = "gbEnterFile1";
            this.gbEnterFile1.Size = new System.Drawing.Size(529, 68);
            this.gbEnterFile1.TabIndex = 0;
            this.gbEnterFile1.TabStop = false;
            this.gbEnterFile1.Text = "Enter File";
            // 
            // btnCopyHash1
            // 
            this.btnCopyHash1.Location = new System.Drawing.Point(439, 27);
            this.btnCopyHash1.Name = "btnCopyHash1";
            this.btnCopyHash1.Size = new System.Drawing.Size(75, 23);
            this.btnCopyHash1.TabIndex = 3;
            this.btnCopyHash1.Text = "Copy Hash";
            this.btnCopyHash1.UseVisualStyleBackColor = true;
            this.btnCopyHash1.Click += new System.EventHandler(this.btnCopyHash1_Click);
            // 
            // btnLoadFile1
            // 
            this.btnLoadFile1.Location = new System.Drawing.Point(358, 27);
            this.btnLoadFile1.Name = "btnLoadFile1";
            this.btnLoadFile1.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile1.TabIndex = 2;
            this.btnLoadFile1.Text = "...";
            this.btnLoadFile1.UseVisualStyleBackColor = true;
            this.btnLoadFile1.Click += new System.EventHandler(this.btnLoadFile1_Click);
            // 
            // txtFilename1
            // 
            this.txtFilename1.AllowDrop = true;
            this.txtFilename1.Location = new System.Drawing.Point(145, 29);
            this.txtFilename1.Name = "txtFilename1";
            this.txtFilename1.ReadOnly = true;
            this.txtFilename1.Size = new System.Drawing.Size(207, 20);
            this.txtFilename1.TabIndex = 1;
            this.txtFilename1.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFilename1_DragDrop);
            this.txtFilename1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFilename1_DragEnter);
            // 
            // cmbType1
            // 
            this.cmbType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType1.FormattingEnabled = true;
            this.cmbType1.Items.AddRange(new object[] {
            "Hash",
            "File"});
            this.cmbType1.Location = new System.Drawing.Point(17, 29);
            this.cmbType1.Name = "cmbType1";
            this.cmbType1.Size = new System.Drawing.Size(121, 21);
            this.cmbType1.TabIndex = 0;
            this.cmbType1.SelectedValueChanged += new System.EventHandler(this.cmbType1_SelectedValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mmCopyRight);
            this.groupBox3.Controls.Add(this.pbImage);
            this.groupBox3.Location = new System.Drawing.Point(18, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 188);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // mmCopyRight
            // 
            this.mmCopyRight.Location = new System.Drawing.Point(281, 58);
            this.mmCopyRight.Name = "mmCopyRight";
            this.mmCopyRight.ReadOnly = true;
            this.mmCopyRight.Size = new System.Drawing.Size(199, 78);
            this.mmCopyRight.TabIndex = 1;
            this.mmCopyRight.Text = "Fenix Hash Checker\nVersion 0.4\nWritten By Ismael Heredia\nContact : ismael_heredia" +
    "[at]hotmail[com]\nWeb : ismaelheredia123.wordpress.com";
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(77, 19);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(184, 163);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssStatus.Location = new System.Drawing.Point(0, 373);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(600, 22);
            this.ssStatus.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "[+] Ready";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(26, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(548, 81);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 395);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - Fenix Hash Checker 0.4 - © Ismael Heredia , Argentina , 2017 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbEnterFile2.ResumeLayout(false);
            this.gbEnterFile2.PerformLayout();
            this.gbEnterFile1.ResumeLayout(false);
            this.gbEnterFile1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gbEnterFile2;
        private System.Windows.Forms.Button btnLoadFile2;
        private System.Windows.Forms.TextBox txtFilename2;
        private System.Windows.Forms.GroupBox gbEnterFile1;
        private System.Windows.Forms.Button btnLoadFile1;
        private System.Windows.Forms.TextBox txtFilename1;
        private System.Windows.Forms.ComboBox cmbType1;
        private System.Windows.Forms.ComboBox cmbType2;
        private System.Windows.Forms.Button btnCopyHash2;
        private System.Windows.Forms.Button btnCopyHash1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RichTextBox mmCopyRight;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

