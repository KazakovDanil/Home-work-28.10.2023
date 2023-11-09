using System;

namespace Laboratory_work
{
    class Song
    {
        private string song_name;
        private string song_author;
        private Song previous_song;

        public Song(string song_name, string song_author, Song previous_song)
        {
            this.song_name = song_name;
            this.song_author = song_author;
            this.previous_song = previous_song;
        }

        public Song(string song_name, string song_author)
        {
            this.song_name = song_name;
            this.song_author = song_author;
            previous_song = null;
        }

        public Song()
        {
            song_name = "Не указано";
            song_author = "Не указано";
            previous_song = null;
        }
        public string SongName
        {
            get
            {
                return song_name;
            }
        }

        public string SongAuthor
        {
            get
            {
                return song_author;
            }
        }

        public Song PreviousSong
        {
            get
            {
                return previous_song;
            }
        }

        public string Title
        {
            get
            {
                return song_name + " " + song_author;
            }
        }

        public override bool Equals(object transmitted_song)
        {
            Song song = transmitted_song as Song;

            if ((song != null) && (song.SongName == song_name) && (song.SongAuthor == song_author))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
