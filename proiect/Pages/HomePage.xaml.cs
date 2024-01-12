namespace proiect.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private async void open_article_page_button_clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new ArticlePage());
	}
}