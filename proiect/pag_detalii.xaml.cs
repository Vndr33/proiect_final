namespace proiect;

public partial class pag_detalii : ContentPage
{
    private readonly LocalDbService _localDbService;
    private int _editArticleId;
    private string _editArticleTitlu;
    private string _editArticleAutor;
    private string _editArticleContinut;

    public pag_detalii(LocalDbService localDbService, int id_primit, string titlu_primit, string autor_primit, string continut_primit)
	{
		InitializeComponent();
        _localDbService = localDbService;
        _editArticleId = id_primit;
        _editArticleTitlu = titlu_primit;
        _editArticleAutor = autor_primit;
        _editArticleContinut = continut_primit;
        //Task.Run(async () => lista_articole_edit.ItemsSource = await _localDbService.GetArticols());

        titlu_entry_field.Text = _editArticleTitlu;
        autor_entry_field.Text = _editArticleAutor;
        continut_entry_field.Text = _editArticleContinut;
    }

    private async void save_update_article_clicked(object sender, EventArgs e)
    {
       
        await _localDbService.Update(new Articol
        {
            Id_articol = _editArticleId,
            Titlu = titlu_entry_field.Text,
            Autor = autor_entry_field.Text,
            Continut = continut_entry_field.Text
        });

        await Navigation.PushAsync(new pag_articole(_localDbService));
    }

    private async void no_save_update_article_clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}