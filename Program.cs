using System;
using SplashKitSDK;

namespace MediaOrganizer
{
    public class Program
    {
        public static void Main()
        {
            Playlist newPlaylist = new Playlist();
            Video newVideo = new Video("Test Media", 40); //need to initalize it with Video , Not Media. Otherwise, child's property won't be able to initiazlie.
            newVideo.Availability = true;
            Console.WriteLine("Hey {0}", newVideo.Availability);

            newPlaylist.AddMedia(newVideo);
            // newPlaylist.AddMedia(new Video("Test Media", 40));
            // if (newPlaylist[0] is Video)
            // {
            //     Video audioAgain = newPlaylist[0] as Video;
            //     //normally since this is list of Media, it doesn't allow access the items' property. So need to initialize it as a video again.
            //     audioAgain!.Availability = true;
            // }
            newPlaylist.AddMedia(new Image("Mount Everest", 20, 500, 500));
            newPlaylist.AddMedia(new Audio("One Time", 30, "JB", "Top 2009", 120));

            Console.WriteLine(newPlaylist[0].Play() + " \n");
            Console.WriteLine(newPlaylist[1].Play() + " \n");
            Console.WriteLine(newPlaylist[2].Play() + " \n");
            
            // Media[] allMedias =
            // {
            //     new Audio("One Day", 20, "JB", "Best playlist", 120),
            //     new Video("Terminator", 2000),
            //     new Image("Animal", 10, 100, 100)
            // };
            // PlayAll(allMedias);
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
