
namespace TAB_clinic_GUI
{
    partial class RegisterForm
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
            this.buttonRegisterVisit = new System.Windows.Forms.Button();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // buttonRegisterVisit
            // 
            this.buttonRegisterVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegisterVisit.Location = new System.Drawing.Point(8, 155);
            this.buttonRegisterVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegisterVisit.Name = "buttonRegisterVisit";
            this.buttonRegisterVisit.Size = new System.Drawing.Size(132, 22);
            this.buttonRegisterVisit.TabIndex = 1;
            this.buttonRegisterVisit.Text = "Create appointment";
            this.buttonRegisterVisit.UseVisualStyleBackColor = true;
            this.buttonRegisterVisit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowser.Location = new System.Drawing.Point(201, 155);
            this.buttonBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(193, 22);
            this.buttonBrowser.TabIndex = 3;
            this.buttonBrowser.Text = "Browse appointments";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPatient.Location = new System.Drawing.Point(452, 179);
            this.buttonAddPatient.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(137, 22);
            this.buttonAddPatient.TabIndex = 4;
            this.buttonAddPatient.Text = "Add new patient";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddEditPatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditPatient.Location = new System.Drawing.Point(452, 155);
            this.buttonEditPatient.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(137, 22);
            this.buttonEditPatient.TabIndex = 5;
            this.buttonEditPatient.Text = "Edit selected patient";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(8, 179);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(132, 22);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 208);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonEditPatient);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.buttonRegisterVisit);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRegisterVisit;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBrowser;
    }
}