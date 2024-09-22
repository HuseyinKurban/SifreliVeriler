namespace SifreliVeriler
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txthesapno = new System.Windows.Forms.TextBox();
            this.btnsifrecoz = new System.Windows.Forms.Button();
            this.lblcozum = new System.Windows.Forms.Label();
            this.txtcozum = new System.Windows.Forms.TextBox();
            this.txtcozulmusveri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(111, 5);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(220, 35);
            this.txtad.TabIndex = 1;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(631, 108);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(141, 39);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 300);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hesap No :";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(111, 59);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(220, 35);
            this.txtsoyad.TabIndex = 8;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(111, 110);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(220, 35);
            this.txtmail.TabIndex = 9;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(552, 8);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(220, 35);
            this.txtsifre.TabIndex = 10;
            // 
            // txthesapno
            // 
            this.txthesapno.Location = new System.Drawing.Point(552, 68);
            this.txthesapno.Name = "txthesapno";
            this.txthesapno.Size = new System.Drawing.Size(220, 35);
            this.txthesapno.TabIndex = 11;
            // 
            // btnsifrecoz
            // 
            this.btnsifrecoz.Location = new System.Drawing.Point(729, 202);
            this.btnsifrecoz.Name = "btnsifrecoz";
            this.btnsifrecoz.Size = new System.Drawing.Size(84, 39);
            this.btnsifrecoz.TabIndex = 13;
            this.btnsifrecoz.Text = "Çöz";
            this.btnsifrecoz.UseVisualStyleBackColor = true;
            this.btnsifrecoz.Click += new System.EventHandler(this.btnsifrecoz_Click);
            // 
            // lblcozum
            // 
            this.lblcozum.AutoSize = true;
            this.lblcozum.Location = new System.Drawing.Point(-5, 174);
            this.lblcozum.Name = "lblcozum";
            this.lblcozum.Size = new System.Drawing.Size(136, 29);
            this.lblcozum.TabIndex = 14;
            this.lblcozum.Text = "Şifreli Veri :";
            // 
            // txtcozum
            // 
            this.txtcozum.Location = new System.Drawing.Point(0, 206);
            this.txtcozum.Name = "txtcozum";
            this.txtcozum.Size = new System.Drawing.Size(331, 35);
            this.txtcozum.TabIndex = 15;
            // 
            // txtcozulmusveri
            // 
            this.txtcozulmusveri.Location = new System.Drawing.Point(348, 206);
            this.txtcozulmusveri.Name = "txtcozulmusveri";
            this.txtcozulmusveri.Size = new System.Drawing.Size(375, 35);
            this.txtcozulmusveri.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Çözülmüş Veri :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 547);
            this.Controls.Add(this.txtcozulmusveri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcozum);
            this.Controls.Add(this.lblcozum);
            this.Controls.Add(this.btnsifrecoz);
            this.Controls.Add(this.txthesapno);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txthesapno;
        private System.Windows.Forms.Button btnsifrecoz;
        private System.Windows.Forms.Label lblcozum;
        private System.Windows.Forms.TextBox txtcozum;
        private System.Windows.Forms.TextBox txtcozulmusveri;
        private System.Windows.Forms.Label label6;
    }
}

