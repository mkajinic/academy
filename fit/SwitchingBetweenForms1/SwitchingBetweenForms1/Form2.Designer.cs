namespace SwitchingBetweenForms1
{
    partial class Form2
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
            this.btnOpenForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenForm1
            // 
            this.btnOpenForm1.Location = new System.Drawing.Point(578, 40);
            this.btnOpenForm1.Name = "btnOpenForm1";
            this.btnOpenForm1.Size = new System.Drawing.Size(171, 83);
            this.btnOpenForm1.TabIndex = 0;
            this.btnOpenForm1.Text = "Open Form 1";
            this.btnOpenForm1.UseVisualStyleBackColor = true;
            this.btnOpenForm1.Click += new System.EventHandler(this.btnOpenForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm1;
    }
}