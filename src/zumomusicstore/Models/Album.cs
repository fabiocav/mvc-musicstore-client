using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zumomusicstore.Models
{
    public class Album
    {
        public string Id { get; set; }

        public int GenreId { get; set; }

        public string ArtistId { get; set; }

        public string ArtistName { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }
    }
}
