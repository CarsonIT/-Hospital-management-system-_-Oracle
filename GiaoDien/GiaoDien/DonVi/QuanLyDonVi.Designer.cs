namespace GiaoDien.DonVi
{
    partial class QuanLyDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDonVi));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_DonVi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaDonVi = new System.Windows.Forms.TextBox();
            this.txt_TenDonVi = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Update_ChamCong = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonVi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_TenDonVi);
            this.panel4.Controls.Add(this.txt_MaDonVi);
            this.panel4.Controls.Add(this.lb_1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(661, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 151);
            this.panel4.TabIndex = 28;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(43, 24);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(101, 23);
            this.lb_1.TabIndex = 22;
            this.lb_1.Text = "Mã đơn vị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên đơn vị:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_DonVi);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 289);
            this.panel3.TabIndex = 27;
            // 
            // dgv_DonVi
            // 
            this.dgv_DonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonVi.Location = new System.Drawing.Point(16, 23);
            this.dgv_DonVi.Name = "dgv_DonVi";
            this.dgv_DonVi.RowHeadersWidth = 51;
            this.dgv_DonVi.RowTemplate.Height = 24;
            this.dgv_DonVi.Size = new System.Drawing.Size(483, 238);
            this.dgv_DonVi.TabIndex = 0;
            this.dgv_DonVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DonVi_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 65);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(405, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "ĐƠN VỊ BỆNH VIỆN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 100);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 51);
            this.label1.TabIndex = 47;
            this.label1.Text = "Hospital Centre Management";
            // 
            // txt_MaDonVi
            // 
            this.txt_MaDonVi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDonVi.Location = new System.Drawing.Point(154, 17);
            this.txt_MaDonVi.Name = "txt_MaDonVi";
            this.txt_MaDonVi.Size = new System.Drawing.Size(112, 30);
            this.txt_MaDonVi.TabIndex = 23;
            // 
            // txt_TenDonVi
            // 
            this.txt_TenDonVi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDonVi.Location = new System.Drawing.Point(154, 79);
            this.txt_TenDonVi.Name = "txt_TenDonVi";
            this.txt_TenDonVi.Size = new System.Drawing.Size(442, 30);
            this.txt_TenDonVi.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Update_ChamCong);
            this.panel8.Controls.Add(this.btn_Delete);
            this.panel8.Controls.Add(this.btn_Add);
            this.panel8.Location = new System.Drawing.Point(563, 364);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(694, 109);
            this.panel8.TabIndex = 50;
            // 
            // btn_Update_ChamCong
            // 
            this.btn_Update_ChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_Update_ChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_ChamCong.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_ChamCong.ForeColor = System.Drawing.Color.White;
            this.btn_Update_ChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update_ChamCong.Image")));
            this.btn_Update_ChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update_ChamCong.Location = new System.Drawing.Point(244, 26);
            this.btn_Update_ChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update_ChamCong.Name = "btn_Update_ChamCong";
            this.btn_Update_ChamCong.Size = new System.Drawing.Size(207, 57);
            this.btn_Update_ChamCong.TabIndex = 48;
            this.btn_Update_ChamCong.Text = "Update";
            this.btn_Update_ChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update_ChamCong.UseVisualStyleBackColor = false;
            this.btn_Update_ChamCong.Click += new System.EventHandler(this.btn_Update_ChamCong_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(475, 26);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(207, 57);
            this.btn_Delete.TabIndex = 47;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(10, 26);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(207, 57);
            this.btn_Add.TabIndex = 47;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // QuanLyDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 487);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDonVi";
            this.Load += new System.EventHandler(this.QuanLyDonVi_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonVi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_DonVi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenDonVi;
        private System.Windows.Forms.TextBox txt_MaDonVi;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_Update_ChamCong;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
    }
}