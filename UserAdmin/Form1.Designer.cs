namespace UserAdmin
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            password = new TextBox();
            label3 = new Label();
            email = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(154, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 426);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(73, 328);
            button2.Name = "button2";
            button2.Size = new Size(139, 52);
            button2.TabIndex = 6;
            button2.Text = "Sign UP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(218, 328);
            button1.Name = "button1";
            button1.Size = new Size(139, 52);
            button1.TabIndex = 5;
            button1.Text = "Sign IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(73, 273);
            password.Name = "password";
            password.Size = new Size(286, 27);
            password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 248);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 3;
            label3.Text = "Passwords";
            // 
            // email
            // 
            email.Location = new Point(73, 144);
            email.Name = "email";
            email.Size = new Size(286, 27);
            email.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 119);
            label2.Name = "label2";
            label2.Size = new Size(59, 22);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 28);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 0;
            label1.Text = "Log IN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox password;
        private Label label3;
        private TextBox email;
        private Label label2;
        private Label label1;
    }
}
