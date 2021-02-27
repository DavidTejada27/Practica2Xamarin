using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace practica2Xamarin.ViewModels
{

    public class MenuOption 
    {
        public string Title { get; set; }
        public ImageSource Image { get; set; }
        public string Place { get; set; }
    }

    public class MainViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();


        public MainViewModel()
        {
            BarAndHotelsMenuOption.Title = "Bar and Hotels";
            BarAndHotelsMenuOption.Image = "BeerImage";
            BarAndHotelsMenuOption.Place = "42 place";

            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "DinnerImage";
            FineDiningMenuOption.Place = "15 place";

            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "StoreFrontImage";
            CafesMenuOption.Place = "28 place";

            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "MapImage";
            NearbyMenuOption.Place = "34 place";

            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "FastFoodImage";
            FastFoodsMenuOption.Place = "29 place";

            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "PizzaImage";
            FeaturedFoodsMenuOption.Place = "21 place";
        }
    }
}
