using System;

namespace MediaOrganizer
{
    public class Video : Media
    {
        private bool _availability;

        /// <summary>
        /// Child class of Media.
        /// </summary>
        /// <param name="title">Name of Video - String</param>
        /// <param name="size">Size of Video - Integer</param>
        public Video(string title, int size) : base(title, size)
        {
            _availability = false;
        }

        /// <summary>
        /// Availability Property
        /// </summary>
        /// <value>Boolean value whether the Video is available to play</value>
        public bool Availability
        {
            set { _availability = value; }
            get { return _availability; }
        }

        /// <summary>
        /// Overriden Play Method of Media. Returns the conditional message based on availability.
        /// </summary>
        /// <returns>Returns message of whether video is ready to play or not.</returns>
        public override string Play()
        {
            //tenary conditional
            return _availability ? "Video is now ready to play" : "Video unavailable.";
        }
    }
}