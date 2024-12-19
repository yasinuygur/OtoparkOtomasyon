namespace OtoparkOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnEkle = new System.Windows.Forms.Button();
            checkAbone = new System.Windows.Forms.CheckBox();
            CheckKontak = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            listAracTipi = new System.Windows.Forms.ListBox();
            txtPlaka = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            listOtoparkArac = new System.Windows.Forms.ListBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnSatisRapor = new System.Windows.Forms.Button();
            lblUcret = new System.Windows.Forms.Label();
            lblSure = new System.Windows.Forms.Label();
            lblPlaka = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(checkAbone);
            groupBox1.Controls.Add(CheckKontak);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(listAracTipi);
            groupBox1.Controls.Add(txtPlaka);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(336, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Otopark Giriş";
            // 
            // btnEkle
            // 
            btnEkle.Location = new System.Drawing.Point(147, 181);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(75, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // checkAbone
            // 
            checkAbone.AutoSize = true;
            checkAbone.Location = new System.Drawing.Point(161, 156);
            checkAbone.Name = "checkAbone";
            checkAbone.Size = new System.Drawing.Size(61, 19);
            checkAbone.TabIndex = 3;
            checkAbone.Text = "Abone";
            checkAbone.UseVisualStyleBackColor = true;
            // 
            // CheckKontak
            // 
            CheckKontak.AutoSize = true;
            CheckKontak.Location = new System.Drawing.Point(73, 156);
            CheckKontak.Name = "CheckKontak";
            CheckKontak.Size = new System.Drawing.Size(82, 19);
            CheckKontak.TabIndex = 2;
            CheckKontak.Text = "Kontak Var";
            CheckKontak.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Araç Tipi";
            // 
            // listAracTipi
            // 
            listAracTipi.FormattingEnabled = true;
            listAracTipi.ItemHeight = 15;
            listAracTipi.Location = new System.Drawing.Point(73, 56);
            listAracTipi.Name = "listAracTipi";
            listAracTipi.Size = new System.Drawing.Size(149, 94);
            listAracTipi.TabIndex = 1;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new System.Drawing.Point(73, 27);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new System.Drawing.Size(149, 23);
            txtPlaka.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Plaka";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listOtoparkArac);
            groupBox2.Location = new System.Drawing.Point(342, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(446, 438);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Otoparktaki Araçlar";
            // 
            // listOtoparkArac
            // 
            listOtoparkArac.ContextMenuStrip = contextMenuStrip1;
            listOtoparkArac.FormattingEnabled = true;
            listOtoparkArac.ItemHeight = 15;
            listOtoparkArac.Location = new System.Drawing.Point(6, 22);
            listOtoparkArac.Name = "listOtoparkArac";
            listOtoparkArac.Size = new System.Drawing.Size(434, 409);
            listOtoparkArac.TabIndex = 0;
            listOtoparkArac.SelectedIndexChanged += listOtoparkArac_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSatisRapor);
            groupBox3.Controls.Add(lblUcret);
            groupBox3.Controls.Add(lblSure);
            groupBox3.Controls.Add(lblPlaka);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new System.Drawing.Point(0, 218);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(336, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Durum";
            // 
            // btnSatisRapor
            // 
            btnSatisRapor.Location = new System.Drawing.Point(37, 155);
            btnSatisRapor.Name = "btnSatisRapor";
            btnSatisRapor.Size = new System.Drawing.Size(124, 23);
            btnSatisRapor.TabIndex = 5;
            btnSatisRapor.Text = "Günlük Satış Raporu";
            btnSatisRapor.UseVisualStyleBackColor = true;
            btnSatisRapor.Click += btnSatisRapor_Click;
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUcret.Location = new System.Drawing.Point(98, 118);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new System.Drawing.Size(46, 25);
            lblUcret.TabIndex = 2;
            lblUcret.Text = "0 TL";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSure.Location = new System.Drawing.Point(98, 85);
            lblSure.Name = "lblSure";
            lblSure.Size = new System.Drawing.Size(63, 25);
            lblSure.TabIndex = 1;
            lblSure.Text = "0 Saat";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPlaka.Location = new System.Drawing.Point(98, 50);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new System.Drawing.Size(94, 25);
            lblPlaka.TabIndex = 0;
            lblPlaka.Text = "00 XX 000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(37, 118);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 25);
            label5.TabIndex = 9;
            label5.Text = "Ücret";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(37, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 25);
            label4.TabIndex = 8;
            label4.Text = "Süre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(37, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 25);
            label3.TabIndex = 7;
            label3.Text = "Plaka";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { çıkışYapToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkAbone;
        private System.Windows.Forms.CheckBox CheckKontak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listAracTipi;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listOtoparkArac;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSatisRapor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}
