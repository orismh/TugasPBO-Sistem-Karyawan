using SistemKaryawan;

Console.WriteLine("SISTEM KARYAWAN");

var pt = new Perusahaan();

var manager = new Manager("Budi", 10000000, 2000000);
var staff = new Staff("Andi", 6000000, 500000);
var magang = new Magang("Citra", 2000000, 6);
var freelancer = new Freelancer("Deni", 8000000, 3);

Console.WriteLine("--- Menambahkan karyawan ---");
pt.TambahKaryawan(manager);
pt.TambahKaryawan(staff);
pt.TambahKaryawan(magang);
pt.TambahKaryawan(freelancer);

pt.DaftarKaryawan();

Console.WriteLine("\n=== DEMO POLYMORPHISM ===");
foreach (Karyawan k in pt.SemuaKaryawan)
{
    k.Kerja();
}

Console.WriteLine("\n=== METHOD KHUSUS ===");
manager.Memimpin();
staff.KerjakanTugas();
magang.Belajar();
freelancer.AmbilProyek("Website Company Profile");
Console.WriteLine($"Total gaji manager: Rp {manager.HitungGajiTotal():N0}");
Console.WriteLine(magang.CekKontrak());
