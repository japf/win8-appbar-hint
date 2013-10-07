using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Japf.Win8.AppBarHint.Demo.Controls
{
    public class AppBarHint : Button
    {
        protected override void OnTapped(TappedRoutedEventArgs e)
        {
            base.OnTapped(e);

            if (Window.Current.Content is Frame)
            {
                var frame = (Frame) Window.Current.Content;
                if (frame.Content is Page)
                {
                    var page = (Page) frame.Content;
                    if (page.BottomAppBar != null)
                    {
                        page.BottomAppBar.IsOpen = true;
                    }
                }
            }
        }
    }
}
