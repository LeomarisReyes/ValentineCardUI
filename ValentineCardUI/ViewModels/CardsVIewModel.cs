using System;
using System.Collections.ObjectModel;
using ValentineCardUI.Models;

namespace ValentineCardUI.ViewModels
{
    public class CardsVIewModel
    {
        public ObservableCollection<Cards> cards { get; set; }

        public CardsVIewModel()
        {
            cards = new ObservableCollection<Cards>
            {
                new Cards { Picture = "Card1" },
                new Cards { Picture = "Card2" },
                new Cards { Picture = "Card1" },
                new Cards { Picture = "Card2" }
            };
        }
    }
}
