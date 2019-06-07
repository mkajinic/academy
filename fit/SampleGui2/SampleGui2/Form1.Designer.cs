namespace SampleGui2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.lblTxtBxFirstNameContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(224, 134);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(58, 13);
            this.labelLastname.TabIndex = 1;
            this.labelLastname.Text = "Last Name";
            this.labelLastname.Click += new System.EventHandler(this.labelLastname_Click);
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(309, 53);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(177, 20);
            this.txtboxName.TabIndex = 2;
            this.txtboxName.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(309, 127);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(179, 20);
            this.textBoxLastname.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSave.Location = new System.Drawing.Point(309, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(179, 48);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // lblTxtBxFirstNameContent
            // 
            this.lblTxtBxFirstNameContent.AutoSize = true;
            this.lblTxtBxFirstNameContent.Location = new System.Drawing.Point(327, 291);
            this.lblTxtBxFirstNameContent.Name = "lblTxtBxFirstNameContent";
            this.lblTxtBxFirstNameContent.Size = new System.Drawing.Size(0, 13);
            this.lblTxtBxFirstNameContent.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTxtBxFirstNameContent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Concatinator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label lblTxtBxFirstNameContent;
    }
}

