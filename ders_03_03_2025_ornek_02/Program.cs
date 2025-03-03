namespace ders_03_03_2025_ornek_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bu program bir okulda bulunan 3 sınıftaki öğrencilerin notlarıyla ilgili işlemleri yapar.
            // Her sınıfta 5 öğrenci bulunduğu varsayılmaktadır.
            // Buna göre aşağıdaki istenenleri gerçekleştiriniz
            // 1. bu diziyi yazdırınız
            // 2. Her sınıfın not ortlamasını hesaplayıp yazdırınız.
            // 3. Her sınıfta bulunan 0.,1.,...numaralı öğrencilerin notlarından en büyük olanı bulup yazdırınız

            const int SINIF_SAY = 3;
            const int OG_SAY = 5;

            int[,] notlar =
            {
                { 60, 75, 80, 90, 100 },
                { 80, 80, 90, 70, 100 },
                { 95, 50, 70, 85, 90 }
            };
            for(int satir = 0; satir <  SINIF_SAY; satir++)
            {
                for (int sutun = 0; sutun < OG_SAY; sutun++)
                {
                    Console.Write(notlar[satir, sutun] + " ");
                }
                Console.WriteLine();
            }
            // Her sınıfın not = ortalamasını hesaplayıp yazdırınız.
            for(int satir = 0; satir< SINIF_SAY; satir++)
            {
                int toplam1 = 0;
                for (int sutun = 0; sutun < OG_SAY; sutun++)
                {
                    toplam1 = toplam1 + notlar[satir, sutun];
                }
                double ortalama1 = (double)toplam1 / OG_SAY;
                Console.WriteLine(satir + ". Sınıfın not ortalaması: " + ortalama1);
            }
            // Her sınıfta bulunan 0.,1.,...numaralı öğrencilerin notlarından en büyük olanı bulup yazdırınız
            for(int satir = 0; satir < SINIF_SAY; satir++)
            {
                int enBuyuk = notlar[satir, 0];
                for (int sutun = 1; sutun < OG_SAY; sutun++)
                {
                    if (notlar[satir, sutun] > enBuyuk)
                    {
                        enBuyuk = notlar[satir, sutun];
                    }
                }
                Console.WriteLine(satir + ". Sınıfın en büyük notu: " + enBuyuk);
            }
            //Okulun not ortalamasını hesaplayıp yazdırınız.
            int toplam2 = 0;
            for(int satir = 0; satir < SINIF_SAY; satir++)
            {
                for (int sutun = 0; sutun < OG_SAY; sutun++)
                {
                    toplam2 = toplam2 + notlar[satir, sutun];
                }
            }
            double ortalama2 = (double)toplam2 / (SINIF_SAY * OG_SAY);
            Console.WriteLine("Okul Ortolaması: " + ortalama2);

        }
  
    }

}