namespace GiaoDien.DonVi
{
    partial class DonVi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_DonVi = new System.Windows.Forms.DataGridView();
            this.lb_MaDonVi = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TenDonVi = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonVi)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 100);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 65);
            this.panel2.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_DonVi);
            this.panel3.Location = new System.Drawing.Point(12, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 289);
            this.panel3.TabIndex = 2;
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
            // lb_MaDonVi
            // 
            this.lb_MaDonVi.AutoSize = true;
            this.lb_MaDonVi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDonVi.Location = new System.Drawing.Point(150, 24);
            this.lb_MaDonVi.Name = "lb_MaDonVi";
            this.lb_MaDonVi.Size = new System.Drawing.Size(94, 23);
            this.lb_MaDonVi.TabIndex = 23;
            this.lb_MaDonVi.Text = "Mã đơn vị";
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
            // lb_TenDonVi
            // 
            this.lb_TenDonVi.AutoSize = true;
            this.lb_TenDonVi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDonVi.Location = new System.Drawing.Point(150, 86);
            this.lb_TenDonVi.Name = "lb_TenDonVi";
            this.lb_TenDonVi.Size = new System.Drawing.Size(98, 23);
            this.lb_TenDonVi.TabIndex = 23;
            this.lb_TenDonVi.Text = "Tên đơn vị";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_1);
            this.panel4.Controls.Add(this.lb_TenDonVi);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lb_MaDonVi);
            this.panel4.Location = new System.Drawing.Point(577, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 151);
            this.panel4.TabIndex = 24;
            // 
            // DonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 487);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonVi";
            this.Load += new System.EventHandler(this.DonVi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonVi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_DonVi;
        private System.Windows.Forms.Label lb_MaDonVi;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_TenDonVi;
        private System.Windows.Forms.Panel panel4;
    }
}