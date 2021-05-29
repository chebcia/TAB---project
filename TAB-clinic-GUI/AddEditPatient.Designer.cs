
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
            this.inputPESEL = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(71, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(211, 98);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(294, 39);
            this.inputName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(71, 146);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(122, 32);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last name";
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(211, 143);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(294, 39);
            this.inputLastName.TabIndex = 3;
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(71, 191);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(75, 32);
            this.labelPesel.TabIndex = 4;
            this.labelPesel.Text = "PESEL";
            // 
            // inputPESEL
            // 
            this.inputPESEL.Location = new System.Drawing.Point(211, 188);
            this.inputPESEL.MaxLength = 11;
            this.inputPESEL.Name = "inputPESEL";
            this.inputPESEL.Size = new System.Drawing.Size(294, 39);
            this.inputPESEL.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(355, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 46);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // AddEditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 386);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.inputPESEL);
            this.Controls.Add(this.labelPesel);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelName);
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
        private System.Windows.Forms.TextBox inputPESEL;
        private System.Windows.Forms.Button buttonSave;
    }
}