using System;
using System.Collections.Generic;

class VuKhi
{
    public string Ten { get; set; }
    public int SatThuong { get; set; }
    public VuKhi(string ten, int satThuong)
    {
        Ten = ten;
        SatThuong = satThuong;
    }
    public void TanCong()
    {
        Console.WriteLine($"Vu khi {Ten} gay ra {SatThuong} sat thuong!");
    }
}

class Program
{
    static void Main()
    {
        List<VuKhi> khoVuKhi = new List<VuKhi>();
        int tongSatThuong = 0;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Nhap vu khi thu {i}");
            Console.Write("Nhap ten vu khi: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap sat thuong: ");
            int satThuong = int.Parse(Console.ReadLine());
            VuKhi vk = new VuKhi(ten, satThuong);
            khoVuKhi.Add(vk);
            tongSatThuong += satThuong;
            Console.WriteLine();
        }

        Console.WriteLine(" DANH SACH VU KHI");
        foreach (VuKhi vk in khoVuKhi)
        {
            vk.TanCong();
        }
        Console.WriteLine(" Tong sat thuong cua vu khi: " + tongSatThuong);
    }
}
