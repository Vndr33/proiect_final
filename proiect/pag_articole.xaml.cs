namespace proiect;

public partial class pag_articole : ContentPage
{
    private readonly LocalDbService _localDbService;
    private int _editArticleId;
    
    public pag_articole(LocalDbService localDbService)
	{
		InitializeComponent();
        _localDbService = localDbService;
        Task.Run(async () => lista_articole.ItemsSource = await _localDbService.GetArticols());	
    }


    private async void editeaza_articol_button_clicked(object sender, EventArgs e)
    {

        
       // await Navigation.PushAsync(new pag_detalii(_localDbService));
    }

    //private async void sterge_articol_button_clicked(object sender, ItemTappedEventArgs e)
    //{
    //    var articol = (Articol)e.Item;
    //    var action = await DisplayActionSheet("Sigur doriti sa stergeti articolul? ", "Cancel", null, "Sterge articolul");

    //    switch (action)
    //    {
    //        case "Sterge articolul":
    //            await _localDbService.Delete(articol);
    //            lista_articole.ItemsSource = await _localDbService.GetArticols();
    //            break;
    //    }
    //}
    private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var articol = (Articol)e.Item;
        var action = await DisplayActionSheet("Doresti sa iti editezi pagina de jurnal? ", "Anulati", null, "Editez pagina", "Sterg pagina");

        switch (action)
        {
            case "Editez pagina":
                _editArticleId = articol.Id_articol;
                var editArticleTitlu = articol.Titlu;
                var editArticolAutor = articol.Autor;
                var editArticolContinut = articol.Continut;
                await Navigation.PushAsync(new pag_detalii(_localDbService, _editArticleId, editArticleTitlu, editArticolAutor, editArticolContinut));


                break;
            case "Sterg pagina":
                await _localDbService.Delete(articol);
                lista_articole.ItemsSource = await _localDbService.GetArticols();
                break;
        }


    }
}