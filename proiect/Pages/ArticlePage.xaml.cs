namespace proiect.Pages;

public partial class ArticlePage : ContentPage
{
	public ArticlePage()
	{
		InitializeComponent();
	}

	private async void close_article_page_button_clicked(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}