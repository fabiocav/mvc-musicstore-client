using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using zumomusicstore.ViewModels;

namespace zumomusicstore.Views
{
    public partial class StoreView : ContentPage
    {
        public StoreView(StoreViewModel viewModel)
        {
            this.BindingContext = viewModel;

            ToolbarItems.Add(new ToolbarItem { Name = "Home", Order = ToolbarItemOrder.Primary, Command = null }))
            InitializeComponent();
        }
    }
}
