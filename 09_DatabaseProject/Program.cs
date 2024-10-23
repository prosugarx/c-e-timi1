using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net sql i kullanmak için bir çerçeve

            Console.WriteLine("*****c# veri tabanlı ürün-kategori bilgi sistemi*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            string tableNumber;
            Console.WriteLine("1-kategori");
            Console.WriteLine("2-ürün");
            Console.WriteLine("3-siparişler");
            Console.WriteLine("4-çıkış yap");
            Console.Write("lütfen girmek istediğiniz tablo numarasını giriniz:");
            tableNumber = Console.ReadLine();
            Console.WriteLine("*******************************************************");

            SqlConnection connection= new SqlConnection("Data Source=RUMEYSA\\SQLEXPRESS; initial Catalog= c#DataBaseÖğrenme; integrated security=true");
            connection.Open();
            SqlCommand commend=new SqlCommand("Select * From TblCatagory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commend);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
