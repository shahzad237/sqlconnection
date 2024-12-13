namespace sqlconnection
{
    partial class Form1
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
            username = new TextBox();
            password1 = new TextBox();
            lbluser = new Label();
            lblpassword = new Label();
            lblbtn = new Button();
            signup_txt = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(233, 30);
            username.Name = "username";
            username.Size = new Size(198, 23);
            username.TabIndex = 0;
            username.TextChanged += username_TextChanged;
            // 
            // password1
            // 
            password1.Location = new Point(231, 86);
            password1.Name = "password1";
            password1.Size = new Size(201, 23);
            password1.TabIndex = 1;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.BackColor = SystemColors.ButtonFace;
            lbluser.Location = new Point(153, 35);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(59, 15);
            lbluser.TabIndex = 2;
            lbluser.Text = "username";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = SystemColors.ButtonFace;
            lblpassword.Location = new Point(148, 89);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(57, 15);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "password";
            // 
            // lblbtn
            // 
            lblbtn.Location = new Point(670, 89);
            lblbtn.Name = "lblbtn";
            lblbtn.Size = new Size(96, 37);
            lblbtn.TabIndex = 4;
            lblbtn.Text = "login";
            lblbtn.UseVisualStyleBackColor = true;
            lblbtn.Click += lblbtn_Click;
            // 
            // signup_txt
            // 
            signup_txt.Location = new Point(670, 30);
            signup_txt.Name = "signup_txt";
            signup_txt.Size = new Size(94, 42);
            signup_txt.TabIndex = 5;
            signup_txt.Text = "signup";
            signup_txt.UseVisualStyleBackColor = true;
            signup_txt.Click += signup_txt_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(668, 219);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(96, 37);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(668, 155);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(96, 37);
            btn_update.TabIndex = 7;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(signup_txt);
            Controls.Add(lblbtn);
            Controls.Add(lblpassword);
            Controls.Add(lbluser);
            Controls.Add(password1);
            Controls.Add(username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password1;
        private Label lbluser;
        private Label lblpassword;
        private Button lblbtn;
        private Button signup_txt;
        private Button btn_delete;
        private Button btn_update;
    }
}
