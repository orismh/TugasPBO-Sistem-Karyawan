namespace SistemKaryawan;

public class Magang : Kontrak
{
    public Magang(string nama, double gaji, int durasi) : base(nama, gaji, durasi) { }

    public void Belajar()
    {
        Console.WriteLine($"{Nama} sedang belajar dan mendapatkan pengalaman kerja.");
    }

    public override void Kerja()
    {
        Console.WriteLine($"{Nama} (Magang) sedang belajar sambil bekerja.");
    }
}
