namespace ders_03_03_2025_ornek_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Okulda 3 sınıf ve her sınıfta 5 öğrenci bulunmaktadır. Her öğrencinin ders notları okutulduğuna göre
            //aşağoda istenenleri bulunuz
            // 1. Bu 2 boyutlu diziyi yazdırınız

            const int SINIF_SAY = 3;
            const int OG_SAY = 5;
            
            int[,] notlar = new int[SINIF_SAY, OG_SAY];
            
            // 2 boyutlu dizinin yazdırılması
            for (int satir = 0; satir < SINIF_SAY; satir++)
            {
                for (int sutun = 0; sutun < OG_SAY; sutun++)
                {
                    Console.Write(notlar[satir, sutun]+ " ");
                }
                Console.WriteLine();
            }
            // Dizinin elemanlarının okutulması
            for (int satir = 0; satir < OG_SAY; satir++)
            {
                for (int sutun = 0; sutun < SINIF_SAY; sutun++)
                {
                    Console.Write(satir + " . Sınıfın" + sutun + ". Öğrencisinin notu: ");
                    notlar[satir, sutun] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            
        }
    }
}