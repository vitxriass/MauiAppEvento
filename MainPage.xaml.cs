using MauiAppEvento.Confirmar;


using MauiAppEvento.model;

namespace MauiAppEvento
{
    public partial class MainPage : ContentPage
    {
        App PropriedadesApp;

        public MainPage()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_locais.ItemsSource = PropriedadesApp.Lista_Locais;

            dtpck_inicio.MinimumDate = DateTime.Now;
            dtpck_inicio.MaximumDate = DateTime.Now.AddDays(1);

            dtpck_fim.MinimumDate = dtpck_inicio.Date.AddDays(1);
            dtpck_fim.MaximumDate = dtpck_inicio.Date.AddMonths(6);
        }

        private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_inicio = elemento.Date;

            dtpck_fim.MinimumDate = data_selecionada_inicio.AddDays(1);
            dtpck_fim.MaximumDate = data_selecionada_inicio.AddMonths(6);
        }

        private async void Btn_avancar_Clicked(object sender, EventArgs e)
        {
            {
                try
                {
                    contas h = new contas
                    {
                        LocalSelecionado = (Locais)pck_locais.SelectedItem,
                        QntParticipantes = Convert.ToInt32(stp_participante.Value),
                        Datainicio = dtpck_inicio.Date,
                        Datafim = dtpck_fim.Date,
                    };

                    await Navigation.PushAsync(new PaginaDados()

                    { BindingContext = h });
                }
                catch (Exception ex)

                { await DisplayAlert("Ops", ex.Message, "OK"); }
            }
        }
    }
}