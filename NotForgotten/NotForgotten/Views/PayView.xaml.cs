using NotForgotten.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PayView : ContentPage
    {
        public PayView()
        {
            InitializeComponent();
            BindingContext = new PayViewModel(Navigation);
        }
    }
}