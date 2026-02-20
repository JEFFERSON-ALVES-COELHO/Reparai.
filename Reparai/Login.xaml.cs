using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Maui.Controls;

namespace Reparai
{
    partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }
        async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Cadastro");
        }

    }
}