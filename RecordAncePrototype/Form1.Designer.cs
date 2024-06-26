﻿namespace RecordAncePrototype
{
    partial class SignInPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInPage));
            panel2 = new Panel();
            signinPhoto = new PictureBox();
            panel1 = new Panel();
            signupLabel = new Label();
            label5 = new Label();
            signinButton = new Button();
            passwordTextBox = new TextBox();
            label4 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            forgotpasswordLabel = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signinPhoto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(signinPhoto);
            panel2.Location = new Point(468, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 724);
            panel2.TabIndex = 3;
            // 
            // signinPhoto
            // 
            signinPhoto.Image = (Image)resources.GetObject("signinPhoto.Image");
            signinPhoto.Location = new Point(50, 63);
            signinPhoto.Name = "signinPhoto";
            signinPhoto.Size = new Size(600, 600);
            signinPhoto.TabIndex = 0;
            signinPhoto.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(forgotpasswordLabel);
            panel1.Controls.Add(signupLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signinButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 724);
            panel1.TabIndex = 2;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Georgia", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            signupLabel.Location = new Point(291, 468);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(74, 20);
            signupLabel.TabIndex = 8;
            signupLabel.Text = "Sign-up.";
            signupLabel.Click += signupLabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 468);
            label5.Name = "label5";
            label5.Size = new Size(253, 20);
            label5.TabIndex = 7;
            label5.Text = "Don't have an account yet? Click";
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.Maroon;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            signinButton.ForeColor = SystemColors.ButtonHighlight;
            signinButton.Location = new Point(41, 407);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(101, 43);
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign-in";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(44, 347);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(352, 27);
            passwordTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 323);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(43, 268);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(352, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 247);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 174);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 1;
            label2.Text = "Class Monitoring App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 118);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 0;
            label1.Text = "RecordAnce";
            // 
            // forgotpasswordLabel
            // 
            forgotpasswordLabel.AutoSize = true;
            forgotpasswordLabel.Font = new Font("Georgia", 7.8F, FontStyle.Underline, GraphicsUnit.Point);
            forgotpasswordLabel.Location = new Point(44, 377);
            forgotpasswordLabel.Name = "forgotpasswordLabel";
            forgotpasswordLabel.Size = new Size(117, 16);
            forgotpasswordLabel.TabIndex = 9;
            forgotpasswordLabel.Text = "Forgot password?";
            forgotpasswordLabel.Click += forgotpasswordLabel_Click;
            // 
            // SignInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignInPage";
            Text = "Sign-in";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)signinPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox signinPhoto;
        private Panel panel1;
        private Label signupLabel;
        private Label label5;
        private Button signinButton;
        private TextBox passwordTextBox;
        private Label label4;
        private TextBox usernameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label forgotpasswordLabel;
    }
}