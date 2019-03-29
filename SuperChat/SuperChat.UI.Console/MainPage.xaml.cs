using System.Diagnostics;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using SuperChat.Business;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SuperChat.UI.Console
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == "" || PasswordPasswordBox.Password == "")
            {
                UsernameTextBox.BorderBrush = UsernameTextBox.Text == "" ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.DarkGray);
                PasswordPasswordBox.BorderBrush = PasswordPasswordBox.Password == "" ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.DarkGray);
            }
            else
            {
                this.Frame.Navigate(typeof(Chats));
            }
        }
    }
}
