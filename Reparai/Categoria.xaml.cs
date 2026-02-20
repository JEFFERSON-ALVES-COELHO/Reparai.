using System.Collections.ObjectModel;
using System.Linq;

namespace Reparai.Views
{
    public partial class CategoriaPage : ContentPage
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public CategoriaPage()
        {
            InitializeComponent();

            Categorias = new ObservableCollection<Categoria>
            {
                new Categoria { Nome = "Buraco na via", Descricao = "Problemas em ruas e avenidas" },
                new Categoria { Nome = "Iluminação pública", Descricao = "Postes apagados ou quebrados" },
                new Categoria { Nome = "Lixo irregular", Descricao = "Descarte incorreto de resíduos" },
                new Categoria { Nome = "Sinalização", Descricao = "Placas ou faixas danificadas" },
                new Categoria { Nome = "Calçada", Descricao = "Buracos ou obstáculos" },
                new Categoria { Nome = "Outros", Descricao = "Outros tipos de problemas" }
            };

            CategoriasCollection.ItemsSource = Categorias;
        }


        private async void OnCategoriaSelecionada(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Categoria categoria)
            {
                await DisplayAlertAsync("Categoria selecionada", $"Você escolheu: {categoria.Nome}", "OK");

                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }

    public class Categoria
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}