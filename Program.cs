using System;
using SplashKitSDK;

namespace MediaOrganizer
{
    public class Program
    {
        public static void Main()
        {
            Media[] allMedias =
            {
                new Audio("One Day", 20, "JB", "Best playlist", 120),
                new Video("Terminator", 2000),
                new Image("Animal", 10, 100, 100)
            };
            PlayAll(allMedias);
        }

        public static void PlayAll(Media[] allMedias)
        {
            foreach (Media eachMedia in allMedias)
            {
                Console.WriteLine("Title:{0}", eachMedia.Title);
                Console.WriteLine("Size:{0}", eachMedia.Size);
                Console.WriteLine("MediaType: {0}", eachMedia.GetType().Name); //GetType() returns the package name. MediaOrganizer.DerivedClass
                Console.WriteLine("{0}\n", eachMedia.Play());
            }
        }
    }
}
