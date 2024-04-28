using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAdmin.Entitites
{
    public class UserControls
    {
        private static DataGridView _dataGrid;
        public  static UserManager user = new UserManager();
      

        public static void loginTexts(string email, string password)
        {
            if (email == "admin@gmail.com" && password == "admin123")
            {
                MessageBox.Show("Siz Admin kimi daxil Oldunuz:");
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
            }
            var a = user.GetAll();
            foreach (var item in a)
            {
                if (item.Email == email && item.Password == password)
                {
                    MessageBox.Show("Siz Daxil Oldunuz:)");
                }
            }


        }
        public static void SugnUpControl(string name, string surname, string age, string email, string password)
        {
            User users = new User()
            {
                Name = name,
                Surname = surname,
                Age = byte.Parse(age),
                Email = email,
                Password = password
            };
            user.ADD(users);

            DataGridView1();
        }

        public static void AdminGetByID(string IDinput, string name, string surname, string age, string email, string password)
        {
            var users = user.GetByID(int.Parse(IDinput));
            name = users.Name;
            surname = users.Surname;
            age = Convert.ToString(users.Age);
            email = users.Email;
            password = users.Password;
            MessageBox.Show("Istediyiniz nomreli adam tapildi:");
        }

        public static void Datagrid(DataGridView dataGridView)
        {
            _dataGrid = dataGridView;
        }
        public static void DataGridView1()
        {
            if (_dataGrid != null)
            {
                _dataGrid.DataSource = user.GetAll();
            }
            else
            {
                MessageBox.Show("Cedvel Doldurulmasi zamani Xeta");
            }
        }

        public static void AdminUpdate(string IDinput, string name, string surname, string age, string email, string password)
        {
            User users = new User()
            {
                ID = int.Parse(IDinput),
                Name = name,
                Surname = surname,
                Age = byte.Parse(age),
                Email = email,
                Password = password
            };
            user.Update(users);
            MessageBox.Show("istifadeci yenilendi:)");
            DataGridView1();
        }

        public static void AdminDelete(string IDinput)
        {
            user.Delete(int.Parse(IDinput));
            MessageBox.Show("Istifadeci Silindi:)");
            DataGridView1();
        }
    }
}
