using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BindablePicker
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            this.BindingContext = new StartPageViewModal();
        }
    }
}
