using Module7DataAccess.Services;
using Module7DataAccess.ViewModel;

namespace Module7DataAccess.View;

public partial class ViewPersonal : ContentPage
{
	public ViewPersonal()
	{
		InitializeComponent();

		var personalViewModel = new PersonalViewModel();
		BindingContext = personalViewModel;
	}
}