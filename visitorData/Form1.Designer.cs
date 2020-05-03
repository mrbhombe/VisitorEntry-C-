namespace visitorData
{
    partial class Form1
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
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tomeetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new visitorData.databaseDataSet();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.visitTableAdapter = new visitorData.databaseDataSetTableAdapters.visitTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.Filter = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(607, 303);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(100, 22);
            this.TextBox4.TabIndex = 45;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.arriveTimeDataGridViewTextBoxColumn,
            this.departTimeDataGridViewTextBoxColumn,
            this.datetoDataGridViewTextBoxColumn,
            this.tomeetDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.visitBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(49, 437);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(841, 167);
            this.DataGridView1.TabIndex = 43;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // arriveTimeDataGridViewTextBoxColumn
            // 
            this.arriveTimeDataGridViewTextBoxColumn.DataPropertyName = "arriveTime";
            this.arriveTimeDataGridViewTextBoxColumn.HeaderText = "arriveTime";
            this.arriveTimeDataGridViewTextBoxColumn.Name = "arriveTimeDataGridViewTextBoxColumn";
            // 
            // departTimeDataGridViewTextBoxColumn
            // 
            this.departTimeDataGridViewTextBoxColumn.DataPropertyName = "departTime";
            this.departTimeDataGridViewTextBoxColumn.HeaderText = "departTime";
            this.departTimeDataGridViewTextBoxColumn.Name = "departTimeDataGridViewTextBoxColumn";
            // 
            // datetoDataGridViewTextBoxColumn
            // 
            this.datetoDataGridViewTextBoxColumn.DataPropertyName = "dateto";
            this.datetoDataGridViewTextBoxColumn.HeaderText = "dateto";
            this.datetoDataGridViewTextBoxColumn.Name = "datetoDataGridViewTextBoxColumn";
            // 
            // tomeetDataGridViewTextBoxColumn
            // 
            this.tomeetDataGridViewTextBoxColumn.DataPropertyName = "tomeet";
            this.tomeetDataGridViewTextBoxColumn.HeaderText = "tomeet";
            this.tomeetDataGridViewTextBoxColumn.Name = "tomeetDataGridViewTextBoxColumn";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataMember = "visit";
            this.visitBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(564, 378);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 23);
            this.Button5.TabIndex = 42;
            this.Button5.Text = "View All";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(426, 378);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 41;
            this.Button4.Text = "Delete";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(466, 308);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(21, 17);
            this.Label9.TabIndex = 44;
            this.Label9.Text = "ID";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(299, 378);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 40;
            this.Button3.Text = "Update";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(171, 378);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 39;
            this.Button2.Text = "Insert";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(626, 211);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 38;
            this.Button1.Text = "Search";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(606, 117);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.DateTimePicker1.TabIndex = 34;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(198, 246);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(176, 22);
            this.TextBox3.TabIndex = 33;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(198, 184);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 22);
            this.TextBox2.TabIndex = 32;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(108, 214);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(173, 22);
            this.DateTimePicker2.TabIndex = 36;
            // 
            // DateTimePicker3
            // 
            this.DateTimePicker3.Location = new System.Drawing.Point(606, 241);
            this.DateTimePicker3.Name = "DateTimePicker3";
            this.DateTimePicker3.Size = new System.Drawing.Size(178, 22);
            this.DateTimePicker3.TabIndex = 37;
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(606, 180);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 24);
            this.ComboBox1.TabIndex = 35;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(198, 119);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(176, 22);
            this.TextBox1.TabIndex = 31;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(463, 246);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(107, 17);
            this.Label8.TabIndex = 30;
            this.Label8.Text = "Departure Time";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(463, 184);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 17);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "To Do";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(114, 305);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(91, 17);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "Arriving Time";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(463, 119);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(38, 17);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Date";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(120, 246);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(42, 17);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Email";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(115, 184);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 17);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Contact";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(116, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 17);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(384, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(126, 17);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Visitor\'s Log Entry ";
            // 
            // visitTableAdapter
            // 
            this.visitTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(766, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "--";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(256, 22);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 47;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Location = new System.Drawing.Point(156, 22);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(39, 17);
            this.Filter.TabIndex = 48;
            this.Filter.Text = "Filter";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(503, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 49;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(102, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 77);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button1);
            this.groupBox2.Controls.Add(this.DateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(102, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 259);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Book Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(102, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 59);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log Book Action";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Filter);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.dateTimePicker4);
            this.groupBox4.Location = new System.Drawing.Point(103, 610);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(704, 59);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log Book Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 705);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.DateTimePicker3);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker3;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private databaseDataSetTableAdapters.visitTableAdapter visitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tomeetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label Filter;
        internal System.Windows.Forms.ComboBox comboBox2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;

    }
}

