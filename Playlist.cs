using System;

namespace MediaOrganizer
{
    /// <summary>
    /// Plalist Class to manage Media objects (add, remove, get) into PlayList and PlayDateTime.
    /// </summary>
    public class Playlist
    {
        private List<Media> _mediaList;
        private DateTime _playDateTime;

        /// <summary>
        /// Playlist Constructor that requires DateTime type parameter 
        /// </summary>
        /// <param name="dateTime">Datetime when the playlist to be played.</param>
        public Playlist(DateTime dateTime)
        {
            _mediaList = new List<Media>();
            _playDateTime = dateTime;

        }

        /// <summary>
        /// Playlist Constructor with no parameter. Since DateTime is not provided,
        /// Default Datetime after an hour will be initialized.
        /// </summary>
        public Playlist() : this(DateTime.Now.AddHours(1))
        {

        }

        /// <summary>
        /// PlayDateTime property (Set and Get)
        /// </summary>
        /// <value>DateTime data type Playlist's playtime</value>
        public DateTime PlayDateTime
        {
            get { return _playDateTime; }
            set { _playDateTime = value; }
        }

        /// <summary>
        /// Add Media to playlist. Requires Media Object to be added.
        /// </summary>
        /// <param name="media">Media type object</param>
        public void AddMedia(Media media)
        {
            _mediaList.Add(media);
        }

        /// <summary>
        /// Remove Media from playlist. Requires Media Object be removed.
        /// </summary>
        /// <param name="media">Media type object</param>
        public void RemoveMedia(Media media)
        {
            _mediaList.Remove(media);
        }

        /// <summary>
        /// Number of medias listed in playlist.
        /// </summary>
        /// <value>Integer type number of medias</value>
        public int MediaCount
        {
            get { return _mediaList.Count; }
        }

        /// <summary>
        /// Get the specific media from media lists of playlist. Index number as integer type is required.
        /// </summary>
        public Media this[int i]
        {
            get { return _mediaList[i]; }
        }

        /// <summary>
        /// Print full details from playlist. If the media playdatetime is less than 10 minutes,
        /// full details will be printed otherwise, playlist is not ready.
        /// </summary>
        /// <returns>Boolean datatype that indicates whether playlist is printed successfully or not.</returns>
        public bool PrintDetails()
        {
            if (!(_playDateTime.AddMinutes(-10) > DateTime.Now))
            {
                Console.WriteLine("Playtime: {0}", _playDateTime.ToString(@"MM\/dd\/yyyy HH:mm"));
                foreach (Media eachMedia in _mediaList)
                {
                    Console.WriteLine("========================");
                    Console.WriteLine("Media Title: {0}", eachMedia.Title);
                    Console.WriteLine("Media Size: {0}", eachMedia.Size);
                    Console.WriteLine("Media Type: {0}", eachMedia.Type);
                    Console.WriteLine();
                }
                return true;
            }
            else
            {
                Console.WriteLine("The playlist is not ready!");
                Console.WriteLine();
                return false;
            }
        }
    }
}