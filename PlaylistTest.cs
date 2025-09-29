using System;
using NUnit.Framework;

namespace MediaOrganizer
{
    [TestFixture()]
    public class PlaylistTest()
    {
        [Test()]
        public void AddMediaTest()
        {
            //initialize
            Audio mediaOne = new Audio("One Time", 30, "JB", "Top 2009", 120);
            Image mediaTwo = new Image("Mount Everest", 20, 500, 500);
            Video mediaThree = new Video("Test Media", 40);
            Playlist playlistOne = new Playlist();

            //add
            playlistOne.AddMedia(mediaOne);
            playlistOne.AddMedia(mediaTwo);
            playlistOne.AddMedia(mediaThree);

            //test
            Assert.AreEqual(playlistOne.MediaCount, 3);
        }

        [Test()]
        public void RemoveMediaTest()
        {
            //initialize
            Audio mediaOne = new Audio("One Time", 30, "JB", "Top 2009", 120);
            Image mediaTwo = new Image("Mount Everest", 20, 500, 500);
            Video mediaThree = new Video("Test Media", 40);
            Playlist playlistOne = new Playlist();

            playlistOne.AddMedia(mediaOne);
            playlistOne.AddMedia(mediaTwo);
            playlistOne.AddMedia(mediaThree);
            playlistOne.RemoveMedia(mediaOne);

            Assert.AreEqual(playlistOne.MediaCount, 2);
        }

        [Test()]
        public void GetMediaTest()
        {
            //initialize
            Audio mediaOne = new Audio("One Time", 30, "JB", "Top 2009", 120);
            Image mediaTwo = new Image("Mount Everest", 20, 500, 500);
            Video mediaThree = new Video("Test Media", 40);
            Playlist playlistOne = new Playlist();

            playlistOne.AddMedia(mediaOne);
            playlistOne.AddMedia(mediaTwo);
            playlistOne.AddMedia(mediaThree);

            Assert.AreEqual(playlistOne[0], mediaOne);
            Assert.AreEqual(playlistOne[1], mediaTwo);
            Assert.AreEqual(playlistOne[2], mediaThree);
        }

        [Test()]
        public void PrintDetailsTest()
        {
            Playlist playlistOne = new Playlist();
            Media mediaOne = new Audio("One Time", 30, "JB", "Top 2009", 120);
            playlistOne.AddMedia(mediaOne);

            bool printResult = playlistOne.PrintDetails();
            Assert.AreEqual(printResult, false);

            playlistOne.PlayDateTime = DateTime.Now.AddMinutes(10);
            bool printResultTwo = playlistOne.PrintDetails();
            Assert.AreEqual(printResultTwo, true);
        }
    }
}