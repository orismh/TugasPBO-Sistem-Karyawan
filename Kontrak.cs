namespace SistemKaryawan;

public class Kontrak : Karyawan
{
    public int Durasi { get; set; }

    public Kontrak(string nama, double gaji, int durasi) : base(nama, gaji)
    {
        Durasi = durasi;
    }

    public string CekKontrak()
    {
        return Durasi > 0
            ? $"Kontrak {Nama} masih aktif, sisa {Durasi} bulan."
            : $"Kontrak {Nama} sudah berakhir.";
    }

    public override void Kerja()
    {
        Console.WriteLine($"{Nama} (Karyawan Kontrak) sedang bekerja sesuai durasi kontrak.");
    }

    public override void InfoKaryawan()
    {
        base.InfoKaryawan();
        Console.WriteLine($"Durasi    : {Durasi} bulan");
        Console.WriteLine($"Status    : {CekKontrak()}");
    }
}
