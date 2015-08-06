using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using zumomusicstore.ViewModels;

namespace zumomusicstore.Views
{
    public partial class AlbumDetailsView : ContentPage
    {
        public AlbumDetailsView(AlbumDetailsViewModel viewModel)
        {
            this.BindingContext = viewModel;

            InitializeComponent();
        }
    }
}
