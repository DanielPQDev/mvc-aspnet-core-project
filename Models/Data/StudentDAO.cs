using System.Data.SqlClient;
using lab2LenguajesDaniel.Models.Domain;

namespace lab2LenguajesDaniel.Models.Data
{
    public class StudentDAO
    {
        private string connectionString;

        public StudentDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertStudent(Student student)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Student (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Email", student.Email);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
