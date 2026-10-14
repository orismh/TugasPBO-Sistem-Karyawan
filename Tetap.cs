namespace SistemKaryawan;

public class Tetap : Karyawan
{
    public double Tunjangan { get; set; }

    public Tetap(string nama, double gaji, double tunjangan) : base(nama, gaji)
    {
        Tunjangan = tunjangan;
    }

    public double HitungGajiTotal() => Gaji + Tunjangan;

    public override void Kerja()
    {
        Console.WriteLine($"{Nama} (Karyawan Tetap) sedang bekerja penuh waktu.");
    }

    public override void InfoKaryawan()
    {
        base.InfoKaryawan();
        Console.WriteLine($"Tunjangan : Rp {Tunjangan:N0}");
        Console.WriteLine($"Total Gaji: Rp {HitungGajiTotal():N0}");
    }
}
