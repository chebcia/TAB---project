
namespace TAB_clinic_GUI
{
    partial class VisitsForm
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
            this.dataVisits = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDateFrom = new System.Windows.Forms.DateTimePicker();
            this.inputDateTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPesel = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVisits
            // 
            this.dataVisits.AllowUserToAddRows = false;
            this.dataVisits.AllowUserToDeleteRows = false;
            this.dataVisits.AllowUserToOrderColumns = true;
            this.dataVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVisits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataVisits.Location = new System.Drawing.Point(8, 56);
            this.dataVisits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataVisits.Name = "dataVisits";
            this.dataVisits.ReadOnly = true;
            this.dataVisits.RowHeadersWidth = 51;
            this.dataVisits.RowTemplate.Height = 29;
            this.dataVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVisits.Size = new System.Drawing.Size(715, 232);
            this.dataVisits.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(542, 292);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 25);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Cancel Visit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Surname:";
            // 
            // inputLastName
            // 
            this.inputLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLastName.Location = new System.Drawing.Point(326, 28);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(190, 23);
            this.inputLastName.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(519, 27);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(203, 25);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date from:";
            // 
            // inputDateFrom
            // 
            this.inputDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDateFrom.CustomFormat = "  MM/dd/yyyy  h:mm tt";
            this.inputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDateFrom.Location = new System.Drawing.Point(80, 6);
            this.inputDateFrom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputDateFrom.Name = "inputDateFrom";
            this.inputDateFrom.Size = new System.Drawing.Size(176, 23);
            this.inputDateFrom.TabIndex = 13;
            this.inputDateFrom.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // inputDateTo
            // 
            this.inputDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDateTo.CustomFormat = "  MM/dd/yyyy  h:mm tt";
            this.inputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDateTo.Location = new System.Drawing.Point(80, 27);
            this.inputDateTo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputDateTo.Name = "inputDateTo";
            this.inputDateTo.Size = new System.Drawing.Size(176, 23);
            this.inputDateTo.TabIndex = 14;
            this.inputDateTo.Value = new System.DateTime(2029, 12, 31, 23, 59, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date to:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "PESEL:";
            // 
            // inputPesel
            // 
            this.inputPesel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPesel.Location = new System.Drawing.Point(326, 7);
            this.inputPesel.Name = "inputPesel";
            this.inputPesel.Size = new System.Drawing.Size(190, 23);
            this.inputPesel.TabIndex = 17;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(519, 7);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(203, 23);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // VisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 324);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.inputPesel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDateTo);
            this.Controls.Add(this.inputDateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataVisits);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VisitsForm";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.CancelVisitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVisits;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inputDateFrom;
        private System.Windows.Forms.DateTimePicker inputDateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPesel;
        private System.Windows.Forms.Button buttonClear;
    }
}