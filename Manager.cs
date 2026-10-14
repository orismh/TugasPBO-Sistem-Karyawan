namespace SistemKaryawan;

public class Manager : Tetap
{
    public Manager(string nama, double gaji, double tunjangan) : base(nama, gaji, tunjangan) { }

    public void Memimpin()
    {
        Console.WriteLine($"{Nama} sedang memimpin tim dan mengambil keputusan strategis.");
    }

    public override void Kerja()
    {
        Console.WriteLine($"{Nama} (Manager) sedang memimpin, mengoordinasi, dan mengawasi karyawan.");
    }
}
