using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FloatButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this; //Setting binding context to that of the MainPage class itself so all classes flow through it
        }
        public ObservableCollection<Album> MyImages { get; set; } //Calling on datasheet again
    }

    public class Album
    {
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
