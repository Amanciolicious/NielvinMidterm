
namespace NielvinMidterm
{
    partial class refbtn
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
            this.addbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amancioCoopDataSet2 = new NielvinMidterm.AmancioCoopDataSet2();
            this.loanTableAdapter = new NielvinMidterm.AmancioCoopDataSet2TableAdapters.LoanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.loanbox = new System.Windows.Forms.Label();
            this.fnamebox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resbox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.agebox = new System.Windows.Forms.Label();
            this.statuspaid = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.amancioCoopDataSet3 = new NielvinMidterm.AmancioCoopDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestedAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivableAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amancioCoopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amancioCoopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(1089, 334);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(79, 28);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "ADD LOAN";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(191, 334);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(76, 27);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.amancioCoopDataSet2;
            // 
            // amancioCoopDataSet2
            // 
            this.amancioCoopDataSet2.DataSetName = "AmancioCoopDataSet2";
            this.amancioCoopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loan ID:";
            // 
            // loanbox
            // 
            this.loanbox.AutoSize = true;
            this.loanbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanbox.Location = new System.Drawing.Point(108, 37);
            this.loanbox.Name = "loanbox";
            this.loanbox.Size = new System.Drawing.Size(62, 17);
            this.loanbox.TabIndex = 7;
            this.loanbox.Text = "xxxxxxxxx";
            this.loanbox.Click += new System.EventHandler(this.labelbox_Click);
            // 
            // fnamebox
            // 
            this.fnamebox.AutoSize = true;
            this.fnamebox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamebox.Location = new System.Drawing.Point(314, 36);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(80, 16);
            this.fnamebox.TabIndex = 9;
            this.fnamebox.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "xxxxxxxxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(651, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Residency:";
            // 
            // resbox
            // 
            this.resbox.AutoSize = true;
            this.resbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resbox.Location = new System.Drawing.Point(744, 37);
            this.resbox.Name = "resbox";
            this.resbox.Size = new System.Drawing.Size(62, 17);
            this.resbox.TabIndex = 10;
            this.resbox.Text = "xxxxxxxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(962, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age:";
            // 
            // agebox
            // 
            this.agebox.AutoSize = true;
            this.agebox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agebox.Location = new System.Drawing.Point(1014, 37);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(62, 17);
            this.agebox.TabIndex = 12;
            this.agebox.Text = "xxxxxxxxx";
            // 
            // statuspaid
            // 
            this.statuspaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statuspaid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuspaid.Location = new System.Drawing.Point(1184, 334);
            this.statuspaid.Name = "statuspaid";
            this.statuspaid.Size = new System.Drawing.Size(111, 28);
            this.statuspaid.TabIndex = 14;
            this.statuspaid.Text = "CHANGE STATUS";
            this.statuspaid.UseVisualStyleBackColor = true;
            this.statuspaid.Click += new System.EventHandler(this.paidunpaid_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 334);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 27);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1219, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amancioCoopDataSet3
            // 
            this.amancioCoopDataSet3.DataSetName = "AmancioCoopDataSet3";
            this.amancioCoopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIDDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.loanAMTDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.noofPaymentDataGridViewTextBoxColumn,
            this.deductionDataGridViewTextBoxColumn,
            this.interestedAMTDataGridViewTextBoxColumn,
            this.receivableAMTDataGridViewTextBoxColumn,
            this.totalPayableDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.Status_Paid});
            this.dataGridView1.DataSource = this.loanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanAMTDataGridViewTextBoxColumn
            // 
            this.loanAMTDataGridViewTextBoxColumn.DataPropertyName = "Loan_AMT";
            this.loanAMTDataGridViewTextBoxColumn.HeaderText = "Loan_AMT";
            this.loanAMTDataGridViewTextBoxColumn.Name = "loanAMTDataGridViewTextBoxColumn";
            this.loanAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noofPaymentDataGridViewTextBoxColumn
            // 
            this.noofPaymentDataGridViewTextBoxColumn.DataPropertyName = "No_of_Payment";
            this.noofPaymentDataGridViewTextBoxColumn.HeaderText = "No_of_Payment";
            this.noofPaymentDataGridViewTextBoxColumn.Name = "noofPaymentDataGridViewTextBoxColumn";
            this.noofPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionDataGridViewTextBoxColumn
            // 
            this.deductionDataGridViewTextBoxColumn.DataPropertyName = "Deduction";
            this.deductionDataGridViewTextBoxColumn.HeaderText = "Deduction";
            this.deductionDataGridViewTextBoxColumn.Name = "deductionDataGridViewTextBoxColumn";
            this.deductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestedAMTDataGridViewTextBoxColumn
            // 
            this.interestedAMTDataGridViewTextBoxColumn.DataPropertyName = "Interested_AMT";
            this.interestedAMTDataGridViewTextBoxColumn.HeaderText = "Interested_AMT";
            this.interestedAMTDataGridViewTextBoxColumn.Name = "interestedAMTDataGridViewTextBoxColumn";
            this.interestedAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivableAMTDataGridViewTextBoxColumn
            // 
            this.receivableAMTDataGridViewTextBoxColumn.DataPropertyName = "Receivable_AMT";
            this.receivableAMTDataGridViewTextBoxColumn.HeaderText = "Receivable_AMT";
            this.receivableAMTDataGridViewTextBoxColumn.Name = "receivableAMTDataGridViewTextBoxColumn";
            this.receivableAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPayableDataGridViewTextBoxColumn
            // 
            this.totalPayableDataGridViewTextBoxColumn.DataPropertyName = "Total_Payable";
            this.totalPayableDataGridViewTextBoxColumn.HeaderText = "Total_Payable";
            this.totalPayableDataGridViewTextBoxColumn.Name = "totalPayableDataGridViewTextBoxColumn";
            this.totalPayableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status_Paid
            // 
            this.Status_Paid.DataPropertyName = "Status_Paid";
            this.Status_Paid.HeaderText = "Status_Paid";
            this.Status_Paid.Name = "Status_Paid";
            this.Status_Paid.ReadOnly = true;
            // 
            // refbtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1331, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statuspaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resbox);
            this.Controls.Add(this.fnamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loanbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "refbtn";
            this.Text = "ViewLoan";
            this.Load += new System.EventHandler(this.Loan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amancioCoopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amancioCoopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button searchbtn;
        private AmancioCoopDataSet2 amancioCoopDataSet2;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private AmancioCoopDataSet2TableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loanbox;
        private System.Windows.Forms.Label fnamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label agebox;
        private System.Windows.Forms.Button statuspaid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private AmancioCoopDataSet3 amancioCoopDataSet3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestedAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivableAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Paid;
    }
}