namespace GiaoDien
{
    partial class Grant_Role
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grant_Role));
            this.tabGrantRole = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonGrant = new System.Windows.Forms.Button();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.tabSystemPrivileges = new System.Windows.Forms.TabPage();
            this.dgvSysPri = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGrantSelect = new System.Windows.Forms.Button();
            this.buttonGrantUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.dgvCol = new System.Windows.Forms.DataGridView();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.buttonApply = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabGrantRole.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabSystemPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysPri)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGrantRole
            // 
            this.tabGrantRole.Controls.Add(this.tabPage3);
            this.tabGrantRole.Controls.Add(this.tabSystemPrivileges);
            this.tabGrantRole.Controls.Add(this.tabPage1);
            this.tabGrantRole.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGrantRole.Location = new System.Drawing.Point(-1, 73);
            this.tabGrantRole.Margin = new System.Windows.Forms.Padding(4);
            this.tabGrantRole.Name = "tabGrantRole";
            this.tabGrantRole.SelectedIndex = 0;
            this.tabGrantRole.Size = new System.Drawing.Size(1364, 535);
            this.tabGrantRole.TabIndex = 0;
            this.tabGrantRole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabGrantRole_MouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.buttonGrant);
            this.tabPage3.Controls.Add(this.dgvRole);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1356, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grant Roles";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // buttonGrant
            // 
            this.buttonGrant.Location = new System.Drawing.Point(158, 565);
            this.buttonGrant.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrant.Name = "buttonGrant";
            this.buttonGrant.Size = new System.Drawing.Size(112, 33);
            this.buttonGrant.TabIndex = 1;
            this.buttonGrant.Text = "Granted";
            this.buttonGrant.UseVisualStyleBackColor = true;
            this.buttonGrant.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Location = new System.Drawing.Point(276, 97);
            this.dgvRole.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 51;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(813, 350);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellContentClick);
            // 
            // tabSystemPrivileges
            // 
            this.tabSystemPrivileges.Controls.Add(this.label2);
            this.tabSystemPrivileges.Controls.Add(this.dgvSysPri);
            this.tabSystemPrivileges.Location = new System.Drawing.Point(4, 36);
            this.tabSystemPrivileges.Margin = new System.Windows.Forms.Padding(4);
            this.tabSystemPrivileges.Name = "tabSystemPrivileges";
            this.tabSystemPrivileges.Padding = new System.Windows.Forms.Padding(4);
            this.tabSystemPrivileges.Size = new System.Drawing.Size(1356, 495);
            this.tabSystemPrivileges.TabIndex = 3;
            this.tabSystemPrivileges.Text = "System Privileges";
            this.tabSystemPrivileges.UseVisualStyleBackColor = true;
            // 
            // dgvSysPri
            // 
            this.dgvSysPri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysPri.Location = new System.Drawing.Point(267, 103);
            this.dgvSysPri.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSysPri.Name = "dgvSysPri";
            this.dgvSysPri.RowHeadersWidth = 51;
            this.dgvSysPri.RowTemplate.Height = 24;
            this.dgvSysPri.Size = new System.Drawing.Size(846, 342);
            this.dgvSysPri.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonGrantSelect);
            this.tabPage1.Controls.Add(this.buttonGrantUpdate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtTable);
            this.tabPage1.Controls.Add(this.dgvCol);
            this.tabPage1.Controls.Add(this.dgvTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1356, 495);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Object Privileges";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGrantSelect
            // 
            this.buttonGrantSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.buttonGrantSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrantSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrantSelect.ForeColor = System.Drawing.Color.White;
            this.buttonGrantSelect.Location = new System.Drawing.Point(903, 416);
            this.buttonGrantSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrantSelect.Name = "buttonGrantSelect";
            this.buttonGrantSelect.Size = new System.Drawing.Size(169, 65);
            this.buttonGrantSelect.TabIndex = 5;
            this.buttonGrantSelect.Text = "Grant Select";
            this.buttonGrantSelect.UseVisualStyleBackColor = false;
            this.buttonGrantSelect.Click += new System.EventHandler(this.buttonGrantSelect_Click);
            // 
            // buttonGrantUpdate
            // 
            this.buttonGrantUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.buttonGrantUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrantUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrantUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonGrantUpdate.Location = new System.Drawing.Point(1155, 416);
            this.buttonGrantUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrantUpdate.Name = "buttonGrantUpdate";
            this.buttonGrantUpdate.Size = new System.Drawing.Size(162, 65);
            this.buttonGrantUpdate.TabIndex = 4;
            this.buttonGrantUpdate.Text = "Grant Update";
            this.buttonGrantUpdate.UseVisualStyleBackColor = false;
            this.buttonGrantUpdate.Click += new System.EventHandler(this.buttonGrantUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(883, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "TABLE: ";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(987, 20);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(330, 36);
            this.txtTable.TabIndex = 2;
            // 
            // dgvCol
            // 
            this.dgvCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCol.Location = new System.Drawing.Point(879, 64);
            this.dgvCol.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCol.Name = "dgvCol";
            this.dgvCol.RowHeadersWidth = 51;
            this.dgvCol.RowTemplate.Height = 24;
            this.dgvCol.Size = new System.Drawing.Size(468, 329);
            this.dgvCol.TabIndex = 1;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(8, 64);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(818, 368);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(1009, 630);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(188, 61);
            this.buttonApply.TabIndex = 15;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1367, 10);
            this.panel8.TabIndex = 52;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1367, 56);
            this.panel5.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(692, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 34);
            this.label8.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label11.Location = new System.Drawing.Point(733, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 38);
            this.label11.TabIndex = 17;
            this.label11.Text = "GRANT ROLE";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Location = new System.Drawing.Point(6, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 50);
            this.panel6.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(332, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 41);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(21, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 32);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(543, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "GRANT ROLES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(529, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "SYSTEM PRIVILEGES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(237, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "OBJECT PRIVILEGES";
            // 
            // Grant_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 704);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.tabGrantRole);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grant_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant Role";
            this.tabGrantRole.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.tabSystemPrivileges.ResumeLayout(false);
            this.tabSystemPrivileges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysPri)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGrantRole;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabSystemPrivileges;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.Button buttonGrant;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvSysPri;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonGrantUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.DataGridView dgvCol;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button buttonGrantSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
    }
}