namespace GiaoDien
{
    partial class Drop_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drop_User));
            this.dgv_in_DropUser = new System.Windows.Forms.DataGridView();
            this.pnVienDuoi = new System.Windows.Forms.Panel();
            this.txt_drop_nameuser = new System.Windows.Forms.TextBox();
            this.lb_username_drop = new System.Windows.Forms.Label();
            this.btnCancelDrop = new System.Windows.Forms.Button();
            this.btnSaveDrop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_user_txt1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn_InDrop = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_DropUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_in_DropUser
            // 
            this.dgv_in_DropUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_in_DropUser.Location = new System.Drawing.Point(454, 112);
            this.dgv_in_DropUser.Name = "dgv_in_DropUser";
            this.dgv_in_DropUser.RowHeadersWidth = 51;
            this.dgv_in_DropUser.RowTemplate.Height = 24;
            this.dgv_in_DropUser.Size = new System.Drawing.Size(724, 430);
            this.dgv_in_DropUser.TabIndex = 0;
            this.dgv_in_DropUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_in_DropUser_CellContentClick);
            this.dgv_in_DropUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_in_DropUser_CellDoubleClick);
            // 
            // pnVienDuoi
            // 
            this.pnVienDuoi.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnVienDuoi.Location = new System.Drawing.Point(112, 149);
            this.pnVienDuoi.Name = "pnVienDuoi";
            this.pnVienDuoi.Size = new System.Drawing.Size(204, 3);
            this.pnVienDuoi.TabIndex = 12;
            // 
            // txt_drop_nameuser
            // 
            this.txt_drop_nameuser.BackColor = System.Drawing.SystemColors.Window;
            this.txt_drop_nameuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_drop_nameuser.Location = new System.Drawing.Point(115, 127);
            this.txt_drop_nameuser.Name = "txt_drop_nameuser";
            this.txt_drop_nameuser.Size = new System.Drawing.Size(193, 25);
            this.txt_drop_nameuser.TabIndex = 11;
            // 
            // lb_username_drop
            // 
            this.lb_username_drop.AutoSize = true;
            this.lb_username_drop.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username_drop.ForeColor = System.Drawing.Color.Crimson;
            this.lb_username_drop.Location = new System.Drawing.Point(113, 101);
            this.lb_username_drop.Name = "lb_username_drop";
            this.lb_username_drop.Size = new System.Drawing.Size(114, 23);
            this.lb_username_drop.TabIndex = 10;
            this.lb_username_drop.Text = "Username:";
            // 
            // btnCancelDrop
            // 
            this.btnCancelDrop.BackColor = System.Drawing.Color.Navy;
            this.btnCancelDrop.FlatAppearance.BorderSize = 0;
            this.btnCancelDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDrop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDrop.ForeColor = System.Drawing.Color.White;
            this.btnCancelDrop.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDrop.Image")));
            this.btnCancelDrop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelDrop.Location = new System.Drawing.Point(248, 230);
            this.btnCancelDrop.Name = "btnCancelDrop";
            this.btnCancelDrop.Size = new System.Drawing.Size(136, 48);
            this.btnCancelDrop.TabIndex = 14;
            this.btnCancelDrop.Text = "Cancel";
            this.btnCancelDrop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelDrop.UseVisualStyleBackColor = false;
            this.btnCancelDrop.Click += new System.EventHandler(this.btnCancelDrop_Click);
            // 
            // btnSaveDrop
            // 
            this.btnSaveDrop.BackColor = System.Drawing.Color.Brown;
            this.btnSaveDrop.FlatAppearance.BorderSize = 0;
            this.btnSaveDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDrop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDrop.ForeColor = System.Drawing.Color.White;
            this.btnSaveDrop.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDrop.Image")));
            this.btnSaveDrop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDrop.Location = new System.Drawing.Point(49, 230);
            this.btnSaveDrop.Name = "btnSaveDrop";
            this.btnSaveDrop.Size = new System.Drawing.Size(136, 48);
            this.btnSaveDrop.TabIndex = 13;
            this.btnSaveDrop.Text = "Drop";
            this.btnSaveDrop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDrop.UseVisualStyleBackColor = false;
            this.btnSaveDrop.Click += new System.EventHandler(this.btnSaveDrop_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.list_user_txt1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(454, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 40);
            this.panel1.TabIndex = 15;
            // 
            // list_user_txt1
            // 
            this.list_user_txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.list_user_txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_user_txt1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_user_txt1.ForeColor = System.Drawing.Color.White;
            this.list_user_txt1.Location = new System.Drawing.Point(93, 8);
            this.list_user_txt1.Name = "list_user_txt1";
            this.list_user_txt1.Size = new System.Drawing.Size(100, 29);
            this.list_user_txt1.TabIndex = 10;
            this.list_user_txt1.Text = "Users List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn_InDrop
            // 
            this.btnReturn_InDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnReturn_InDrop.FlatAppearance.BorderSize = 0;
            this.btnReturn_InDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn_InDrop.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn_InDrop.Image")));
            this.btnReturn_InDrop.Location = new System.Drawing.Point(1, 2);
            this.btnReturn_InDrop.Name = "btnReturn_InDrop";
            this.btnReturn_InDrop.Size = new System.Drawing.Size(56, 42);
            this.btnReturn_InDrop.TabIndex = 16;
            this.btnReturn_InDrop.UseVisualStyleBackColor = false;
            this.btnReturn_InDrop.Click += new System.EventHandler(this.btnReturn_InDrop_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1185, 62);
            this.panel3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(539, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 44);
            this.label4.TabIndex = 4;
            this.label4.Text = "Drop User";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 53);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Drop_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnReturn_InDrop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelDrop);
            this.Controls.Add(this.btnSaveDrop);
            this.Controls.Add(this.pnVienDuoi);
            this.Controls.Add(this.txt_drop_nameuser);
            this.Controls.Add(this.lb_username_drop);
            this.Controls.Add(this.dgv_in_DropUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Drop_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drop_User";
            this.Load += new System.EventHandler(this.Drop_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_in_DropUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_in_DropUser;
        private System.Windows.Forms.Panel pnVienDuoi;
        private System.Windows.Forms.TextBox txt_drop_nameuser;
        private System.Windows.Forms.Label lb_username_drop;
        private System.Windows.Forms.Button btnCancelDrop;
        private System.Windows.Forms.Button btnSaveDrop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox list_user_txt1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn_InDrop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}