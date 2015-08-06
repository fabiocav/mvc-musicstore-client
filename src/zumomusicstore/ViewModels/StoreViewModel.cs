using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using zumomusicstore.Models;
using zumomusicstore.Views;

namespace zumomusicstore.ViewModels
{
    public class StoreViewModel : ViewModel
    {
        private IList<Genre> genres;
        private IList<Album> popularAlbums;
        private MobileServiceClient client;

        public StoreViewModel()
        {
            this.client = new MobileServiceClient(
                Constants.ApplicationURL,
                Constants.GatewayURL,
                Constants.ApplicationKey,new Handler());

            initializeViewModel();

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

            //Genres = new List<Genre>
            //{
            //    new Genre
            //    {
            //        Id = "1",
            //        Name = "Punk rock",
            //        Description = "The only genre that matters."
            //    },
            //    new Genre
            //    {
            //        Id = "2",
            //        Name = "Metal",
            //        Description = "Guys with high pitched voices and tight pants."
            //    }
            //};
        }

        internal void NavigateToAlbum(INavigation navigation, Album album)
        {
            navigation.PushAsync(new AlbumDetailsView(new AlbumDetailsViewModel(album)));
        }
        

        private async void initializeViewModel()
        {
            // Call popular records API
            var albums = await this.client.InvokeApiAsync<IList<Album>>("AlbumApi/GetPopularAlbums", HttpMethod.Get, null);

            PopularAlbums = albums;
            // Get genres
            var genres = await this.client.GetTable<Genre>().ReadAsync();

            Genres = genres.ToList();
        }

        public string MainText { get; set; }

        

        public IList<Genre> Genres
        {
            get
            {
                return genres;
            }

            set
            {
                this.genres = value;
                OnPropertyChanged();
            }
        }

        public IList<Album> PopularAlbums
        {
            get
            {
                return popularAlbums;
            }
            set
            {
                this.popularAlbums = value;
                OnPropertyChanged();
            }
        }
    }


    public class Handler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Debug.WriteLine(request.RequestUri);

            return base.SendAsync(request, cancellationToken);
        }
    }
}
