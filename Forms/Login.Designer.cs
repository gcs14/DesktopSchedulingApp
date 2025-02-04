﻿namespace DesktopSchedulingApp.Forms
{
    partial class Login
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
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            enterBtn = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            passwordText = new System.Windows.Forms.TextBox();
            usernameText = new System.Windows.Forms.TextBox();
            loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            usernameLabel.Location = new System.Drawing.Point(142, 172);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(80, 19);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "USERNAME";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            passwordLabel.Location = new System.Drawing.Point(142, 256);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(81, 19);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "PASSWORD";
            // 
            // enterBtn
            // 
            enterBtn.AutoSize = true;
            enterBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            enterBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            enterBtn.Font = new System.Drawing.Font("Arial", 11F);
            enterBtn.Location = new System.Drawing.Point(202, 345);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new System.Drawing.Size(70, 29);
            enterBtn.TabIndex = 2;
            enterBtn.Text = "ENTER";
            enterBtn.UseVisualStyleBackColor = false;
            enterBtn.Click += EnterBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = Properties.Resources.hidden;
            pictureBox1.Location = new System.Drawing.Point(340, 278);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(31, 29);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += passwordHide_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Black", 12F);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(219, 252);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(19, 23);
            label4.TabIndex = 4;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial Black", 12F);
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(219, 168);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(19, 23);
            label5.TabIndex = 4;
            label5.Text = "*";
            // 
            // passwordText
            // 
            passwordText.Font = new System.Drawing.Font("Segoe UI", 12F);
            passwordText.Location = new System.Drawing.Point(145, 278);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new System.Drawing.Size(189, 29);
            passwordText.TabIndex = 5;
            // 
            // usernameText
            // 
            usernameText.Font = new System.Drawing.Font("Segoe UI", 12F);
            usernameText.Location = new System.Drawing.Point(145, 194);
            usernameText.Name = "usernameText";
            usernameText.Size = new System.Drawing.Size(189, 29);
            usernameText.TabIndex = 5;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Arial Black", 35F);
            loginLabel.ForeColor = System.Drawing.Color.MediumPurple;
            loginLabel.Location = new System.Drawing.Point(145, 65);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(194, 67);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(484, 461);
            Controls.Add(loginLabel);
            Controls.Add(usernameText);
            Controls.Add(passwordText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(enterBtn);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label loginLabel;
    }
}