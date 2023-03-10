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
            this.components = new System.ComponentModel.Container();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblstRollNo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.txtStRollNo = new System.Windows.Forms.TextBox();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.displayGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsRecordDataSet = new StudentDatabase.StudentsRecordDataSet();
            this.studentMarksTableAdapter = new StudentDatabase.StudentsRecordDataSetTableAdapters.studentMarksTableAdapter();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(437, 98);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(138, 63);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStdName.Location = new System.Drawing.Point(6, 24);
            this.lblStdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(201, 35);
            this.lblStdName.TabIndex = 1;
            this.lblStdName.Text = "StudentName : ";
            // 
            // lblstRollNo
            // 
            this.lblstRollNo.AutoSize = true;
            this.lblstRollNo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstRollNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblstRollNo.Location = new System.Drawing.Point(408, 24);
            this.lblstRollNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstRollNo.Name = "lblstRollNo";
            this.lblstRollNo.Size = new System.Drawing.Size(211, 35);
            this.lblstRollNo.TabIndex = 2;
            this.lblstRollNo.Text = "StudentRollNo : ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubject.Location = new System.Drawing.Point(6, 98);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(199, 35);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "SubjectName : ";
            // 
            // txtStName
            // 
            this.txtStName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStName.Location = new System.Drawing.Point(193, 24);
            this.txtStName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(198, 34);
            this.txtStName.TabIndex = 4;
            // 
            // txtStRollNo
            // 
            this.txtStRollNo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStRollNo.Location = new System.Drawing.Point(627, 24);
            this.txtStRollNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtStRollNo.Name = "txtStRollNo";
            this.txtStRollNo.Size = new System.Drawing.Size(198, 34);
            this.txtStRollNo.TabIndex = 5;
            this.txtStRollNo.TextChanged += new System.EventHandler(this.txtStRollNo_TextChanged);
            // 
            // txtSubName
            // 
            this.txtSubName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName.Location = new System.Drawing.Point(193, 98);
            this.txtSubName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(198, 34);
            this.txtSubName.TabIndex = 6;
            // 
            // displayGrid
            // 
            this.displayGrid.AutoGenerateColumns = false;
            this.displayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.studentRollNoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.subjectMarksDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.displayGrid.DataSource = this.studentMarksBindingSource;
            this.displayGrid.Location = new System.Drawing.Point(78, 194);
            this.displayGrid.Name = "displayGrid";
            this.displayGrid.Size = new System.Drawing.Size(747, 197);
            this.displayGrid.TabIndex = 7;
            this.displayGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // studentRollNoDataGridViewTextBoxColumn
            // 
            this.studentRollNoDataGridViewTextBoxColumn.DataPropertyName = "StudentRollNo";
            this.studentRollNoDataGridViewTextBoxColumn.HeaderText = "StudentRollNo";
            this.studentRollNoDataGridViewTextBoxColumn.Name = "studentRollNoDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "studentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "studentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "subjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "subjectName";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            // 
            // subjectMarksDataGridViewTextBoxColumn
            // 
            this.subjectMarksDataGridViewTextBoxColumn.DataPropertyName = "SubjectMarks";
            this.subjectMarksDataGridViewTextBoxColumn.HeaderText = "SubjectMarks";
            this.subjectMarksDataGridViewTextBoxColumn.Name = "subjectMarksDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // studentMarksBindingSource
            // 
            this.studentMarksBindingSource.DataMember = "studentMarks";
            this.studentMarksBindingSource.DataSource = this.studentsRecordDataSet;
            // 
            // studentsRecordDataSet
            // 
            this.studentsRecordDataSet.DataSetName = "StudentsRecordDataSet";
            this.studentsRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentMarksTableAdapter
            // 
            this.studentMarksTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(128, 433);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(111, 35);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(323, 433);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(111, 35);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewAll.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.Location = new System.Drawing.Point(627, 98);
            this.buttonViewAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(138, 63);
            this.buttonViewAll.TabIndex = 10;
            this.buttonViewAll.Text = "ViewAll";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click_1);
            // 
            // SearchOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(954, 597);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.displayGrid);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.txtStRollNo);
            this.Controls.Add(this.txtStName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblstRollNo);
            this.Controls.Add(this.lblStdName);
            this.Controls.Add(this.btnsearch);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchOption";
            this.Activated += new System.EventHandler(this.SearchOp_Activated);
            this.Load += new System.EventHandler(this.SearchOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsRecordDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView displayGrid;
        private StudentsRecordDataSet studentsRecordDataSet;
        private System.Windows.Forms.BindingSource studentMarksBindingSource;
        private StudentsRecordDataSetTableAdapters.studentMarksTableAdapter studentMarksTableAdapter;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button buttonViewAll;
    }
}