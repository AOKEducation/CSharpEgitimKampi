using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaeCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 201 - modul 2.ders
            //-----------------------------------

            // Crud -->  Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem paneli ****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");


            #region Kategori ekleme işlemi
            //Console.Write("Eklenecek Kategori Adı :");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=NOVA-PC87; initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand ("insert into TblCategory (CategoryName) values (@p1)",connection );

            //// (CategoryName) values (@p1)
            //// (CategoryName,diger,... )values(@p1,@pdiger,...)
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // koşulsuz sorguyu çalıştır.
            //connection.Close();
            //Console.Write("Kategori başarıyla eklendi");
            #endregion

            #region Ürün ekleme işlemi





            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı :");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=NOVA-PC87; initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (productName,productPrice,productStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery(); // koşulsuz sorguyu çalıştır.
            //connection.Close();
            //Console.Write("Ürün başarıyla eklendi :)");

            #endregion


            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=NOVA-PC87; initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() +"\t");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion


            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id : ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=NOVA-PC87; initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.Write("Silme işlemi yapıldı .!)");

            #endregion



            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellenecek Ürün Id : ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=NOVA-PC87; initial Catalog=EgitimKampiDb;integrated security=true");


            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName , ProductPrice=@productPrice Where ProductId=@productId", connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productprice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();

            connection.Close();
            Console.Write("Güncelleme Başarılı .!)");
            #endregion



            Console.Read();

        }
    }
}
