namespace AndroidTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count += 10;

            if (count == 1)
                CounterBtn.Text = $"На кнопку нажали {count} раз";
            else
                CounterBtn.Text = $"На кнопку нажали {count} раз"; 

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void NewPageBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage2());
        }

        private void ProjectWindow_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DNA());

        }
    }

}
