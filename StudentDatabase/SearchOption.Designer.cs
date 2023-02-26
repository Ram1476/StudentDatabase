namespace StudentDatabase
{
    partial class SearchOption
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblstRollNo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.txtStRollNo = new System.Windows.Forms.TextBox();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(163, 272);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(103, 45);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdName.Location = new System.Drawing.Point(84, 56);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(150, 26);
            this.lblStdName.TabIndex = 1;
            this.lblStdName.Text = "StudentName : ";
            // 
            // lblstRollNo
            // 
            this.lblstRollNo.AutoSize = true;
            this.lblstRollNo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstRollNo.Location = new System.Drawing.Point(84, 116);
            this.lblstRollNo.Name = "lblstRollNo";
            this.lblstRollNo.Size = new System.Drawing.Size(157, 26);
            this.lblstRollNo.TabIndex = 2;
            this.lblstRollNo.Text = "StudentRollNo : ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(84, 178);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(150, 26);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "SubjectName : ";
            // 
            // txtStName
            // 
            this.txtStName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStName.Location = new System.Drawing.Point(268, 52);
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(149, 30);
            this.txtStName.TabIndex = 4;
            // 
            // txtStRollNo
            // 
            this.txtStRollNo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStRollNo.Location = new System.Drawing.Point(268, 112);
            this.txtStRollNo.Name = "txtStRollNo";
            this.txtStRollNo.Size = new System.Drawing.Size(149, 30);
            this.txtStRollNo.TabIndex = 5;
            // 
            // txtSubName
            // 
            this.txtSubName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName.Location = new System.Drawing.Point(268, 174);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(149, 30);
            this.txtSubName.TabIndex = 6;
            // 
            // SearchOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.txtStRollNo);
            this.Controls.Add(this.txtStName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblstRollNo);
            this.Controls.Add(this.lblStdName);
            this.Controls.Add(this.btnsearch);
            this.Name = "SearchOption";
            this.Text = "SearchOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblstRollNo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.TextBox txtStRollNo;
        private System.Windows.Forms.TextBox txtSubName;
    }
}