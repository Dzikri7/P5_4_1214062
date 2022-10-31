namespace P5_4_1214062
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
            this.lNama = new System.Windows.Forms.Label();
            this.lJK = new System.Windows.Forms.Label();
            this.lTL = new System.Windows.Forms.Label();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb8Komposer = new System.Windows.Forms.CheckBox();
            this.cb4Konduktor = new System.Windows.Forms.CheckBox();
            this.cb7Vokal = new System.Windows.Forms.CheckBox();
            this.cb3Saxophone = new System.Windows.Forms.CheckBox();
            this.cb6Drum = new System.Windows.Forms.CheckBox();
            this.cb2Gitar = new System.Windows.Forms.CheckBox();
            this.cb5Piano = new System.Windows.Forms.CheckBox();
            this.cb1Biola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.dtpTL = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNama
            // 
            this.lNama.AutoSize = true;
            this.lNama.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNama.Location = new System.Drawing.Point(271, 77);
            this.lNama.Name = "lNama";
            this.lNama.Size = new System.Drawing.Size(38, 15);
            this.lNama.TabIndex = 0;
            this.lNama.Text = "Nama";
            // 
            // lJK
            // 
            this.lJK.AutoSize = true;
            this.lJK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJK.Location = new System.Drawing.Point(271, 110);
            this.lJK.Name = "lJK";
            this.lJK.Size = new System.Drawing.Size(84, 15);
            this.lJK.TabIndex = 1;
            this.lJK.Text = "Jenis Kelamin";
            // 
            // lTL
            // 
            this.lTL.AutoSize = true;
            this.lTL.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTL.Location = new System.Drawing.Point(271, 145);
            this.lTL.Name = "lTL";
            this.lTL.Size = new System.Drawing.Size(81, 15);
            this.lTL.TabIndex = 2;
            this.lTL.Text = "Tanggal Lahir";
            this.lTL.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Pria",
            "Perempuan"});
            this.cbJK.Location = new System.Drawing.Point(416, 108);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(128, 21);
            this.cbJK.TabIndex = 4;
            this.cbJK.Text = "---Pilih Jenis Kelamin---";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb8Komposer);
            this.groupBox1.Controls.Add(this.cb4Konduktor);
            this.groupBox1.Controls.Add(this.cb7Vokal);
            this.groupBox1.Controls.Add(this.cb3Saxophone);
            this.groupBox1.Controls.Add(this.cb6Drum);
            this.groupBox1.Controls.Add(this.cb2Gitar);
            this.groupBox1.Controls.Add(this.cb5Piano);
            this.groupBox1.Controls.Add(this.cb1Biola);
            this.groupBox1.Location = new System.Drawing.Point(67, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb8Komposer
            // 
            this.cb8Komposer.AutoSize = true;
            this.cb8Komposer.Location = new System.Drawing.Point(188, 155);
            this.cb8Komposer.Name = "cb8Komposer";
            this.cb8Komposer.Size = new System.Drawing.Size(73, 17);
            this.cb8Komposer.TabIndex = 7;
            this.cb8Komposer.Text = "Komposer";
            this.cb8Komposer.UseVisualStyleBackColor = true;
            // 
            // cb4Konduktor
            // 
            this.cb4Konduktor.AutoSize = true;
            this.cb4Konduktor.Location = new System.Drawing.Point(17, 155);
            this.cb4Konduktor.Name = "cb4Konduktor";
            this.cb4Konduktor.Size = new System.Drawing.Size(75, 17);
            this.cb4Konduktor.TabIndex = 6;
            this.cb4Konduktor.Text = "Konduktor";
            this.cb4Konduktor.UseVisualStyleBackColor = true;
            // 
            // cb7Vokal
            // 
            this.cb7Vokal.AutoSize = true;
            this.cb7Vokal.Location = new System.Drawing.Point(188, 117);
            this.cb7Vokal.Name = "cb7Vokal";
            this.cb7Vokal.Size = new System.Drawing.Size(53, 17);
            this.cb7Vokal.TabIndex = 5;
            this.cb7Vokal.Text = "Vokal";
            this.cb7Vokal.UseVisualStyleBackColor = true;
            // 
            // cb3Saxophone
            // 
            this.cb3Saxophone.AutoSize = true;
            this.cb3Saxophone.Location = new System.Drawing.Point(17, 117);
            this.cb3Saxophone.Name = "cb3Saxophone";
            this.cb3Saxophone.Size = new System.Drawing.Size(80, 17);
            this.cb3Saxophone.TabIndex = 4;
            this.cb3Saxophone.Text = "Saxophone";
            this.cb3Saxophone.UseVisualStyleBackColor = true;
            this.cb3Saxophone.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // cb6Drum
            // 
            this.cb6Drum.AutoSize = true;
            this.cb6Drum.Location = new System.Drawing.Point(188, 76);
            this.cb6Drum.Name = "cb6Drum";
            this.cb6Drum.Size = new System.Drawing.Size(51, 17);
            this.cb6Drum.TabIndex = 3;
            this.cb6Drum.Text = "Drum";
            this.cb6Drum.UseVisualStyleBackColor = true;
            // 
            // cb2Gitar
            // 
            this.cb2Gitar.AutoSize = true;
            this.cb2Gitar.Location = new System.Drawing.Point(17, 76);
            this.cb2Gitar.Name = "cb2Gitar";
            this.cb2Gitar.Size = new System.Drawing.Size(48, 17);
            this.cb2Gitar.TabIndex = 2;
            this.cb2Gitar.Text = "Gitar";
            this.cb2Gitar.UseVisualStyleBackColor = true;
            // 
            // cb5Piano
            // 
            this.cb5Piano.AutoSize = true;
            this.cb5Piano.Location = new System.Drawing.Point(188, 34);
            this.cb5Piano.Name = "cb5Piano";
            this.cb5Piano.Size = new System.Drawing.Size(53, 17);
            this.cb5Piano.TabIndex = 1;
            this.cb5Piano.Text = "Piano";
            this.cb5Piano.UseVisualStyleBackColor = true;
            // 
            // cb1Biola
            // 
            this.cb1Biola.AutoSize = true;
            this.cb1Biola.Location = new System.Drawing.Point(17, 34);
            this.cb1Biola.Name = "cb1Biola";
            this.cb1Biola.Size = new System.Drawing.Size(49, 17);
            this.cb1Biola.TabIndex = 0;
            this.cb1Biola.Text = "Biola";
            this.cb1Biola.UseVisualStyleBackColor = true;
            this.cb1Biola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJadwal4);
            this.groupBox2.Controls.Add(this.rbJadwal3);
            this.groupBox2.Controls.Add(this.rbJadwal2);
            this.groupBox2.Controls.Add(this.rbJadwal1);
            this.groupBox2.Location = new System.Drawing.Point(436, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 202);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(23, 155);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(129, 17);
            this.rbJadwal4.TabIndex = 3;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(23, 117);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(169, 17);
            this.rbJadwal3.TabIndex = 2;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(24, 76);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(166, 17);
            this.rbJadwal2.TabIndex = 1;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(24, 34);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(159, 17);
            this.rbJadwal1.TabIndex = 0;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(416, 75);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(200, 20);
            this.tbNama.TabIndex = 11;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // dtpTL
            // 
            this.dtpTL.Location = new System.Drawing.Point(416, 139);
            this.dtpTL.Name = "dtpTL";
            this.dtpTL.Size = new System.Drawing.Size(200, 20);
            this.dtpTL.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpTL);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.lTL);
            this.Controls.Add(this.lJK);
            this.Controls.Add(this.lNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNama;
        private System.Windows.Forms.Label lJK;
        private System.Windows.Forms.Label lTL;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb8Komposer;
        private System.Windows.Forms.CheckBox cb4Konduktor;
        private System.Windows.Forms.CheckBox cb7Vokal;
        private System.Windows.Forms.CheckBox cb3Saxophone;
        private System.Windows.Forms.CheckBox cb6Drum;
        private System.Windows.Forms.CheckBox cb2Gitar;
        private System.Windows.Forms.CheckBox cb5Piano;
        private System.Windows.Forms.CheckBox cb1Biola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.DateTimePicker dtpTL;
    }
}

