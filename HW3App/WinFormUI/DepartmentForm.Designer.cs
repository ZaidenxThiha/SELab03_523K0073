namespace WinFormUI
{
    partial class DepartmentForm
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
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnGetDepartment = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Location = new System.Drawing.Point(210, 44);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(100, 31);
            this.txtDepartmentId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 4;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(434, 44);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(250, 45);
            this.btnAddDepartment.TabIndex = 6;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnGetDepartment
            // 
            this.btnGetDepartment.Location = new System.Drawing.Point(434, 128);
            this.btnGetDepartment.Name = "btnGetDepartment";
            this.btnGetDepartment.Size = new System.Drawing.Size(250, 45);
            this.btnGetDepartment.TabIndex = 7;
            this.btnGetDepartment.Text = "Get Department";
            this.btnGetDepartment.UseVisualStyleBackColor = true;
            this.btnGetDepartment.Click += new System.EventHandler(this.btnGetDepartment_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(434, 219);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(250, 45);
            this.btnUpdateDepartment.TabIndex = 8;
            this.btnUpdateDepartment.Text = "Update Department";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(732, 44);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(250, 45);
            this.btnDeleteDepartment.TabIndex = 9;
            this.btnDeleteDepartment.Text = "Delete Department";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 447);
            this.dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Developed by Thiha Aung";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 765);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnUpdateDepartment);
            this.Controls.Add(this.btnGetDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDepartmentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnGetDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}