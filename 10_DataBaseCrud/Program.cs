using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  crud---> create delete read update r

            #region katogori ekleme işlemi
            //Console.Write("eklemek istediğiniz katogori isminizi giriniz:");
            //string categoryName= Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=RUMEYSA\\SQLEXPRESS;initial catalog=c#DataBaseÖğrenme; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCatagory (CatagoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("katalog başarıyla eklendi");
            #endregion

            #region ürün ekleme
            //Console.Write("ürün giriniz:");
            //string productName = Console.ReadLine();
            //Console.Write("fiyatını giriniz:");
            //double productPrice = double.Parse(Console.ReadLine());
            //bool productStatue;

            //SqlConnection connection = new SqlConnection("Data Source= RUMEYSA\\SQLEXPRESS;initial catalog=c#DataBaseÖğrenme;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatu) values (@productName,@productPrice,@productStatue)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatue", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("işlem gerçekleştirildi");

            #endregion

            #region ürün listeleme
            //SqlConnection connection = new SqlConnection("Data Source=RUMEYSA\\SQLEXPRESS; initial Catalog= c#DataBaseÖğrenme; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item + " ");

            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region ürün silme



            //SqlConnection connection = new SqlConnection("Data Source= RUMEYSA\\SQLEXPRESS; initial Catalog = c#DataBaseÖğrenme; integrated security=true");
            //connection.Open();

            //SqlCommand cmd = new SqlCommand("select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item + " ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //Console.Write("silmek istediğiniz ürünü seçiniz:");
            //int productId = int.Parse(Console.ReadLine());


            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId= @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("işlem başarıyla gerçekleşti");


            #endregion

            #region ürün güncelleme işlemi bitmedi yarım kaldı
            //SqlConnection connection = new SqlConnection("Data Source= RUMEYSA\\SQLEXPRESS; initial Catalog = c#DataBaseÖğrenme; integrated security=true");
            //connection.Open();

            //SqlCommand cmd = new SqlCommand("select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item + " ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //Console.Write("güncellemek itediğniz ürününün numarasını giriniz:");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("güncellemek itediğniz ürününün ismini giriniz:");
            //string productName = Console.ReadLine();

            //Console.Write("güncellemek itediğniz ürününün fiyatını giriniz:");
            //int productPrice = int.Parse(Console.ReadLine());


            //SqlCommand command = new SqlCommand("Update TblProduct Where (ProductId,productName,productPrice) volues (@productId,@productNme,@productPrice)", connection);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.ExecuteNonQuery();



            //connection.Close();

            //Console.WriteLine("işlem başarıyla gerçekleşti.");

            #endregion

            Console.ReadLine();




        }
    }
}
