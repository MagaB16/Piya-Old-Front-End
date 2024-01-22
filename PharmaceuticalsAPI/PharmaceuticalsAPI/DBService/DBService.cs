using System.Data.SqlClient;
namespace PharmaceuticalsAPI.DBService;

public class DBService : IDBService
{
    public object GetPharmaceuticals(string includes)
    {
        try
        {
            using SqlConnection conn = new("Data Source=SQL8004.site4now.net;Initial Catalog=db_aa4553_piyadb;User Id=db_aa4553_piyadb_admin;Password=Fl1ck_Maga");
            conn.Open();
            var pharmaceuticals = new List<string>();

            using SqlCommand cmd = new("SELECT * FROM Products", conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pharmaceuticals.Add(reader.GetString(1));
            }
            conn.Close();
            var products = pharmaceuticals.Where(p => p.Contains(includes));
            
            return products;
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public object GetPharmacies(string pharmaceutical)
    {
        try {
            using SqlConnection conn = new("Data Source=SQL8004.site4now.net;Initial Catalog=db_aa4553_piyadb;User Id=db_aa4553_piyadb_admin;Password=Fl1ck_Maga");
            conn.Open();
            var pharmacies = new List<Pharmacy>();
            using SqlCommand cmd = new(@"declare @ProductName nvarchar(max) = '" + pharmaceutical + "'; select P.PharmacyId, P.Name as PharmacyName, P.PhoneNumber,P.Email,P.Address,PR.ProductId,PR.Name as ProductName from Pharmacies as P join PharmacyProduct as PP on P.PharmacyId = PP.PharmacyId join Products as PR on PP.ProductId = PR.ProductId where PR.Name = @ProductName;", conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var pharmacyId = reader.GetInt32(0);
                var pharmacyName = reader.GetString(1);
                var phoneNumber = reader.GetString(2);
                var email = reader.GetString(3);
                var address = reader.GetString(4);
                var productId = reader.GetInt32(5);
                var productName = reader.GetString(6);
                var pharmacy = new Pharmacy()
                {
                    Id = pharmacyId,
                    Name = pharmacyName,
                    PhoneNumber = phoneNumber,
                    Email = email,
                    Address = address,
                };
                pharmacies.Add(pharmacy);
            }
            conn.Close();
            return pharmacies;
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}
