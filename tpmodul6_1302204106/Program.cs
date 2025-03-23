using System;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - 1302204106");

            // Looping untuk tes validasi, pastikan angkanya sesuai batas
            for (int i = 0; i < 3; i++)
            {
                video.IncreasePlayCount(5000000); // Gunakan angka yang valid
            }

            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi error: {ex.Message}");
        }

        Console.ReadLine(); // supaya console ga ketutup
    }
}
