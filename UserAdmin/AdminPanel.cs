using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAdmin.Entitites;

namespace UserAdmin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserControls.SugnUpControl(name.Text, surname.Text, age.Text, email.Text, password.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UserControls.AdminUpdate(IDinput.Text, name.Text, surname.Text, age.Text, email.Text, password.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            UserControls.AdminGetByID(IDinput.Text, name.Text, surname.Text, age.Text, email.Text, password.Text);
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            UserControls.Datagrid(dataGridView1);
            UserControls.DataGridView1();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UserControls.AdminDelete(IDinput.Text);
        }
    }
}
