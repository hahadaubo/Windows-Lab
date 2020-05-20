using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataprovider
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.ListThucUong();

            //Console.WriteLine("Nhap Ma So Hang Hoa: ");
            //string mshh = Console.ReadLine();
            //Console.WriteLine("Nhap Ten Hang Hoa: ");
            //string tenHH = Console.ReadLine();
            //Console.WriteLine("Nhap Gia Hang Hoa: ");
            //int gia = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap Tinh Trang Hang Hoa: ");
            //int tinhtrang = int.Parse(Console.ReadLine());

            //dataProvider.ThemMoiThucUong(mshh, tenHH, gia, tinhtrang);
            //dataProvider.ListThucUong();

            //Console.WriteLine("Nhap Ma So Hang Hoa Can Xoa: ");
            //mshh = Console.ReadLine();
            //dataProvider.XoaThucUong(mshh);
            //dataProvider.ListThucUong();

            //Console.Write("== Chinh Sua Hang Hoa == ");
            //Console.WriteLine("Nhap Ma So Hang Hoa Can Chinh Sua: ");
            //string mshh = Console.ReadLine();
            //Console.WriteLine("Nhap Ma So Hang Hoa Moi: ");
            //string mshhnew = Console.ReadLine();
            //Console.WriteLine("Nhap Ten Hang Hoa Moi: ");
            //string tenHH = Console.ReadLine();
            //Console.WriteLine("Nhap Gia Hang Hoa Moi: ");
            //int gia = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap Tinh Trang Hang Hoa Moi: ");
            //int tinhtrang = int.Parse(Console.ReadLine());
            //dataProvider.ChinhSuaThucUong(mshh,mshhnew, tenHH, gia, tinhtrang);
            //dataProvider.ListThucUong();

            //dataProvider.ListHoaDon();

            //dataProvider.ListHoaDonChiTietDatHang();

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString());

            Console.WriteLine("Vui long nhap ma so don hang");
            string msdh = Console.ReadLine();
            dataProvider.TaoHoaDon(msdh, DateTime.Now);
            dataProvider.ListHoaDon();

            Console.Write("Danh Sach Thuc Uong");
            dataProvider.ListThucUong();
            Console.WriteLine("Vui long nhap ma so thuc uong ma ban muon dat");
            string mshh = Console.ReadLine();
            Console.WriteLine("Nhap So Luong");
            int soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ti Le Giam");
            int tileGiam = int.Parse(Console.ReadLine());

            dataProvider.TaoHoaDonChiTiet(msdh, mshh, soLuong, tileGiam);
            dataProvider.ListHoaDonChiTietDatHang();

            Console.ReadKey();
        }
    }
}
