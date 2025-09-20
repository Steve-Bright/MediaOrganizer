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
            Media mediaOne = new Media("One more Time", 30, MediaType.Audio);
            Media mediaTwo = new Media("Mount Everest", 20, MediaType.Image);
            Playlist playlistOne = new Playlist();

            //add
            playlistOne.AddMedia(mediaOne);
            playlistOne.AddMedia(mediaTwo);

            //test
            Assert.AreEqual(playlistOne.MediaCount, 2);
        }

        [Test()]
        public void RemoveMediaTest()
        {
            //initialize
            Media mediaOne = new Media("One more Time", 30, MediaType.Audio);
            Media mediaTwo = new Media("Mount Everest", 20, MediaType.Image);
            Playlist playlistOne = new Playlist();

            playlistOne.AddMedia(mediaOne);
            playlistOne.AddMedia(mediaTwo);
            playlistOne.RemoveMedia(mediaOne);

            Assert.AreEqual(playlistOne.MediaCount, 1);
        }

        [Test()]
        public void GetMediaTest()
        {
            //initialize
            Media mediaOne = new Media("One more Time", 30, MediaType.Audio);
            Media mediaTwo = new Media("Mount Everest", 20, MediaType.Image);
            Playlist playlistOne = new Playlist();

            playlistOne.AddMedia(mediaOne);
            playlistOne.AddMedia(mediaTwo);

            Assert.AreEqual(playlistOne[0], mediaOne);
            Assert.AreEqual(playlistOne[1], mediaTwo);
        }

        [Test()]
        public void PrintDetailsTest()
        {
            Playlist playlistOne = new Playlist();
            Media mediaOne = new Media("One more Time", 30, MediaType.Audio);
            playlistOne.AddMedia(mediaOne);

            bool printResult = playlistOne.PrintDetails();
            Assert.AreEqual(printResult, false);

            playlistOne.PlayDateTime = DateTime.Now.AddMinutes(10);
            bool printResultTwo = playlistOne.PrintDetails();
            Assert.AreEqual(printResultTwo, true);
        }
    }
}