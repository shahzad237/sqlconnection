﻿namespace sqlconnection
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
            username_text = new TextBox();
            password_txt = new TextBox();
            lblusername = new Label();
            label2 = new Label();
            btn_login = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // username_text
            // 
            username_text.Location = new Point(320, 56);
            username_text.Name = "username_text";
            username_text.Size = new Size(194, 23);
            username_text.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(320, 112);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(194, 23);
            password_txt.TabIndex = 1;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(216, 57);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(59, 15);
            lblusername.TabIndex = 2;
            lblusername.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 120);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(317, 184);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(426, 184);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancel);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(lblusername);
            Controls.Add(password_txt);
            Controls.Add(username_text);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_text;
        private TextBox password_txt;
        private Label lblusername;
        private Label label2;
        private Button btn_login;
        private Button btn_cancel;
    }
}