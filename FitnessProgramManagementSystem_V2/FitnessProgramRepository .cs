using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class FitnessProgramRepository
    {
        public readonly string ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=FitnessProgramManagement;";

        public void AddProgram(FitnessProgram program)
        {
            string query = "Insert into FitnessPrograms values (@id,@Title,@duration,@price)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    
                }
            }
        }
    }
}
