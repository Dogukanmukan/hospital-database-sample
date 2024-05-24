namespace MedipolHastane
{
    partial class doktor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngnc = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.labelidD = new System.Windows.Forms.Label();
            this.txtdok3 = new System.Windows.Forms.TextBox();
            this.txtdok2 = new System.Windows.Forms.TextBox();
            this.txtdok1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgdoktor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdoktor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.btngnc);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.labelidD);
            this.groupBox1.Controls.Add(this.txtdok3);
            this.groupBox1.Controls.Add(this.txtdok2);
            this.groupBox1.Controls.Add(this.txtdok1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(32, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOKTOR BİLGİ İŞLEMİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btngnc
            // 
            this.btngnc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngnc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngnc.Location = new System.Drawing.Point(243, 191);
            this.btngnc.Name = "btngnc";
            this.btngnc.Size = new System.Drawing.Size(82, 29);
            this.btngnc.TabIndex = 4;
            this.btngnc.Text = "GÜNCELLE";
            this.btngnc.UseVisualStyleBackColor = false;
            this.btngnc.Click += new System.EventHandler(this.btngnc_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsil.Location = new System.Drawing.Point(146, 191);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(82, 29);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnekle.Location = new System.Drawing.Point(46, 191);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(82, 29);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // labelidD
            // 
            this.labelidD.AutoSize = true;
            this.labelidD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelidD.Location = new System.Drawing.Point(120, 46);
            this.labelidD.Name = "labelidD";
            this.labelidD.Size = new System.Drawing.Size(21, 24);
            this.labelidD.TabIndex = 3;
            this.labelidD.Text = "0";
            // 
            // txtdok3
            // 
            this.txtdok3.Location = new System.Drawing.Point(124, 141);
            this.txtdok3.Name = "txtdok3";
            this.txtdok3.Size = new System.Drawing.Size(219, 20);
            this.txtdok3.TabIndex = 2;
            // 
            // txtdok2
            // 
            this.txtdok2.Location = new System.Drawing.Point(124, 109);
            this.txtdok2.Name = "txtdok2";
            this.txtdok2.Size = new System.Drawing.Size(219, 20);
            this.txtdok2.TabIndex = 2;
            // 
            // txtdok1
            // 
            this.txtdok1.Location = new System.Drawing.Point(124, 81);
            this.txtdok1.Name = "txtdok1";
            this.txtdok1.Size = new System.Drawing.Size(219, 20);
            this.txtdok1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "BÖLÜM:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD SOYAD:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dgdoktor
            // 
            this.dgdoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdoktor.Location = new System.Drawing.Point(463, 147);
            this.dgdoktor.Name = "dgdoktor";
            this.dgdoktor.Size = new System.Drawing.Size(399, 248);
            this.dgdoktor.TabIndex = 1;
            this.dgdoktor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdoktor_CellClick);
            this.dgdoktor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdoktor_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 91);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(128, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(654, 92);
            this.label6.TabIndex = 1;
            this.label6.Text = "DOKTOR BİLGİ EKRANI";
            // 
            // doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(909, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgdoktor);
            this.Controls.Add(this.groupBox1);
            this.Name = "doktor";
            this.Text = "doktor";
            this.Load += new System.EventHandler(this.doktor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdoktor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdok3;
        private System.Windows.Forms.TextBox txtdok2;
        private System.Windows.Forms.TextBox txtdok1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgdoktor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelidD;
        private System.Windows.Forms.Button btngnc;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
    }
}