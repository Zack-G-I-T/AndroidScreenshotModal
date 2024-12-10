namespace AndroidScreenshotBug
{
    public partial class ThirdPage : ContentPage
    {
        int count = 0;

        public ThirdPage()
        {
            InitializeComponent();
        }

        private async void GoBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }

}
