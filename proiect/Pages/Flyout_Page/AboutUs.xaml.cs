namespace proiect.Pages.Flyout_Page;

public partial class AboutUs : FlyoutPage
{
	public AboutUs()
	{
		InitializeComponent();
	}

    private async void open_article_page_button_clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ArticlePage());
    }

    private async void open_random_page_button_clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new HomePage());
    }
}