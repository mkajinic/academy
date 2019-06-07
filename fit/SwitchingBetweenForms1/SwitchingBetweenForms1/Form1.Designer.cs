namespace SwitchingBetweenForms1
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
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.btnOpenForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(562, 39);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(176, 79);
            this.btnOpenForm2.TabIndex = 0;
            this.btnOpenForm2.Text = "Open Form 2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // btnOpenForm3
            // 
            this.btnOpenForm3.Location = new System.Drawing.Point(560, 192);
            this.btnOpenForm3.Name = "btnOpenForm3";
            this.btnOpenForm3.Size = new System.Drawing.Size(177, 87);
            this.btnOpenForm3.TabIndex = 1;
            this.btnOpenForm3.Text = "Open Form 3";
            this.btnOpenForm3.UseVisualStyleBackColor = true;
            this.btnOpenForm3.Click += new System.EventHandler(this.btnOpenForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenForm3);
            this.Controls.Add(this.btnOpenForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.Button btnOpenForm3;
    }
}

