using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Database
{
    internal class Program
    {
       {
        static void Main(string[] args)
        {
            //Ado.Net
            //c# üzerinde sql sorgularını kullanmamızı sağlıyor

            Console.WriteLine("********* C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *************");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1-KATEGORİLER");
            Console.WriteLine("2-ÜRÜNLER");
            Console.WriteLine("3-SİPARİŞLER");
            Console.WriteLine("4-ÇIKIŞ YAP");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasnı giriniz.");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------");

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-QN7HAT1\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            SqlCommand sqlCommand = new SqlCommand("Select*From TblCategory", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //c# ile sunucu arasında köprü sağlıyor
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
}
