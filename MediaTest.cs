using System;
using NUnit.Framework;

namespace MediaOrganizer
{
    [TestFixture()]
    public class MediaOrganizerTest
    {
        [Test()]
        public void AudioEnumTest()
        {
            MediaType audioType = MediaType.Audio;
            Media newMedia = new Media("Test Audio Media", 20, audioType);

            string playMsg = newMedia.Play();

            Assert.AreEqual(playMsg, "Ready for some light music!");
        }

        [Test()]
        public void VideoEnumTest()
        {
            // MediaType videoType = 
            Media newMedia = new Media("Test Video Media", 300, MediaType.Video);

            string playMsg = newMedia.Play();

            Assert.AreEqual(playMsg, "Be entertained by the visual effect!");

        }

        [Test]
        public void ImageEnumTest()
        {
            Media newMedia = new Media("Test Image Media", 300, MediaType.Image);

            string playMsg = newMedia.Play();

            Assert.AreEqual(playMsg, "High resolution image provided!");

        }

        [Test()]
        public void MediaChangeTitleTest()
        {
            Media newMedia = new Media("Test Media", 40, MediaType.Video);

            Assert.AreEqual(newMedia.Title, "Test Media");

            newMedia.Title = "Test Media Edited";

            Assert.AreEqual(newMedia.Title, "Test Media Edited");

        }
    }
}