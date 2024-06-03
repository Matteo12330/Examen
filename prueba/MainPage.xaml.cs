using Microsoft.Maui.Controls;

namespace prueba
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnRechargeClicked(object sender, EventArgs e)
        {
            // Aquí implementa la lógica para realizar la recarga
            ConfirmationLabel.Text = $"Recarga de {AmountPicker.SelectedItem} realizada con éxito.";
        }
    }
}
