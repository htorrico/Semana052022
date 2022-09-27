using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana052022
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.dtpFechaNacimiento.Date = DateTime.Today;
            this.dtpFechaNacimiento.MaximumDate = DateTime.Today;
        }
    }
}
