using System;

class QuaiVat
{
    public string Ten { get; set; }
    public int Mau { get; set; }
    public string MauSac { get; set; }

    public QuaiVat(string ten, int mau, string mauSac)
    {
        Ten = ten;
        Mau = mau;
        MauSac = mauSac;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, QuaiVat> dsQuaiVat = new Dictionary<string, QuaiVat>();

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Nhap quai vat thu {i}");

            Console.Write("Nhap ID: ");
            string id = Console.ReadLine();

            Console.Write("Nhap ten quai vat: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap mau (HP): ");
            int mau = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau sac: ");
            string mauSac = Console.ReadLine();
            dsQuaiVat.Add(id, new QuaiVat(ten, mau, mauSac));
            Console.WriteLine();
        }

        Console.Write("Nhap id quai vat can tim: ");
        string idTim = Console.ReadLine();
        if (dsQuaiVat.ContainsKey(idTim))
        {
            QuaiVat qv = dsQuaiVat[idTim];
            Console.WriteLine("Ten: " + qv.Ten);
            Console.WriteLine("Mau: " + qv.Mau);
            Console.WriteLine("Mau sac: " + qv.MauSac);
        }
        else
        {
            Console.WriteLine("Khong tim thay quai vat ???");
        }
    }
}
