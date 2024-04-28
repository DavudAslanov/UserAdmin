namespace UserAdmin
{
    partial class SignUp
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
            button2 = new Button();
            surname = new TextBox();
            label3 = new Label();
            name = new TextBox();
            label = new Label();
            label1 = new Label();
            email = new TextBox();
            label4 = new Label();
            age = new TextBox();
            label5 = new Label();
            password = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(251, 419);
            button2.Name = "button2";
            button2.Size = new Size(284, 57);
            button2.TabIndex = 13;
            button2.Text = "Sign UP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // surname
            // 
            surname.Location = new Point(249, 145);
            surname.Name = "surname";
            surname.Size = new Size(286, 27);
            surname.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(249, 120);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 10;
            label3.Text = "Surname";
            // 
            // name
            // 
            name.Location = new Point(249, 83);
            name.Name = "name";
            name.Size = new Size(286, 27);
            name.TabIndex = 9;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(249, 58);
            label.Name = "label";
            label.Size = new Size(63, 22);
            label.TabIndex = 8;
            label.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(352, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 7;
            label1.Text = "Log IN";
            // 
            // email
            // 
            email.Location = new Point(249, 278);
            email.Name = "email";
            email.Size = new Size(286, 27);
            email.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(249, 253);
            label4.Name = "label4";
            label4.Size = new Size(59, 22);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // age
            // 
            age.Location = new Point(249, 210);
            age.Name = "age";
            age.Size = new Size(286, 27);
            age.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(249, 185);
            label5.Name = "label5";
            label5.Size = new Size(44, 22);
            label5.TabIndex = 14;
            label5.Text = "Age";
            // 
            // password
            // 
            password.Location = new Point(251, 348);
            password.Name = "password";
            password.Size = new Size(286, 27);
            password.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(251, 323);
            label6.Name = "label6";
            label6.Size = new Size(106, 22);
            label6.TabIndex = 18;
            label6.Text = "Passwords";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 564);
            Controls.Add(password);
            Controls.Add(label6);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(age);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(surname);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label);
            Controls.Add(label1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            FormClosed += SignUp_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox surname;
        private Label label3;
        private TextBox name;
        private Label label;
        private Label label1;
        private TextBox email;
        private Label label4;
        private TextBox age;
        private Label label5;
        private TextBox password;
        private Label label6;
    }
}