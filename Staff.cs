namespace SistemKaryawan;

public class Staff : Tetap
{
    public Staff(string nama, double gaji, double tunjangan) : base(nama, gaji, tunjangan) { }

    public void KerjakanTugas()
    {
        Console.WriteLine($"{Nama} sedang mengerjakan tugas operasional yang diberikan.");
    }

    public override void Kerja()
    {
        Console.WriteLine($"{Nama} (Staff) sedang melaksanakan tugas harian.");
    }
}
