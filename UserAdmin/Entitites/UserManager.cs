using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using UserAdmin.Abstract;
using UserAdmin.DataAcces.SqlDBContext;

namespace UserAdmin.Entitites
{
    public class UserManager : IUserInterfeys<User>
    {
        private readonly string _connection;

        public UserManager()
        {
            _connection = SQLDatabaseConnect.SQlDatabase();
        }
        public void ADD(User entity)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string script = @"INSERT INTO Users(Names,Surname,Age,Email,Passwords,RolesID)
                        VALUES(@name,@surname,@age,@email,@password,@rolesID)";
                using (SqlCommand cmd = new SqlCommand(script, conn))
                {
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@surname", entity.Surname);
                    cmd.Parameters.AddWithValue("@age", entity.Age);
                    cmd.Parameters.AddWithValue("@email", entity.Email);
                    cmd.Parameters.AddWithValue("@password", entity.Password);
                    cmd.Parameters.AddWithValue("@rolesID", entity.RolesID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Melumat Elave Olundu:");
                }

            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string script = @"Delete From Users where ID=@id";
                    
                using (SqlCommand cmd = new SqlCommand(script, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public List<User> GetAll()
        {
            List<User> list = new List<User>();
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string script = @"SELECT * FROM Users";

                using (SqlCommand cmd = new SqlCommand(script, conn))
                {
                   SqlDataReader sqlData= cmd.ExecuteReader();
                   while (sqlData.Read())
                    {
                        User user = new User();
                        user.ID = Convert.ToInt32(sqlData["ID"]);
                        user.Name = Convert.ToString(sqlData["Names"]);
                        user.Surname = Convert.ToString(sqlData["Surname"]);
                        user.Age = Convert.ToByte(sqlData["Age"]);
                        user.Email = Convert.ToString(sqlData["Email"]);
                        user.Password = Convert.ToString(sqlData["Passwords"]);
                        user.Isdeleted = Convert.ToInt32(sqlData["RolesID"]);
                        list.Add(user);
                    }
                }
            }
            return list;
        }

        public User GetByID(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string script = @"SELECT * FROM Users where ID=@id";

                using (SqlCommand cmd = new SqlCommand(script, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader sqlData = cmd.ExecuteReader();
                    User user = new User();
                    while (sqlData.Read())
                    {
                        user.Name = Convert.ToString(sqlData["Names"]);
                        user.Surname = Convert.ToString(sqlData["Surname"]);
                        user.Age = Convert.ToByte(sqlData["Age"]);
                        user.Email = Convert.ToString(sqlData["Email"]);
                        user.Password = Convert.ToString(sqlData["Passwords"]);
                    }
                    return user;
                }
            }
        }

        public void Update(User entity)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string script = @"UPDATE Users set Names=@name,Surname=@surname,Age=@age,Email=@email,Passwords=@pass
                                where ID=@id";

                using (SqlCommand cmd = new SqlCommand(script, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.ID);
                    cmd.Parameters.AddWithValue("@name",entity.Name);
                    cmd.Parameters.AddWithValue("@surname", entity.Surname);
                    cmd.Parameters.AddWithValue("@age", entity.Age);
                    cmd.Parameters.AddWithValue("@email", entity.Email);
                    cmd.Parameters.AddWithValue("@pass", entity.Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


}
