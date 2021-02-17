using System;

namespace Netflix
{
    class Program
    {
        private static string onemounth;

        static void Main(string[] args)
        {
            Console.WriteLine("Hi Friends this is app for video!");
            Console.WriteLine("First pleas enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Your username is: " + userName);
            Console.WriteLine("Now can you write what style of music you listen:");
            string music = Console.ReadLine();
            Console.WriteLine("So your favourite style of music is: " + music);
            Console.WriteLine("Now can you write what kind of films you watch:");
            string films = Console.ReadLine();
            Console.WriteLine("So your favourite kind of films is: " + films);

            Video Video1 = new Video();
            Console.WriteLine(Video1);

            VIDEOuser mariya = new VIDEOuser();
            VIDEOuser aleks = new VIDEOuser();
            VIDEOuser vladi = new VIDEOuser();
            vladi.Username = "vladi";
            mariya.Username = "marcheto";
            aleks.Username = "aleks";
            Video Sucker = new Video();
            Sucker.Name = "Sucker";
            Video TheWitch = new Video();
            TheWitch.Name = "TheWitch";

            Sucker.Like(aleks);
            Sucker.Like(mariya);
            Sucker.Like(vladi);
            TheWitch.Like(aleks);
            TheWitch.Unlike(mariya);
            TheWitch.Like(vladi);
            Console.ReadLine();
        }
    }
}
