using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace StanAplikacjiXAML
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<string> outputItems = new ObservableCollection<string>();
        public MainPage()
        {
            this.InitializeComponent();
            output.ItemsSource = outputItems;
        }
        private void Ellipse_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Ellipse");
            if (ellipseSetsHandled.IsOn) e.Handled = true;
        }

        private void Rectangle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Rectangle");
            if (rectangleSetsHandled.IsOn) e.Handled = true;
        }

        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Grid");
            if (gridSetsHandled.IsOn) e.Handled = true;
        }

        private void Border_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Border");
            if (borderSetsHandled.IsOn) e.Handled = true;
        }

        private void Stack_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę StackPanel");
        }

        private void UpdateHitTestButton(object sender, RoutedEventArgs e)
        {
            grayRectangle.IsHitTestVisible = newHitTestVisableValue.IsOn;
        }

        private void borderSetsHandled_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private void gridSetsHandled_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private void ellipseSetsHandled_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private void rectangleSetsHandled_Toggled(object sender, RoutedEventArgs e)
        {

        }

       /* private void UpdateHitTestButton(object sender, RoutedEventArgs e)
        {

        }*/

        private void newHitTestVisableValue_Toggled(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
