namespace StudentDatabase
{
    partial class EditData
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
            this.labelStudentRollNo = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.LabelSubjectName = new System.Windows.Forms.Label();
            this.labelSubjectMark = new System.Windows.Forms.Label();
            this.textBoxRollNo = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxSubName = new System.Windows.Forms.TextBox();
            this.textBoxSubMark = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudentRollNo
            // 
            this.labelStudentRollNo.AutoSize = true;
            this.labelStudentRollNo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentRollNo.Location = new System.Drawing.Point(30, 37);
            this.labelStudentRollNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentRollNo.Name = "labelStudentRollNo";
            this.labelStudentRollNo.Size = new System.Drawing.Size(118, 23);
            this.labelStudentRollNo.TabIndex = 0;
            this.labelStudentRollNo.Text = "StudentRollNo";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.Location = new System.Drawing.Point(30, 91);
            this.labelStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(108, 23);
            this.labelStudentName.TabIndex = 1;
            this.labelStudentName.Text = "StudentName";
            // 
            // LabelSubjectName
            // 
            this.LabelSubjectName.AutoSize = true;
            this.LabelSubjectName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubjectName.Location = new System.Drawing.Point(30, 148);
            this.LabelSubjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSubjectName.Name = "LabelSubjectName";
            this.LabelSubjectName.Size = new System.Drawing.Size(108, 23);
            this.LabelSubjectName.TabIndex = 2;
            this.LabelSubjectName.Text = "SubjectName";
            // 
            // labelSubjectMark
            // 
            this.labelSubjectMark.AutoSize = true;
            this.labelSubjectMark.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectMark.Location = new System.Drawing.Point(30, 205);
            this.labelSubjectMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubjectMark.Name = "labelSubjectMark";
            this.labelSubjectMark.Size = new System.Drawing.Size(108, 23);
            this.labelSubjectMark.TabIndex = 3;
            this.labelSubjectMark.Text = "SubjectMark";
            // 
            // textBoxRollNo
            // 
            this.textBoxRollNo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRollNo.Location = new System.Drawing.Point(184, 35);
            this.textBoxRollNo.Name = "textBoxRollNo";
            this.textBoxRollNo.ReadOnly = true;
            this.textBoxRollNo.Size = new System.Drawing.Size(128, 30);
            this.textBoxRollNo.TabIndex = 4;
            this.textBoxRollNo.TextChanged += new System.EventHandler(this.textBoxRollNo_TextChanged);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentName.Location = new System.Drawing.Point(184, 84);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.ReadOnly = true;
            this.textBoxStudentName.Size = new System.Drawing.Size(128, 30);
            this.textBoxStudentName.TabIndex = 5;
            // 
            // textBoxSubName
            // 
            this.textBoxSubName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubName.Location = new System.Drawing.Point(184, 145);
            this.textBoxSubName.Name = "textBoxSubName";
            this.textBoxSubName.ReadOnly = true;
            this.textBoxSubName.Size = new System.Drawing.Size(128, 30);
            this.textBoxSubName.TabIndex = 6;
            // 
            // textBoxSubMark
            // 
            this.textBoxSubMark.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubMark.Location = new System.Drawing.Point(184, 202);
            this.textBoxSubMark.Name = "textBoxSubMark";
            this.textBoxSubMark.Size = new System.Drawing.Size(128, 30);
            this.textBoxSubMark.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(58, 282);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 33);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(195, 282);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 33);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 344);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSubMark);
            this.Controls.Add(this.textBoxSubName);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.textBoxRollNo);
            this.Controls.Add(this.labelSubjectMark);
            this.Controls.Add(this.LabelSubjectName);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.labelStudentRollNo);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditData";
            this.Load += new System.EventHandler(this.EditData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentRollNo;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label LabelSubjectName;
        private System.Windows.Forms.Label labelSubjectMark;
        private System.Windows.Forms.TextBox textBoxRollNo;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxSubName;
        private System.Windows.Forms.TextBox textBoxSubMark;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
    }
}