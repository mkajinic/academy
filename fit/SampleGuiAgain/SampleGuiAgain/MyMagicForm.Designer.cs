namespace SampleGuiAgain
{
    partial class MyFirstForm
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblChangeTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txBoxMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(292, 181);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(195, 81);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "ClickMe";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblChangeTxt
            // 
            this.lblChangeTxt.AutoSize = true;
            this.lblChangeTxt.Location = new System.Drawing.Point(348, 138);
            this.lblChangeTxt.Name = "lblChangeTxt";
            this.lblChangeTxt.Size = new System.Drawing.Size(78, 13);
            this.lblChangeTxt.TabIndex = 1;
            this.lblChangeTxt.Text = "SeeMeChange";
            this.lblChangeTxt.Click += new System.EventHandler(this.lblChangeTxt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "ChangeTxt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txBoxMessage
            // 
            this.txBoxMessage.Location = new System.Drawing.Point(267, 69);
            this.txBoxMessage.Name = "txBoxMessage";
            this.txBoxMessage.Size = new System.Drawing.Size(231, 20);
            this.txBoxMessage.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MyFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txBoxMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblChangeTxt);
            this.Controls.Add(this.btnClickMe);
            this.Name = "MyFirstForm";
            this.Text = "MyFirstForm";
            this.Load += new System.EventHandler(this.MyFirstForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblChangeTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txBoxMessage;
        private System.Windows.Forms.Button button2;
    }
}

