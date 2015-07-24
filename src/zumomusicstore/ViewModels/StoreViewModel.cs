using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zumomusicstore.Models;

namespace zumomusicstore.ViewModels
{
    public class StoreViewModel : ViewModel
    {
        private IList<Genre> genres;

        public StoreViewModel()
        {
            MainText = "Zumo Music Store";

            PopularAlbums = new List<Album>
            {
                new Album
                {
                    Title ="Exister",
                    ArtistId ="1",
                    ArtistName ="Hot water music",
                    GenreId =1,
                    AlbumArtUrl ="http://www.heartbeatmedia.de/wp-content/uploads/2012/03/HWM_Exister.jpg",
                    Id ="1",
                    Price =9.99m
                },
                new Album
                {
                    Title ="Hang",
                    ArtistId ="2",
                    ArtistName ="Lagwagon",
                    GenreId =1,
                    AlbumArtUrl ="http://www.hitthefloor.com/wp-content/uploads/2014/10/lagwagon.jpg",
                    Id ="2",
                    Price =9.99m
                }
            };

            Genres = new List<Genre>
            {
                new Genre
                {
                    Id = "1",
                    Name = "Punk rock",
                    Description = "The only genre that matters."
                },
                new Genre
                {
                    Id = "2",
                    Name = "Metal",
                    Description = "Guys with high pitched voices and tight pants."
                }
            };
        }

        public string MainText { get; set; }

        public IList<Album> PopularAlbums { get; set; }

        public IList<Genre> Genres
        {
            get
            {
                return genres;
            }

            set
            {
                this.genres = value;
            }
        }
    }
}
