namespace ders_03_03_2025_ornek_03
{
    internal class Base
    {
        static void Main(string[] args)
        {
            Gameboard oyun = new Gameboard();
            oyun.PlayGame();
        }
        
    }

    internal class Gameboard
    {
        string[,] harita =
        {
            {"D","D","D","D","D"},
            {"D","A","A","D","G"},
            {"D","A","A","D","G"},
            {"D","A","D","D","G"},
            {"D","D","D","D","D"}
        };
        public void DisplayMap()
        {
            for (int i = 0; i < harita.GetLength(0);i++)
            {
                for(int j = 0; j < harita.GetLength(1); j++)
                {
                    Console.Write(harita[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void PlayGame()
        {
            while (true)
            {
                Console.WriteLine("lütfen Satır numarası Giriniz (0-4): ");
                int satir = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("lütfen Sütun numarası Giriniz (0-4): ");
                int sutun = Convert.ToInt32(Console.ReadLine());

                if (harita[satir, sutun] == "G")
                {
                    Console.WriteLine("Vurduk Düşmanı Kaptan!");
                    harita[satir, sutun] = "X";
                }
                else if (harita[satir, sutun] == "A")
                {
                    Console.WriteLine("Adayı vurdun Kaptan!!");
                    harita[satir, sutun] = "X";
                }
                else
                {
                    Console.WriteLine("Boşa attık kaptan!!");
                    harita[satir, sutun] = "O";
                }
            }
        }
    }
}