using AppFit.ViewModels;

namespace AppFit.Views;

public partial class ListaAtividade : ContentPage
{
	public ListaAtividade()
	{
		BindingContext = new ListaAtividadeViewModel();
		
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		var vm= (ListaAtividadeViewModel)BindingContext;
		vm.AtualizarLista.Execute(null);
	}
}