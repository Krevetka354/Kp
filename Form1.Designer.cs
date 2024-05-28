namespace Kp
{
    partial class Kindergarden
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.childQueueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.childQueueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childrenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.childrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxFilterAge = new System.Windows.Forms.TextBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childQueueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childQueueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.childBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(814, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // childQueueBindingSource1
            // 
            this.childQueueBindingSource1.DataSource = typeof(ChildQueue);
            // 
            // childQueueBindingSource
            // 
            this.childQueueBindingSource.DataSource = typeof(ChildQueue);
            // 
            // childBindingSource
            // 
            this.childBindingSource.DataSource = typeof(Child);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1025, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(877, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2018, -295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(973, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1062, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(1062, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "Import";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(1025, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1025, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1025, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 31);
            this.textBox3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(863, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(836, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(836, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(836, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(836, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(836, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 41);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kindergarten waiting list";
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.Transparent;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonD.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonD.Location = new System.Drawing.Point(877, 375);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(112, 34);
            this.buttonD.TabIndex = 16;
            this.buttonD.Text = "Delete";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(6, 473);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(112, 34);
            this.buttonSort.TabIndex = 18;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(6, 524);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(112, 34);
            this.buttonFilter.TabIndex = 19;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(299, 474);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(176, 34);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search by name";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(656, 476);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(158, 83);
            this.buttonExportPDF.TabIndex = 21;
            this.buttonExportPDF.Text = "Expotr to PDF";
            this.buttonExportPDF.UseVisualStyleBackColor = true;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Name",
            "Age",
            "Gender",
            "Enrollment Date",
            "Group number"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(124, 474);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(153, 33);
            this.comboBoxSortBy.TabIndex = 22;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(481, 475);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 34);
            this.textBoxSearch.TabIndex = 23;
            // 
            // textBoxFilterAge
            // 
            this.textBoxFilterAge.Location = new System.Drawing.Point(127, 524);
            this.textBoxFilterAge.Multiline = true;
            this.textBoxFilterAge.Name = "textBoxFilterAge";
            this.textBoxFilterAge.Size = new System.Drawing.Size(150, 34);
            this.textBoxFilterAge.TabIndex = 24;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Location = new System.Drawing.Point(299, 524);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(332, 34);
            this.buttonClearFilters.TabIndex = 25;
            this.buttonClearFilters.Text = "ClearFilters";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn2.HeaderText = "Age";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EnrollmentDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "EnrollmentDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GroupNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "GroupNumber";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Kindergarden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kp.Properties.Resources.imgonline_com_ua_Resize_WvefAJl686UE;
            this.ClientSize = new System.Drawing.Size(1228, 562);
            this.Controls.Add(this.buttonClearFilters);
            this.Controls.Add(this.textBoxFilterAge);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.buttonExportPDF);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kindergarden";
            this.Text = "Kindergarden waiting list";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childQueueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childQueueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private BindingSource childrenBindingSource1;
        
        private BindingSource childrenBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonD;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enrollmentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupNumberDataGridViewTextBoxColumn;
        private Button buttonSort;
        private Button buttonFilter;
        private Button buttonSearch;
        private Button buttonExportPDF;
        private ComboBox comboBoxSortBy;
        private TextBox textBoxSearch;
        private TextBox textBoxFilterAge;
        private Button buttonClearFilters;
        private BindingSource childBindingSource;
        private BindingSource childQueueBindingSource;
        private BindingSource childQueueBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}