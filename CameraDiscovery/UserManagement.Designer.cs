namespace Parking
{
    partial class UserManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotorNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMotorNum = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1945, 520);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1099, 13);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(355, 53);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1015, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1032, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1099, 85);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(355, 53);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1006, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã số";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(1099, 159);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(355, 53);
            this.txtFirstName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(964, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Biển số xe";
            // 
            // txtMotorNum
            // 
            this.txtMotorNum.Location = new System.Drawing.Point(1099, 313);
            this.txtMotorNum.Multiline = true;
            this.txtMotorNum.Name = "txtMotorNum";
            this.txtMotorNum.Size = new System.Drawing.Size(355, 53);
            this.txtMotorNum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ảnh nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 316);
            this.panel1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1516, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 87);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(971, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bộ phận:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(1099, 233);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(355, 53);
            this.txtDepartment.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(410, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Họ:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(410, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(71, 25);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Mã số";
            // 
            // lblMotorNum
            // 
            this.lblMotorNum.AutoSize = true;
            this.lblMotorNum.Location = new System.Drawing.Point(410, 254);
            this.lblMotorNum.Name = "lblMotorNum";
            this.lblMotorNum.Size = new System.Drawing.Size(113, 25);
            this.lblMotorNum.TabIndex = 9;
            this.lblMotorNum.Text = "Biển số xe";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(410, 174);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(98, 25);
            this.lblDepartment.TabIndex = 13;
            this.lblDepartment.Text = "Bộ phận:";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1969, 962);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMotorNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMotorNum);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserManagement_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotorNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMotorNum;
        private System.Windows.Forms.Label lblDepartment;
    }
}