namespace UserAdmin
{
    partial class AdminPanel
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            password = new TextBox();
            label6 = new Label();
            email = new TextBox();
            label4 = new Label();
            age = new TextBox();
            label5 = new Label();
            surname = new TextBox();
            label3 = new Label();
            name = new TextBox();
            label = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            IDinput = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 195);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1411, 195);
            dataGridView1.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(14, 295);
            password.Name = "password";
            password.Size = new Size(286, 27);
            password.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 270);
            label6.Name = "label6";
            label6.Size = new Size(106, 22);
            label6.TabIndex = 28;
            label6.Text = "Passwords";
            // 
            // email
            // 
            email.Location = new Point(12, 225);
            email.Name = "email";
            email.Size = new Size(286, 27);
            email.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 200);
            label4.Name = "label4";
            label4.Size = new Size(59, 22);
            label4.TabIndex = 26;
            label4.Text = "Email";
            // 
            // age
            // 
            age.Location = new Point(12, 157);
            age.Name = "age";
            age.Size = new Size(286, 27);
            age.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 132);
            label5.Name = "label5";
            label5.Size = new Size(44, 22);
            label5.TabIndex = 24;
            label5.Text = "Age";
            // 
            // surname
            // 
            surname.Location = new Point(12, 92);
            surname.Name = "surname";
            surname.Size = new Size(286, 27);
            surname.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 22;
            label3.Text = "Surname";
            // 
            // name
            // 
            name.Location = new Point(12, 30);
            name.Name = "name";
            name.Size = new Size(286, 27);
            name.TabIndex = 21;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(12, 5);
            label.Name = "label";
            label.Size = new Size(63, 22);
            label.TabIndex = 20;
            label.Text = "Name";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(1257, 12);
            button1.Name = "button1";
            button1.Size = new Size(142, 51);
            button1.TabIndex = 30;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(1259, 145);
            button2.Name = "button2";
            button2.Size = new Size(140, 51);
            button2.TabIndex = 31;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.Blue;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button3.Location = new Point(1257, 80);
            button3.Name = "button3";
            button3.Size = new Size(140, 51);
            button3.TabIndex = 32;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = Color.Blue;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button4.Location = new Point(1259, 213);
            button4.Name = "button4";
            button4.Size = new Size(140, 51);
            button4.TabIndex = 33;
            button4.Text = "GetByID";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // IDinput
            // 
            IDinput.Location = new Point(1070, 36);
            IDinput.Name = "IDinput";
            IDinput.Size = new Size(164, 27);
            IDinput.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1070, 11);
            label1.Name = "label1";
            label1.Size = new Size(33, 22);
            label1.TabIndex = 34;
            label1.Text = "ID";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 590);
            Controls.Add(IDinput);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label6);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(age);
            Controls.Add(label5);
            Controls.Add(surname);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label);
            Controls.Add(panel1);
            Name = "AdminPanel";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox password;
        private Label label6;
        private TextBox email;
        private Label label4;
        private TextBox age;
        private Label label5;
        private TextBox surname;
        private Label label3;
        private TextBox name;
        private Label label;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox IDinput;
        private Label label1;
    }
}