namespace ControlesTipoVista.Views;

public partial class CarouselView_Vista : ContentPage
{
	public CarouselView_Vista()
	{
		InitializeComponent();
	}

    private void CarouselView_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
		//colocar el codigo a ejecutar
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        bool isToggled = e.Value;
        carouselView.EmptyView = isToggled ? Resources["VistaVaciaBasica"] : Resources["VistaVaciaAvanzada"];
    }
}