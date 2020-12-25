namespace Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tNIM = new System.Windows.Forms.TextBox();
            this.TNama = new System.Windows.Forms.TextBox();
            this.TProdi = new System.Windows.Forms.TextBox();
            this.TAngkatan = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.blihat = new System.Windows.Forms.Button();
            this.bSearchnim = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bTotal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angkatan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tNIM
            // 
            this.tNIM.Location = new System.Drawing.Point(258, 93);
            this.tNIM.Name = "tNIM";
            this.tNIM.Size = new System.Drawing.Size(100, 20);
            this.tNIM.TabIndex = 5;
            // 
            // TNama
            // 
            this.TNama.Location = new System.Drawing.Point(258, 140);
            this.TNama.Name = "TNama";
            this.TNama.Size = new System.Drawing.Size(100, 20);
            this.TNama.TabIndex = 6;
            // 
            // TProdi
            // 
            this.TProdi.Location = new System.Drawing.Point(258, 190);
            this.TProdi.Name = "TProdi";
            this.TProdi.Size = new System.Drawing.Size(100, 20);
            this.TProdi.TabIndex = 7;
            // 
            // TAngkatan
            // 
            this.TAngkatan.Location = new System.Drawing.Point(258, 248);
            this.TAngkatan.Name = "TAngkatan";
            this.TAngkatan.Size = new System.Drawing.Size(100, 20);
            this.TAngkatan.TabIndex = 8;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(395, 90);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 9;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // blihat
            // 
            this.blihat.Location = new System.Drawing.Point(485, 90);
            this.blihat.Name = "blihat";
            this.blihat.Size = new System.Drawing.Size(75, 23);
            this.blihat.TabIndex = 10;
            this.blihat.Text = "Lihat Data";
            this.blihat.UseVisualStyleBackColor = true;
            this.blihat.Click += new System.EventHandler(this.blihat_Click);
            // 
            // bSearchnim
            // 
            this.bSearchnim.Location = new System.Drawing.Point(395, 138);
            this.bSearchnim.Name = "bSearchnim";
            this.bSearchnim.Size = new System.Drawing.Size(75, 23);
            this.bSearchnim.TabIndex = 11;
            this.bSearchnim.Text = "Search";
            this.bSearchnim.UseVisualStyleBackColor = true;
            this.bSearchnim.Click += new System.EventHandler(this.bSearchnim_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(485, 143);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 12;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(395, 187);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bTotal
            // 
            this.bTotal.Location = new System.Drawing.Point(395, 236);
            this.bTotal.Name = "bTotal";
            this.bTotal.Size = new System.Drawing.Size(75, 23);
            this.bTotal.TabIndex = 14;
            this.bTotal.Text = "Jumlah Data";
            this.bTotal.UseVisualStyleBackColor = true;
            this.bTotal.Click += new System.EventHandler(this.bTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Jumlah Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Informasi Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bTotal);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSearchnim);
            this.Controls.Add(this.blihat);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.TAngkatan);
            this.Controls.Add(this.TProdi);
            this.Controls.Add(this.TNama);
            this.Controls.Add(this.tNIM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tNIM;
        private System.Windows.Forms.TextBox TNama;
        private System.Windows.Forms.TextBox TProdi;
        private System.Windows.Forms.TextBox TAngkatan;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button blihat;
        private System.Windows.Forms.Button bSearchnim;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

