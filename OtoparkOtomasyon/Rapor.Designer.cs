namespace OtoparkOtomasyon
{
    partial class Rapor
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
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblToplamUcret = new System.Windows.Forms.Label();
            lblToplamArac = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(357, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Plaka";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Abone";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Süre";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ücret";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblToplamUcret);
            groupBox1.Controls.Add(lblToplamArac);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(375, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(413, 435);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toplam Bilgiler";
            // 
            // lblToplamUcret
            // 
            lblToplamUcret.AutoSize = true;
            lblToplamUcret.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblToplamUcret.Location = new System.Drawing.Point(188, 70);
            lblToplamUcret.Name = "lblToplamUcret";
            lblToplamUcret.Size = new System.Drawing.Size(46, 25);
            lblToplamUcret.TabIndex = 10;
            lblToplamUcret.Text = "0 TL";
            // 
            // lblToplamArac
            // 
            lblToplamArac.AutoSize = true;
            lblToplamArac.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblToplamArac.Location = new System.Drawing.Point(188, 35);
            lblToplamArac.Name = "lblToplamArac";
            lblToplamArac.Size = new System.Drawing.Size(22, 25);
            lblToplamArac.TabIndex = 9;
            lblToplamArac.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(17, 70);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 25);
            label4.TabIndex = 12;
            label4.Text = "Toplam Ücret";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(17, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 25);
            label3.TabIndex = 11;
            label3.Text = "Toplam Araç";
            // 
            // Rapor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "Rapor";
            Text = "Rapor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label lblToplamUcret;
        public System.Windows.Forms.Label lblToplamArac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}