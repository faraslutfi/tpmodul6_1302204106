using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - 1302204106");
        video.PrintVideoDetails();

        Console.ReadLine(); // supaya console ga ketutup
    }
}