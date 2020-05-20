using System;
using System.Data.SqlClient;

namespace Dataprovider
{
    public class DataProvider
    {
        private static readonly string connectionString =
          "Data Source=MSI;Initial Catalog=QLQuan;Integrated Security=True;";

        public DataProvider() { }

        public void ListThucUong()
        {
            string queryString =
                     "SELECT * From ThucUong";

            int paramValue = 5;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int ThemMoiThucUong(string MSHH, string TenHangHoa, int Gia, int TinhTrang)
        {
            string queryString =
               "insert into ThucUong(MSHH,TenHang,Gia,TinhTrang)"
               + "Values(@MSHH,@TenHangHoa,@Gia,@TinhTrang);";

            String mshh = MSHH;
            String tenHH = TenHangHoa;
            int gia = Gia;
            int tinhtrang = TinhTrang;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", mshh);
                command.Parameters.AddWithValue("@TenHangHoa", tenHH);
                command.Parameters.AddWithValue("@Gia", gia);
                command.Parameters.AddWithValue("@TinhTrang", tinhtrang);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;
        }

        public int XoaThucUong(string MSHH)
        {
            string queryString =
               "DELETE FROM ThucUong WHERE MSHH=@MSHH";

            String mshh = MSHH;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", mshh);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;
        }

        public int ChinhSuaThucUong(string MSHH, string newMSHH, string TenHangHoa, int Gia, int TinhTrang)
        {
            string queryString =
               "UPDATE ThucUong SET MSHH = @newMSHH,TenHang = @TenHangHoa,Gia = @Gia,TinhTrang = @TinhTrang "
               + "WHERE MSHH=@MSHH;";

            String mshh = MSHH;
            String mshhnew = newMSHH;
            String tenHH = TenHangHoa;
            int gia = Gia;
            int tinhtrang = TinhTrang;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", mshh);
                command.Parameters.AddWithValue("@newMSHH", mshhnew);
                command.Parameters.AddWithValue("@TenHangHoa", tenHH);
                command.Parameters.AddWithValue("@Gia", gia);
                command.Parameters.AddWithValue("@TinhTrang", tinhtrang);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;
        }

        public void ListHoaDon()
        {
            string queryString =
                     "SELECT * From HoaDon";

            int paramValue = 5;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t\t\t{1}",
                            reader[0], reader[1]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ListHoaDonChiTietDatHang()
        {
            string queryString =
                     "SELECT * From HDChiTietDatHang";

            int paramValue = 5;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void TaoHoaDon(string MSDH,DateTime dateTime)
        {
            string queryString =
                 "Insert into HoaDon(MSDH,NgayDat)"
               + "Values(@MSDH,@NgayDat);";

            String msdh = MSDH;
            String ngayDat = dateTime.ToString();

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", msdh);
                command.Parameters.AddWithValue("@NgayDat", ngayDat);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void TaoHoaDonChiTiet(string MSDH, string MSHH,int SoLuong,int TiLeGiam)
        {
            string queryString =
                 "Insert into HoaDon(MSDH, MSHH, SoLuong, TiLeGiam)"
               + "Values (@MSDH, @MSHH, @SoLuong, @TiLeGiam);";

            String msdh = MSDH;
            String mshh = MSHH;
            int soLuong = SoLuong;
            int tileGiam = TiLeGiam;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", msdh);
                command.Parameters.AddWithValue("@MSHH", mshh);
                command.Parameters.AddWithValue("@SoLuong", soLuong);
                command.Parameters.AddWithValue("@TiLeGiam", tileGiam);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
