

namespace proiect
{
    public partial class AppShell : Shell
    {
        private LocalDbService _localDbService_shell;

        //private readonly LocalDbService _localDbService_shell;
        public AppShell()
        {
            InitializeComponent();
           _localDbService_shell = new LocalDbService();
        }

        private async void open_welcome_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pag_welcome());
        }
        private async void open_articole_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pag_articole(_localDbService_shell));
        }
        private async void open_my_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pag_my_page(_localDbService_shell));
        }
        private async void open_about_us_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pag_about_us());
        }
        
    }
}
