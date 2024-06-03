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
            var phoneNumber = MRPhoneNumberEntry.Text;
            var selectedOperator = MROperatorPicker.SelectedItem?.ToString();
            var selectedAmount = MRAmountPicker.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(phoneNumber) || selectedOperator == null || selectedAmount == null)
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }
            var confirm = await DisplayAlert("Confirmación", $"¿Desea realizar la recarga de {selectedAmount} al número {phoneNumber} con el operador {selectedOperator}?", "Sí", "No");
            if (confirm)
            {
                MRConfirmationLabel.Text = $"Recarga de {selectedAmount} realizada con éxito.";
            }
        }
    }
}