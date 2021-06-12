
namespace TAB_clinic_GUI
{
    partial class exam
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
            this.docText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.managerText = new System.Windows.Forms.RichTextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.TextBox();
            this.makeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // docText
            // 
            this.docText.Enabled = false;
            this.docText.Location = new System.Drawing.Point(10, 71);
            this.docText.Name = "docText";
            this.docText.Size = new System.Drawing.Size(205, 155);
            this.docText.TabIndex = 0;
            this.docText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor\'s notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result of exam";
            // 
            // resultText
            // 
            this.resultText.Enabled = false;
            this.resultText.Location = new System.Drawing.Point(231, 71);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(205, 155);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manager\'s notes";
            // 
            // managerText
            // 
            this.managerText.Enabled = false;
            this.managerText.Location = new System.Drawing.Point(442, 71);
            this.managerText.Name = "managerText";
            this.managerText.Size = new System.Drawing.Size(205, 155);
            this.managerText.TabIndex = 4;
            this.managerText.Text = "";
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(76, 15);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 23);
            this.idText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exam\'s ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(233, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Exam\'s name";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameText.Enabled = false;
            this.nameText.Location = new System.Drawing.Point(316, 15);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 23);
            this.nameText.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(445, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Exam\'s status";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.statusText.Enabled = false;
            this.statusText.Location = new System.Drawing.Point(529, 15);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(100, 23);
            this.statusText.TabIndex = 11;
            // 
            // makeButton
            // 
            this.makeButton.Enabled = false;
            this.makeButton.Location = new System.Drawing.Point(231, 232);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(75, 23);
            this.makeButton.TabIndex = 13;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(360, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Enabled = false;
            this.rejectButton.Location = new System.Drawing.Point(572, 232);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(75, 23);
            this.rejectButton.TabIndex = 16;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(443, 232);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 15;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(291, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(139, 231);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 308);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.managerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docText);
            this.Name = "exam";
            this.Text = "exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /*
         * this method is used to disabled parts of from based on the variable
         * view - only to read form
         * doc - for doctor version of form
         * labManager - for lab manager version of form 
         * labWorker - for lab worker version of form
        */
        private void enabledParts(string formVersion)
        {


            if (formVersion == "doc")
            {
                this.acceptButton.Enabled = false;
                this.rejectButton.Enabled = false;
                this.cancelButton.Enabled = false;
                this.makeButton.Enabled = false;
                this.managerText.Enabled = false;
                this.resultText.Enabled = false;
            }
            else if (formVersion == "lab_W")
            {
                this.acceptButton.Enabled = false;
                this.rejectButton.Enabled = false;
                this.docText.Enabled = false;
                this.managerText.Enabled = false;
            }
            else if (formVersion == "lab_M")
            {
                this.cancelButton.Enabled = false;
                this.makeButton.Enabled = false;
                this.docText.Enabled = false;
                this.resultText.Enabled = false;
            }
        }

        #endregion

        private System.Windows.Forms.RichTextBox docText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox managerText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button buttonSave;
    }
}