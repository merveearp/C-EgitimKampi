using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD ---> CREATE-READ-UPDATE-DELETE
            Console.WriteLine("**** Menü Sipariş İşlem Sayfası*****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.WriteLine("Eklemek istediğiniz Kategori Adı:");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QN7HAT1\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();//koşulsuz sorguyu çalıştır.
            //connection.Close();

            //Console.WriteLine("Kategori başarılı bir şekilde eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productstatus;

            //Console.Write("Ürün adı : ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("data source = desktop-qn7hat1\\sqlexpress;initial catalog =egitimkampidb ; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into tblproduct (productname,productprice,productstatus) values(@productname,@productprice,@productstatus)", connection);
            //command.Parameters.AddWithValue("@productname", productName);
            //command.Parameters.AddWithValue("@productprice", productPrice);
            //command.Parameters.AddWithValue("@productstatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün ekleme işlemi başarılı!");



            #endregion

            #region Ürün Silme İşlemi

            //Console.WriteLine("Silinecek Ürün Id :");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-QN7HAT1\\SQLEXPRESS;initial catalog =EgitimKampiDb ; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId= @productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi başarılı bir şekilde yapıldı!");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürünün Id : ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı : ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-QN7HAT1\\SQLEXPRESS;initial catalog =EgitimKampiDb ; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarılı bir şkeilde güncellendi !");

            #endregion
            
            Console.Read();
        }
    }
}