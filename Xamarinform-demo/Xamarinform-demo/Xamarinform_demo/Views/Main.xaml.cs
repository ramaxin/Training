using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarinform_demo.ViewModels;

namespace Xamarinform_demo.Views
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
