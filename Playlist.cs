using System;

namespace MediaOrganizer
{
    public class Playlist
    {
        private List<Media> _mediaList;
        private DateTime _playDateTime;

        //date time (year, month, day) (hour, minute, second)
        public Playlist(DateTime dateTime)
        {
            _mediaList = new List<Media>();
            _playDateTime = dateTime;

        }

        public Playlist() : this(DateTime.Now.AddHours(1))
        {

        }

        public DateTime PlayDateTime
        {
            get { return _playDateTime; }
            set { _playDateTime = value; }
        }

        public void AddMedia(Media media)
        {
            _mediaList.Add(media);
        }

        public void RemoveMedia(Media media)
        {
            _mediaList.Remove(media);
        }

        public int MediaCount
        {
            get { return _mediaList.Count; }
        }

        public Media this[int i]
        {
            get { return _mediaList[i]; }
        }

        public bool PrintDetails()
        {
            Console.WriteLine("Playtime: {0}", _playDateTime.ToString(@"MM\/dd\/yyyy HH:mm"));
            if (!(_playDateTime.AddMinutes(-10) > DateTime.Now))
            {
                Console.WriteLine("You only need 10 or less than 10 minutes!!");
            }
            else
            {
                Console.WriteLine("You need more than 10 minutes");
            }
            return true;
        }
    }
}