using Microsoft.Data.SqlClient;
using sol22.Models;

namespace sol22.Repositories;

public class CompanyRepository
{

    static string table = "company";
    static string connStr = "Server=Magic1412;Database=test;Trusted_Connection=True;TrustServerCertificate=true;";

    public List<Company> GetCompanies()
    {
        using (var Conn = new SqlConnection(connStr))
        {
            var companies = new List<Company>();
            var query = $"SELECT * FROM {table};";
            var command = new SqlCommand(query, Conn);
            Conn.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var company = new Company
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Address = (string)reader["Address"]
                };
                Console.WriteLine(company);
                companies.Add(company);
            }
            return companies;
        }
    }

    public Company GetCompany(int id)
    {
        using (var Conn = new SqlConnection(connStr))
        {
            var query = $"SELECT * from {table} WHERE id=@Id";
            var command = new SqlCommand(query, Conn);
            command.Parameters.AddWithValue("@Id", id);
            Conn.Open();
            var reader = command.ExecuteReader();
            reader.Read();
            var company = new Company
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Address = (string)reader["Address"]
            };
            return company;
        }
    }

    public void SaveCompany(Company company)
    {
        using (var Conn = new SqlConnection(connStr))
        {
            var query = $"INSERT INTO {table}(name, address) VALUES (@Name, @Address)";
            var command = new SqlCommand(query, Conn);
            command.Parameters.AddWithValue("@Name", company.Name);
            command.Parameters.AddWithValue("@Address", company.Address);
            Conn.Open();
            command.ExecuteNonQuery();
        }
    }

    public void UpdateCompany(Company company)
    {
        using (var Conn = new SqlConnection(connStr))
        {
            string query = $"UPDATE {table} SET Name = @Name, Address = @Address WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.AddWithValue("@Name", company.Name);
            command.Parameters.AddWithValue("@Address", company.Address);
            command.Parameters.AddWithValue("@Id", company.Id);

            Conn.Open();
            command.ExecuteNonQuery();
        }
    }

    public void DeleteCompany(int id)
    {
        using (var Conn = new SqlConnection(connStr))
        {
            string query = $"DELETE FROM {table} WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.AddWithValue("@Id", id);

            Conn.Open();
            command.ExecuteNonQuery();
        }
    }
}