namespace proiect;

public partial class pag_my_page : ContentPage
{
	private readonly LocalDbService _localDbService;
	private int _editArticleId;
	public pag_my_page(LocalDbService localDbService)
	{
		InitializeComponent();
		_localDbService = localDbService;
	//	Task.Run(async () => lista_articole.ItemsSource = await _localDbService.GetArticols());	
	}

	private async void save_new_article_clicked( object sender, EventArgs e)
	{
		if(_editArticleId == 0)
		{
			
			await _localDbService.Create(new Articol
			{
				Titlu = titlu_entry_field.Text,
				Autor = autor_entry_field.Text,
				Continut = continut_entry_field.Text
			});
				
		}
		else
		{
			await _localDbService.Update(new Articol
			{
				Id_articol = _editArticleId,
				Titlu = titlu_entry_field.Text,
				Autor = autor_entry_field.Text,
				Continut = continut_entry_field.Text
			});

			_editArticleId = 0;
		}

		titlu_entry_field.Text = string.Empty;
		autor_entry_field.Text= string.Empty;
		continut_entry_field.Text=string.Empty;

		//lista_articole.ItemsSource = await _localDbService.GetArticols();
		Console.WriteLine("am ajuns aici");
	}

	private async void open_edit_page_clicked(object sender, EventArgs e)
	{

	}
}      