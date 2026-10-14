namespace SistemKaryawan;

public class Freelancer : Kontrak
{
    public Freelancer(string nama, double gaji, int durasi) : base(nama, gaji, durasi) { }

    public void AmbilProyek(string namaProyek)
    {
        Console.WriteLine($"{Nama} mengambil proyek: {namaProyek}.");
    }

    public override void Kerja()
    {
        Console.WriteLine($"{Nama} (Freelancer) sedang menyelesaikan proyek secara mandiri.");
    }
}
