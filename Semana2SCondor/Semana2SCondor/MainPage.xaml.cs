using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana2SCondor
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string passwd)
        {
            InitializeComponent();
            lblUsuario.Text = "Bienbenido: " + usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double nParcial1 = Convert.ToDouble(txtDato1.Text);
                double examen1 = Convert.ToDouble(txtExamen1.Text);
                double nParcial2 = Convert.ToDouble(txtDato2.Text);
                double examen2 = Convert.ToDouble(txtExamen2.Text);
                double resultado = 0;
                string estado = "";

                if ((nParcial1 >= 0 && nParcial1 <= 10) && (examen1 >= 0 && examen1 <= 10) &&
                    (nParcial2 >= 0 && nParcial2 <= 10) && (examen2 >= 0 && examen2 <= 10))
                {
                    resultado = ((nParcial1 * 0.3) + (examen1 * 0.2)) + ((nParcial2 * 0.3) + (examen2 * 0.2));

                    if (resultado >= 7 && resultado <= 10)
                    {
                        estado = "Aprobado";
                    }
                    else if (resultado >= 5 && resultado < 7)
                    {
                        estado = "Suspenso";
                    }
                    else if (resultado >= 0 && resultado < 5)
                    {
                        estado = "Reprobado";
                    }

                    txtResultado.Text = resultado.ToString();

                    DisplayAlert("Mensaje de Alerta", estado, "Aceptar");
                }
                else
                {
                    estado = "Algunos valores no corresponden al rango entre 0 y 10, porfavor reemplazarlos.";
                    DisplayAlert("Mensaje de Alerta", estado, "Aceptar");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }
        }
    }
}
