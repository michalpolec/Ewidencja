namespace Ewidencja
{
    partial class EwidencjaKierownikow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EwidencjaKierownikow));
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.createExcel = new System.Windows.Forms.Button();
            this.firstExcel = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.OpenFileDialog();
            this.secondExcel = new System.Windows.Forms.Button();
            this.thirdExcel = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxWithThirdFile = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxWithSecondFile = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxWithCreatingFile = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.boxWithThirdFile.SuspendLayout();
            this.boxWithSecondFile.SuspendLayout();
            this.boxWithCreatingFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // createExcel
            // 
            this.createExcel.Location = new System.Drawing.Point(23, 40);
            this.createExcel.Name = "createExcel";
            this.createExcel.Size = new System.Drawing.Size(297, 33);
            this.createExcel.TabIndex = 0;
            this.createExcel.Text = "Utwórz nowy plik";
            this.createExcel.UseVisualStyleBackColor = true;
            this.createExcel.Click += new System.EventHandler(this.createExcel_Click);
            // 
            // firstExcel
            // 
            this.firstExcel.Location = new System.Drawing.Point(13, 36);
            this.firstExcel.Name = "firstExcel";
            this.firstExcel.Size = new System.Drawing.Size(363, 33);
            this.firstExcel.TabIndex = 1;
            this.firstExcel.Text = "Wczytaj pierwszy plik DPK";
            this.firstExcel.UseVisualStyleBackColor = true;
            this.firstExcel.Click += new System.EventHandler(this.firstExcel_Click);
            // 
            // secondExcel
            // 
            this.secondExcel.Location = new System.Drawing.Point(13, 36);
            this.secondExcel.Name = "secondExcel";
            this.secondExcel.Size = new System.Drawing.Size(363, 33);
            this.secondExcel.TabIndex = 4;
            this.secondExcel.Text = "Wczytaj drugi plik DPK";
            this.secondExcel.UseVisualStyleBackColor = true;
            this.secondExcel.Click += new System.EventHandler(this.secondExcel_Click);
            // 
            // thirdExcel
            // 
            this.thirdExcel.Location = new System.Drawing.Point(13, 36);
            this.thirdExcel.Name = "thirdExcel";
            this.thirdExcel.Size = new System.Drawing.Size(363, 33);
            this.thirdExcel.TabIndex = 5;
            this.thirdExcel.Text = "Wczytaj plik ewidencji";
            this.thirdExcel.UseVisualStyleBackColor = true;
            this.thirdExcel.Click += new System.EventHandler(this.thirdExcel_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(80, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(288, 22);
            this.datePicker.TabIndex = 8;
            this.datePicker.Value = new System.DateTime(2020, 8, 8, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.boxWithThirdFile);
            this.groupBox1.Controls.Add(this.boxWithSecondFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 402);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pliki źródłowe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.firstExcel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 114);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pierwszy plik DPK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // boxWithThirdFile
            // 
            this.boxWithThirdFile.Controls.Add(this.label6);
            this.boxWithThirdFile.Controls.Add(this.thirdExcel);
            this.boxWithThirdFile.Enabled = false;
            this.boxWithThirdFile.Location = new System.Drawing.Point(12, 272);
            this.boxWithThirdFile.Name = "boxWithThirdFile";
            this.boxWithThirdFile.Size = new System.Drawing.Size(390, 116);
            this.boxWithThirdFile.TabIndex = 0;
            this.boxWithThirdFile.TabStop = false;
            this.boxWithThirdFile.Text = "Plik ewidencji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 14;
            // 
            // boxWithSecondFile
            // 
            this.boxWithSecondFile.Controls.Add(this.secondExcel);
            this.boxWithSecondFile.Controls.Add(this.label5);
            this.boxWithSecondFile.Enabled = false;
            this.boxWithSecondFile.Location = new System.Drawing.Point(12, 156);
            this.boxWithSecondFile.Name = "boxWithSecondFile";
            this.boxWithSecondFile.Size = new System.Drawing.Size(390, 110);
            this.boxWithSecondFile.TabIndex = 0;
            this.boxWithSecondFile.TabStop = false;
            this.boxWithSecondFile.Text = "Drugi plik DPK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 13;
            // 
            // boxWithCreatingFile
            // 
            this.boxWithCreatingFile.Controls.Add(this.label1);
            this.boxWithCreatingFile.Controls.Add(this.createExcel);
            this.boxWithCreatingFile.Enabled = false;
            this.boxWithCreatingFile.Location = new System.Drawing.Point(452, 51);
            this.boxWithCreatingFile.Name = "boxWithCreatingFile";
            this.boxWithCreatingFile.Size = new System.Drawing.Size(336, 145);
            this.boxWithCreatingFile.TabIndex = 10;
            this.boxWithCreatingFile.TabStop = false;
            this.boxWithCreatingFile.Text = "Tworzenie pliku ze zgodnościami";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(452, 222);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(336, 217);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // EwidencjaMaszynistow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.boxWithCreatingFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePicker);
            this.MaximumSize = new System.Drawing.Size(818, 509);
            this.MinimumSize = new System.Drawing.Size(818, 509);
            this.Name = "EwidencjaKierownikow";
            this.Text = "Ewidencja - Kierownicy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.boxWithThirdFile.ResumeLayout(false);
            this.boxWithThirdFile.PerformLayout();
            this.boxWithSecondFile.ResumeLayout(false);
            this.boxWithSecondFile.PerformLayout();
            this.boxWithCreatingFile.ResumeLayout(false);
            this.boxWithCreatingFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button createExcel;
        private System.Windows.Forms.Button firstExcel;
        private System.Windows.Forms.OpenFileDialog loadFile;
        private System.Windows.Forms.Button secondExcel;
        private System.Windows.Forms.Button thirdExcel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox boxWithThirdFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox boxWithSecondFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox boxWithCreatingFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;

    }
}