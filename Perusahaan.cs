namespace SistemKaryawan;

public class Perusahaan
{
    private readonly List<Karyawan> _daftarKaryawan = new();

    public void TambahKaryawan(Karyawan karyawan)
    {
        _daftarKaryawan.Add(karyawan);
        Console.WriteLine($"Ditambahkan: {karyawan.Nama}");
    }

    public void DaftarKaryawan()
    {
        Console.WriteLine("\n=== DAFTAR KARYAWAN PERUSAHAAN ===");
        if (_daftarKaryawan.Count == 0)
        {
            Console.WriteLine("Belum ada karyawan.");
            return;
        }

        int no = 1;
        foreach (var k in _daftarKaryawan)
        {
            Console.WriteLine($"\n-- Karyawan #{no++} --");
            k.InfoKaryawan();
            k.Kerja();
        }
        Console.WriteLine("\nTotal karyawan: " + _daftarKaryawan.Count);
    }

    public IReadOnlyList<Karyawan> SemuaKaryawan => _daftarKaryawan;
}
