﻿namespace Get_User_ip_country_screenshot
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
            this.sendScreenshot_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendScreenshot_btn
            // 
            this.sendScreenshot_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendScreenshot_btn.Location = new System.Drawing.Point(0, 0);
            this.sendScreenshot_btn.Name = "sendScreenshot_btn";
            this.sendScreenshot_btn.Size = new System.Drawing.Size(264, 78);
            this.sendScreenshot_btn.TabIndex = 0;
            this.sendScreenshot_btn.Text = "Get User Details";
            this.sendScreenshot_btn.UseVisualStyleBackColor = true;
            this.sendScreenshot_btn.Click += new System.EventHandler(this.sendScreenshot_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 78);
            this.Controls.Add(this.sendScreenshot_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Spy Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendScreenshot_btn;
    }
}

