namespace AndroidScreenshotBug
{
    public partial class SecondPage : ContentPage
    {
        int count = 0;

        public SecondPage()
        {
            InitializeComponent();
        }

        private async void GoBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }

}
