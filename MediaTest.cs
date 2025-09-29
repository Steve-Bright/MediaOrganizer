using System;
using NUnit.Framework;

namespace MediaOrganizer
{
    [TestFixture()]
    public class MediaOrganizerTest
    {
        [Test()]
        public void AudioClassTest()
        {
            Audio newAudio = new Audio("Despacito", 30, "JB", "Top 2017", 120);

            string audioInfo = "AudioInfo\n=====================\n";
            string artistInfo = "Artist: " + newAudio.Artist + "\n";
            string albumInfo = "Album: " + newAudio.Album + "\n";
            string durationInfo = "Duration: " + newAudio.Duration + "\n";
            string finalMsg = audioInfo + artistInfo + albumInfo + durationInfo;

            Assert.AreEqual(newAudio.Play(), finalMsg);
        }

        [Test()]
        public void VideoClassTest()
        {
            Video newVideo = new Video("Despacito Music Video", 30);

            Assert.AreEqual(newVideo.Play(), "Video unavailable.");

        }

        [Test]
        public void ImageEnumTest()
        {
            Image newImage = new Image("Mountain Scene", 30, 300, 300);
            int totalPixels = newImage.PixelsInHeight * newImage.PixelsInWidth;

            Assert.AreEqual(newImage.Play(), totalPixels.ToString());

        }

        [Test()]
        public void MediaChangeTitleTest()
        {
            Video newMedia = new Video("Test Media", 40);

            Assert.AreEqual(newMedia.Title, "Test Media");

            newMedia.Title = "Test Media Edited";

            Assert.AreEqual(newMedia.Title, "Test Media Edited");

        }
    }
}