using System;

namespace MediaOrganizer
{
    public class Image : Media
    {
        private int _pixelsInWidth;
        private int _pixelsInHeight;

        /// <summary>
        /// Child class of Media.
        /// </summary>
        /// <param name="title">Name of Image - String</param>
        /// <param name="size">Size of Image - Integer</param>
        /// <param name="widthPixels">Width of Image (Pixels) - Integer</param>
        /// <param name="heightPixels">Height of Image (Pixels) - Integer</param>
        public Image(string title, int size, int widthPixels, int heightPixels) : base(title, size)
        {
            _pixelsInWidth = widthPixels;
            _pixelsInHeight = heightPixels;
        }

        /// <summary>
        /// Pixel Width of Image Property
        /// </summary>
        /// <value>Integer value of Image width in pixels</value>
        public int PixelsInWidth
        {
            get { return _pixelsInWidth; }
        }

        /// <summary>
        /// Pixel Height of Image Property
        /// </summary>
        /// <value>Integer value of Image height in pixels</value>
        public int PixelsInHeight
        {
            get { return _pixelsInHeight; }
        }

          /// <summary>
        /// Overriden Play Method of Media. Returns the total pixel calculation.
        /// </summary>
        /// <returns>Returns the total pixels value by calculation.</returns>
        public override string Play()
        {
            int totalPixels = _pixelsInHeight * _pixelsInWidth;
            return totalPixels.ToString();

        }
    }
}