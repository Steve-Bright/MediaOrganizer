using System;

#pragma warning disable

namespace MediaOrganizer
{
     /// <summary>
     /// This is the Media Class containing 3 fields, each having its own property.
     /// </summary>
    public abstract class Media
    {
        private string _title;
        private int _size;

         /// <summary>
         /// Media Constructor that requires three parameters
         /// </summary>
         /// <param name="title">Media's Name</param>
         /// <param name="size">Media Size</param>
         /// <param name="type">Media Type</param>
        public Media(string title, int size)
        {
            _title = title;
            _size = size;
        }

         /// <summary>
         /// Title property of Media Class
         /// </summary>
         /// <value>String data type Media Title</value>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }


         /// <summary>
         /// Size property of Media Class
         /// </summary>
         /// <value>Integer data type Media Size</value>
        public int Size
        {
            set { _size = value; }
            get { return _size; }
        }

        /// <summary>
        /// Abstract method Play() that returns string data type
        /// </summary>
        /// <returns>String data type</returns>
        public abstract string Play();
    }
}