using MateusGenius.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MateusGenius
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      InitializeControls();
    }

    private void InitializeControls()
    {
      SimonButton btnAzul = new SimonButton()
      {
        Id = 1,
        BackgroundColor = Color.FromHex("#3F51B5"),
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Command = new Command(() =>
        {
          DependencyService.Get<IAudio>().PlayMp3File(1, "test1");
        })
      };

      SimonButton btnVermelho = new SimonButton()
      {
        Id = 2,
        BackgroundColor = Color.FromHex("#F34336"),
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Command = new Command(() =>
        {
          DependencyService.Get<IAudio>().PlayMp3File(2, "test2");
        })
      };

      SimonButton btnVerde = new SimonButton()
      {
        Id = 3,
        BackgroundColor = Color.FromHex("#009688"),
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Command = new Command(() =>
        {
          DependencyService.Get<IAudio>().PlayMp3File(3, "test3");
        })
      };
      SimonButton btnAmarelo = new SimonButton()
      {
        Id = 4,
        BackgroundColor = Color.FromHex("#FEC007"),
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Command = new Command(() =>
        {
          DependencyService.Get<IAudio>().PlayMp3File(4,"test4");
        })
      };

      StackLayout stackTop = new StackLayout()
      {
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Orientation = StackOrientation.Horizontal
      };

      StackLayout stackBottom = new StackLayout()
      {
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Orientation = StackOrientation.Horizontal
      };

      stackTop.Children.Add(btnAzul);
      stackTop.Children.Add(btnAmarelo);
      stackBottom.Children.Add(btnVerde);
      stackBottom.Children.Add(btnVermelho);

      var mainStack = new StackLayout()
      {
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Orientation = StackOrientation.Vertical
      };
      mainStack.Children.Add(stackTop);
      mainStack.Children.Add(stackBottom);

      this.Content = mainStack;
    }
  }
}
