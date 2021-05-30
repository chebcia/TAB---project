
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
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.inputDiagnosis = new System.Windows.Forms.TextBox();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(566, 395);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 46);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date visit*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // inputDoctor
            // 
            this.inputDoctor.FormattingEnabled = true;
            this.inputDoctor.Location = new System.Drawing.Point(216, 65);
            this.inputDoctor.Margin = new System.Windows.Forms.Padding(5);
            this.inputDoctor.Name = "inputDoctor";
            this.inputDoctor.Size = new System.Drawing.Size(503, 40);
            this.inputDoctor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select doctor*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // inputDate
            // 
            this.inputDate.CustomFormat = "  MM/dd/yyyy h:mm tt";
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDate.Location = new System.Drawing.Point(216, 15);
            this.inputDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(503, 39);
            this.inputDate.TabIndex = 14;
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Location = new System.Drawing.Point(14, 116);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(127, 32);
            this.labelDiagnosis.TabIndex = 15;
            this.labelDiagnosis.Text = "Diagnosis*";
            // 
            // inputDiagnosis
            // 
            this.inputDiagnosis.Location = new System.Drawing.Point(216, 113);
            this.inputDiagnosis.Multiline = true;
            this.inputDiagnosis.Name = "inputDiagnosis";
            this.inputDiagnosis.Size = new System.Drawing.Size(503, 134);
            this.inputDiagnosis.TabIndex = 16;
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(216, 253);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(503, 134);
            this.inputDescription.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Description";
            // 
            // RegisterVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.inputDiagnosis);
            this.Controls.Add(this.labelDiagnosis);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Label labelDiagnosis;
        private System.Windows.Forms.TextBox inputDiagnosis;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label label1;
    }
}