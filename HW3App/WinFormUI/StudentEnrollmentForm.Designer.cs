namespace WinFormUI
{
    partial class StudentEnrollmentForm
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
            this.btnDeleteEnrollment = new System.Windows.Forms.Button();
            this.btnUpdateEnrollment = new System.Windows.Forms.Button();
            this.btnGetEnrollment = new System.Windows.Forms.Button();
            this.btnAddEnrollment = new System.Windows.Forms.Button();
            this.txtEnrollmentDate = new System.Windows.Forms.TextBox();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(191, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 447);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnDeleteEnrollment
            // 
            this.btnDeleteEnrollment.Location = new System.Drawing.Point(854, 120);
            this.btnDeleteEnrollment.Name = "btnDeleteEnrollment";
            this.btnDeleteEnrollment.Size = new System.Drawing.Size(250, 45);
            this.btnDeleteEnrollment.TabIndex = 31;
            this.btnDeleteEnrollment.Text = "Delete Enrollment";
            this.btnDeleteEnrollment.UseVisualStyleBackColor = true;
            this.btnDeleteEnrollment.Click += new System.EventHandler(this.btnDeleteEnrollment_Click);
            // 
            // btnUpdateEnrollment
            // 
            this.btnUpdateEnrollment.Location = new System.Drawing.Point(556, 295);
            this.btnUpdateEnrollment.Name = "btnUpdateEnrollment";
            this.btnUpdateEnrollment.Size = new System.Drawing.Size(250, 45);
            this.btnUpdateEnrollment.TabIndex = 30;
            this.btnUpdateEnrollment.Text = "Update Enrollment";
            this.btnUpdateEnrollment.UseVisualStyleBackColor = true;
            this.btnUpdateEnrollment.Click += new System.EventHandler(this.btnUpdateEnrollment_Click);
            // 
            // btnGetEnrollment
            // 
            this.btnGetEnrollment.Location = new System.Drawing.Point(556, 204);
            this.btnGetEnrollment.Name = "btnGetEnrollment";
            this.btnGetEnrollment.Size = new System.Drawing.Size(250, 45);
            this.btnGetEnrollment.TabIndex = 29;
            this.btnGetEnrollment.Text = "Get Enrollment";
            this.btnGetEnrollment.UseVisualStyleBackColor = true;
            this.btnGetEnrollment.Click += new System.EventHandler(this.btnGetEnrollment_Click);
            // 
            // btnAddEnrollment
            // 
            this.btnAddEnrollment.Location = new System.Drawing.Point(556, 120);
            this.btnAddEnrollment.Name = "btnAddEnrollment";
            this.btnAddEnrollment.Size = new System.Drawing.Size(250, 45);
            this.btnAddEnrollment.TabIndex = 28;
            this.btnAddEnrollment.Text = "Add Enrollment";
            this.btnAddEnrollment.UseVisualStyleBackColor = true;
            this.btnAddEnrollment.Click += new System.EventHandler(this.btnAddEnrollment_Click);
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.Location = new System.Drawing.Point(332, 287);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.Size = new System.Drawing.Size(100, 31);
            this.txtEnrollmentDate.TabIndex = 27;
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(332, 197);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(100, 31);
            this.txtCourseId.TabIndex = 26;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(332, 120);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 31);
            this.txtStudentId.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Enrollment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Developed by Thiha Aung";
            // 
            // StudentEnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 931);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteEnrollment);
            this.Controls.Add(this.btnUpdateEnrollment);
            this.Controls.Add(this.btnGetEnrollment);
            this.Controls.Add(this.btnAddEnrollment);
            this.Controls.Add(this.txtEnrollmentDate);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentEnrollmentForm";
            this.Text = "StudentEnrollmentForm";
            this.Load += new System.EventHandler(this.StudentEnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteEnrollment;
        private System.Windows.Forms.Button btnUpdateEnrollment;
        private System.Windows.Forms.Button btnGetEnrollment;
        private System.Windows.Forms.Button btnAddEnrollment;
        private System.Windows.Forms.TextBox txtEnrollmentDate;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}