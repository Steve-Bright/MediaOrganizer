using System;


#pragma warning disable

namespace MediaOrganizer
{
     /// <summary>
     /// This is the Media Class containing 3 fields, each having its own property.
     /// </summary>
    public class Media
    {
        private string _title;
        private int _size;
        private MediaType _type;

         /// <summary>
         /// Media Constructor that requires three parameters
         /// </summary>
         /// <param name="title">Media's Name</param>
         /// <param name="size">Media Size</param>
         /// <param name="type">Media Type</param>
        public Media(string title, int size, MediaType type)
        {
            _title = title;
            _size = size;
            _type = type;
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
         /// Type property of Media Class
         /// </summary>
         /// <value>MediaType data type Media Type</value>
        public MediaType Type
        {
            get { return _type; }
        }

         /// <summary>
         /// Play method for Media class that returns respective value for each media type.
         /// </summary>
         /// <returns>Respective String value for each media type</returns>
        public string Play()
        {
            string message = null;
            switch (_type)
            {
                case MediaType.Audio:
                    message = "Ready for some light music!";
                    break;
                case MediaType.Video:
                    message = "Be entertained by the visual effect!";
                    break;
                case MediaType.Image:
                    message = "High resolution image provided!";
                    break;
            }
            return message;
        }
    }
}