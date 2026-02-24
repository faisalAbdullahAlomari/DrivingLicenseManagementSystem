using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Data;
using System.Net.NetworkInformation;

namespace DataAccessLayer
{
    public class clsPeopleData
    {
        private static string _ConnectionString = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build()
            .GetConnectionString("DefaultConnection")!;

        public static DataTable GetPeopleData()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT p.NationalNo, p.FirstName, p.SecondName, p.ThirdName, p.LastName
                                , CONVERT(VARCHAR, p.DateOfBirth, 23) AS DateOfBirth
                                , CASE p.Gender WHEN 0 THEN 'Male' WHEN 1 THEN 'Female' END AS Gender
                                , p.Address, p.Phone, p.Email, c.CountryName, p.ImagePath
                            FROM dbo.People p
                            JOIN dbo.Countries c
                                ON p.NationalityCountryID = c.CountryID;";

            using(SqlConnection conn = new SqlConnection(_ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {

                    try
                    {
                        conn.Open();

                        SqlDataReader rdr = cmd.ExecuteReader();

                        if (rdr.HasRows)
                        {
                            dt.Load(rdr);
                        }

                    }catch(Exception ex)
                    {
                        string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "logs.txt");
                        File.AppendAllText(logPath, $"{DateTime.Now} Exception In GetPeopleData(): " + ex.Message + "\n");
                    }
                }
            }

            return dt;
        }
    }
}
