using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ValentineCardUI.Views
{
    public partial class CardInfoPage : ContentPage
    {
        public CardInfoPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.CardsVIewModel();
        }
    }
}
