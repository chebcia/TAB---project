
namespace TAB_clinic_GUI
{
    partial class AddEditPatientForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.labelPesel = new System.Windows.Forms.Label();
            this.inputPesel = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 45);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(114, 42);
            this.inputName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(160, 23);
            this.inputName.TabIndex = 1;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(38, 70);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 15);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last name";
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(114, 67);
            this.inputLastName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(160, 23);
            this.inputLastName.TabIndex = 3;
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(39, 95);
            this.labelPesel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(38, 15);
            this.labelPesel.TabIndex = 4;
            this.labelPesel.Text = "PESEL";
            // 
            // inputPesel
            // 
            this.inputPesel.Location = new System.Drawing.Point(114, 92);
            this.inputPesel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputPesel.MaxLength = 11;
            this.inputPesel.Name = "inputPesel";
            this.inputPesel.Size = new System.Drawing.Size(160, 23);
            this.inputPesel.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(193, 123);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 22);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddEditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 181);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.inputPesel);
            this.Controls.Add(this.labelPesel);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "AddEditPatientForm";
            this.Text = "AddEditPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.TextBox inputPesel;
        private System.Windows.Forms.Button buttonSave;
    }
}