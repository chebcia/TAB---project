
namespace TAB_clinic_GUI
{
    partial class RegisterVisitForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDoctor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(566, 115);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(152, 47);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date visit*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // inputDoctor
            // 
            this.inputDoctor.FormattingEnabled = true;
            this.inputDoctor.Location = new System.Drawing.Point(215, 64);
            this.inputDoctor.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.inputDoctor.Name = "inputDoctor";
            this.inputDoctor.Size = new System.Drawing.Size(504, 40);
            this.inputDoctor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select doctor*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // inputDate
            // 
            this.inputDate.CustomFormat = "  MM/dd/yyyy  h:mm tt";
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDate.Location = new System.Drawing.Point(215, 15);
            this.inputDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(504, 39);
            this.inputDate.TabIndex = 14;
            this.inputDate.ValueChanged += new System.EventHandler(this.inputDate_ValueChanged);
            // 
            // RegisterVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 175);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "RegisterVisitForm";
            this.Text = "Make an appointment";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker inputDate;
    }
}