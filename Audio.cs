using System;

namespace MediaOrganizer
{
    public class Audio : Media
    {
        private string _artist;
        private string _album;
        private int _duration;

        /// <summary>
        /// Child class of Media.
        /// </summary>
        /// <param name="title">Name of Audio - String</param>
        /// <param name="size">Size of Audio - Integer</param>
        /// <param name="artist">Artist of Audio - String</param>
        /// <param name="album">Album of Audio - String</param>
        /// <param name="duration">Duration of Audio - Integer</param>
        public Audio(string title, int size, string artist, string album, int duration) : base(title, size)
        {
            _artist = artist;
            _album = album;
            _duration = duration;
        }

        /// <summary>
        /// Arist read-only property
        /// </summary>
        /// <value>Artist of Audio - String</value>
        public string Artist
        {
            get { return _artist; }
        }

        /// <summary>
        /// Album read-only property
        /// </summary>
        /// <value>Album of Audio - String </value>
        public string Album
        {
            get { return _album; }
        }

        /// <summary>
        /// Duration read-only property
        /// </summary>
        /// <value>Duration of Audio - String</value>
        public int Duration
        {
            get { return _duration; }
        }

        /// <summary>
        /// Overriden Play Method of Media. Returns all its attributes once this is called.
        /// </summary>
        /// <returns>All attribute values of created Audio object - String</returns>
        public override string Play()
        {
            string audioInfo = "AudioInfo\n=====================\n";
            string artistInfo = "Artist: " + _artist + "\n";
            string albumInfo = "Album: " + _album + "\n";
            string durationInfo = "Duration: " + _duration + "\n";

            return audioInfo + artistInfo + albumInfo + durationInfo;
        }
    }
}