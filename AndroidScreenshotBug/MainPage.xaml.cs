namespace AndroidScreenshotBug
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

#if ANDROID
            var activity = Platform.CurrentActivity;
            activity?.Window?.SetFlags(Android.Views.WindowManagerFlags.Secure, Android.Views.WindowManagerFlags.Secure);
#endif
        }

        private async void OpenModalClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SecondPage");
        }

        private async void OpenNonModalClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ThirdPage");
        }
    }

}
