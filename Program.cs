using System;
using SplashKitSDK;

namespace MediaOrganizer
{
    public class Program
    {
        public static void Main()
        {
            MediaType audioType = MediaType.Audio;
            MediaType videoType = MediaType.Video;
            MediaType imageType = MediaType.Image;
            Media[] allMedias = 
            {
                new Media("One Day", 20, audioType),
                new Media("Terminator", 2000,  videoType),
                new Media("Animal", 10, imageType)
            };
            PlayAll(allMedias);
        }
        
        public static void PlayAll(Media[] allMedias){
            foreach (Media eachMedia in allMedias){
                Console.WriteLine("Title:{0}", eachMedia.Title);
                Console.WriteLine("Size:{0}", eachMedia.Size);
                Console.WriteLine("{0}\n",eachMedia.Play());
            }
        }
    }
}
