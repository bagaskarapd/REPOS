namespace TugasOOP1
{
    public class pasien
    {
        public string ID; //enkapitulasi
        public string Nama;
        public int Umur;
        public string Alamat;
        public virtual void Data()//virtual parent
        {
            Console.WriteLine("==================");
            Console.WriteLine("ID              :" + ID);
            Console.WriteLine("Nama            :" + Nama);
            Console.WriteLine("Umur            :" + Umur);
            Console.WriteLine("Alamat          :" + Alamat);
        }
    }
    public class Dokter : pasien//inheritance
    {
        public string Jenis;
        public override void Data()//polymorphsm override child
        {
            base.Data();
            Console.WriteLine("Jenis Dokter   :" + Jenis);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            pasien Budi = new pasien();
            Budi.ID = "001";
            Budi.Nama = "Budi Man";
            Budi.Umur = 23;
            Budi.Alamat = "Jakarta";

            Budi.Data();

            Dokter Cahyadi = new Dokter();
            Cahyadi.ID = "001";
            Cahyadi.Nama = "Cahyadi";
            Cahyadi.Umur = 25;
            Cahyadi.Alamat = "Jakarta";
            Cahyadi.Jenis = "Dokter Umum";
            Cahyadi.Data();
        }
    }
}
