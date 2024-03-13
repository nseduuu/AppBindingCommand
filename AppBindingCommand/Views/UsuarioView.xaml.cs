using AppBindingCommand.ViewModels;

namespace AppBindingCommand.Views;

public partial class UsuarioView : ContentPage
{
	public UsuarioView() 
	{
		InitializeComponent();
		BindingContext = new UsuarioViewModel();
	}
}