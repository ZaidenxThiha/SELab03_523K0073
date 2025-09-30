namespace WinFormUI
{
    partial class InstructorForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteInstructor = new System.Windows.Forms.Button();
            this.btnUpdateInstructor = new System.Windows.Forms.Button();
            this.btnGetInstructor = new System.Windows.Forms.Button();
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInstructorId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 447);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnDeleteInstructor
            // 
            this.btnDeleteInstructor.Location = new System.Drawing.Point(746, 107);
            this.btnDeleteInstructor.Name = "btnDeleteInstructor";
            this.btnDeleteInstructor.Size = new System.Drawing.Size(250, 45);
            this.btnDeleteInstructor.TabIndex = 31;
            this.btnDeleteInstructor.Text = "Delete Instructor";
            this.btnDeleteInstructor.UseVisualStyleBackColor = true;
            this.btnDeleteInstructor.Click += new System.EventHandler(this.btnDeleteInstructor_Click);
            // 
            // btnUpdateInstructor
            // 
            this.btnUpdateInstructor.Location = new System.Drawing.Point(448, 282);
            this.btnUpdateInstructor.Name = "btnUpdateInstructor";
            this.btnUpdateInstructor.Size = new System.Drawing.Size(250, 45);
            this.btnUpdateInstructor.TabIndex = 30;
            this.btnUpdateInstructor.Text = "Update Instructor";
            this.btnUpdateInstructor.UseVisualStyleBackColor = true;
            this.btnUpdateInstructor.Click += new System.EventHandler(this.btnUpdateInstructor_Click);
            // 
            // btnGetInstructor
            // 
            this.btnGetInstructor.Location = new System.Drawing.Point(448, 191);
            this.btnGetInstructor.Name = "btnGetInstructor";
            this.btnGetInstructor.Size = new System.Drawing.Size(250, 45);
            this.btnGetInstructor.TabIndex = 29;
            this.btnGetInstructor.Text = "Get Instructor";
            this.btnGetInstructor.UseVisualStyleBackColor = true;
            this.btnGetInstructor.Click += new System.EventHandler(this.btnGetInstructor_Click);
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.Location = new System.Drawing.Point(448, 107);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(250, 45);
            this.btnAddInstructor.TabIndex = 28;
            this.btnAddInstructor.Text = "Add Instructor";
            this.btnAddInstructor.UseVisualStyleBackColor = true;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Location = new System.Drawing.Point(224, 274);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(100, 31);
            this.txtDepartmentId.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(224, 184);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 26;
            // 
            // txtInstructorId
            // 
            this.txtInstructorId.Location = new System.Drawing.Point(224, 107);
            this.txtInstructorId.Name = "txtInstructorId";
            this.txtInstructorId.Size = new System.Drawing.Size(100, 31);
            this.txtInstructorId.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Department ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Instructor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Developed by Thiha Aung";
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 904);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteInstructor);
            this.Controls.Add(this.btnUpdateInstructor);
            this.Controls.Add(this.btnGetInstructor);
            this.Controls.Add(this.btnAddInstructor);
            this.Controls.Add(this.txtDepartmentId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInstructorId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteInstructor;
        private System.Windows.Forms.Button btnUpdateInstructor;
        private System.Windows.Forms.Button btnGetInstructor;
        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInstructorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}