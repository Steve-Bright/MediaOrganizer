using System;

namespace MediaOrganizer
{
    public class Media
    {
        private string _title;
        private int _size;
        private MediaType _type;

        public Media(string title, int size, MediaType type){
            _title = title;
            _size = size;
            _type = type;
        }

        public string Title{
            set{_title = value;}
            get{return _title;}
        }

        public int Size{
            set{_size = value;}
            get{return _size;}
        }

        public MediaType Type{
            get{return _type;}
        }

        public string Play(){
            string message = null;
            switch(_type){
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