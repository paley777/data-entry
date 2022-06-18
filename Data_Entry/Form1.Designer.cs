namespace Data_Entry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtdeskripsi = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.srchbtn = new System.Windows.Forms.Button();
            this.txtnamesrch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Harga (Rp)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Deskripsi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(129, 12);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 22);
            this.txtid.TabIndex = 0;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(129, 65);
            this.txtnama.Margin = new System.Windows.Forms.Padding(4);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(132, 22);
            this.txtnama.TabIndex = 1;
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.Location = new System.Drawing.Point(129, 164);
            this.txtdeskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.Size = new System.Drawing.Size(132, 22);
            this.txtdeskripsi.TabIndex = 3;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(129, 210);
            this.txtkategori.Margin = new System.Windows.Forms.Padding(4);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(132, 22);
            this.txtkategori.TabIndex = 4;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(55, 477);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 62);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(728, 477);
            this.btnview.Margin = new System.Windows.Forms.Padding(4);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(147, 62);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "View Data ";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(896, 385);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(226, 477);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 62);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(396, 477);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(142, 62);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtharga);
            this.panel1.Controls.Add(this.txtkategori);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.txtdeskripsi);
            this.panel1.Location = new System.Drawing.Point(942, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 336);
            this.panel1.TabIndex = 11;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(129, 110);
            this.txtharga.Margin = new System.Windows.Forms.Padding(4);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(132, 22);
            this.txtharga.TabIndex = 6;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(556, 477);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(145, 62);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(934, 31);
            this.srchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(100, 28);
            this.srchbtn.TabIndex = 7;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // txtnamesrch
            // 
            this.txtnamesrch.Location = new System.Drawing.Point(324, 34);
            this.txtnamesrch.Margin = new System.Windows.Forms.Padding(4);
            this.txtnamesrch.Name = "txtnamesrch";
            this.txtnamesrch.Size = new System.Drawing.Size(448, 22);
            this.txtnamesrch.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(460, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Search By Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 578);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnamesrch);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnsave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtdeskripsi;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox txtnamesrch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtharga;
    }
}

