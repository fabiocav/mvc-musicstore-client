using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zumomusicstore.Models;

namespace zumomusicstore.ViewModels
{
    public class AlbumDetailsViewModel : ViewModel
    {
        private Album album;

        public AlbumDetailsViewModel(Album album)
        {
            this.album = album;
            MainText = this.album.Title;
        }

        public string MainText { get; set; }

        public string ArtistName
        {
            get
            {
                return this.album.ArtistName;
            }
        }

        public string Price
        {
            get
            {
                return string.Format("{0:c}", this.album.Price);
            }
        }

        public string GenreName
        {
            get
            {
                return this.album.GenreId.ToString();
            }
        }

        public string AlbumArtUrl
        {
            get
            {
                return this.album.AlbumArtUrl;
            }
        }
    }
}
