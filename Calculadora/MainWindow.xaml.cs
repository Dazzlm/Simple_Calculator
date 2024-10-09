using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Decimal numero = 0m;
        Decimal total = 0m;
        Decimal temp = 0m;
        int digitos = 0;
        bool sw = true;
        bool swIgual = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button != null) { 
                
               
                if (digitos < 15)
                {
                    
                    if (button.Content.ToString() != "0" || digitos > 0)
                    {
                        if (digitos == 0)
                        {
                            Pantalla.Text = "";
                        }

                        Pantalla.Text += button.Content.ToString();
                        numero = decimal.Parse(Pantalla.Text.ToString());
                        if (digitos > 10)
                        {
                            Pantalla.FontSize = Pantalla.FontSize - 5;
                        }
                        digitos++;

                    }
                    
                }
                
            }

        }

        private void Button_Igual(object sender, RoutedEventArgs e)

        {
            

            if (PantallaDos.Text.Contains('+'))
            {
                swIgual = true;
                Button_Suma(sender, e);
            }

            if (PantallaDos.Text.Contains('-'))
            {
                swIgual = true;
                Button_Resta(sender, e);
            }

            if (PantallaDos.Text.Contains('X'))
            {
                swIgual = true;
                Button_Mult(sender, e);
            }

            if (PantallaDos.Text.Contains('/'))
            {
                swIgual = true;
                Button_Dividir(sender, e);
            }



        }

        private bool verificarOp(char opV) {
            if (PantallaDos.Text == "")
            {
                PantallaDos.Text = Pantalla.Text + opV;
                return true;
            }
            else {
                char op = PantallaDos.Text[PantallaDos.Text.Length - 1];

                if (op == opV)
                {

                    return false;

                }
                else {
                    if (total != 0) {
                        return true;
                    }
                    else {
                        PantallaDos.Text = "";
                        sw = true;
                        return true;
                    }
                }

   
            }
        
        }

        private void Button_Suma(object sender, RoutedEventArgs e)
        {

            if (verificarOp('+'))
            {
                PantallaDos.Text = total.ToString() + " +";
                if (sw)
                {
                    PantallaDos.Text = Pantalla.Text + " +";
                    total = numero;
                    digitos = 0;
                    numero = 0m;

                    sw = false;
                }
            }

            

            if (swIgual)
            {
                temp = total;
                total = total + numero;
                PantallaDos.Text = temp.ToString() + " + " + numero.ToString() + " = " ;
                Pantalla.Text = total.ToString();
                digitos = 0;
                
            }
            else {
                
                if (digitos != 0)
                {
                    total = total + numero;
                    PantallaDos.Text = total.ToString() + " +";
                    Pantalla.Text = total.ToString();
                    digitos = 0;
                    
                }

            }
            swIgual = false;

        }
        private void Button_Resta(object sender, RoutedEventArgs e)
        {
            if (verificarOp('-'))
            {
                PantallaDos.Text = total.ToString() + " -";
                if (sw)
                {
                    PantallaDos.Text = Pantalla.Text + " -";
                    total = numero;
                    digitos = 0;
                    numero = 0m;

                    sw = false;
                }
            }

            if (swIgual)
            {
                temp = total;
                total = total - numero;
                PantallaDos.Text = temp.ToString() + " - " + numero.ToString() + " = " ;
                Pantalla.Text = total.ToString();
                digitos = 0;
                

            }
            else
            {

                if (digitos != 0)
                {
                    total = total - numero;
                    PantallaDos.Text = total.ToString() + " -";
                    Pantalla.Text = total.ToString();
                    digitos = 0;
                    
                }

            }

            swIgual = false;
        }

        private void Button_Mult(object sender, RoutedEventArgs e)
        {

            if (verificarOp('X'))
            {
                PantallaDos.Text = total.ToString() + " X";
                if (sw)
                {
                    PantallaDos.Text = Pantalla.Text + " X";
                    total = numero;
                    digitos = 0;
                    numero = 0m;

                    sw = false;
                }
            }

            if (swIgual)
            {
                temp = total;
                total = total * numero;
                PantallaDos.Text = temp.ToString() + " * " + numero.ToString() + " = ";
                Pantalla.Text = total.ToString();
                digitos = 0;
                

            }
            else
            {

                if (digitos != 0)
                {
                    total = total * numero;
                    PantallaDos.Text = total.ToString() + " *";
                    Pantalla.Text = total.ToString();
                    digitos = 0;
                    
                }

            }
            swIgual = false;

        }
        private void Button_Dividir(object sender, RoutedEventArgs e)
        {

            if (verificarOp('/'))
            {
                PantallaDos.Text = total.ToString() + " /";
                if (sw)
                {
                    PantallaDos.Text = Pantalla.Text + " /";
                    total = numero;
                    digitos = 0;
                    numero = 0m;

                    sw = false;
                }
            }

            if (swIgual)
            {
                temp = total;
                total = total / numero;
                PantallaDos.Text = temp.ToString() + " / " + numero.ToString() + " = ";
                Pantalla.Text = total.ToString();
                digitos = 0;
                

            }
            else
            {

                if (digitos != 0)
                {
                    total = total / numero;
                    PantallaDos.Text = total.ToString() + " /";
                    Pantalla.Text = total.ToString();
                    digitos = 0;
                    
                }

            }
            swIgual = false;

        }
        private void Button_Potencia(object sender, RoutedEventArgs e)
        {

        }
        
        private void Button_Porcentaje(object sender, RoutedEventArgs e)
        {

        }

        private void Button_BorrarCE(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = "0";
            Pantalla.FontSize = 65;
            digitos = 0;
            sw = true;
            swIgual = true;

        }
        private void Button_BorrarC(object sender, RoutedEventArgs e)
        {

            Pantalla.Text = "0";
            PantallaDos.Text = "";
            Pantalla.FontSize = 65;
            digitos = 0;
            numero = 0;
            total = 0;
            sw = true;

        }
        private void Button_Borrar(object sender, RoutedEventArgs e)
        {
            if (digitos > 0)
            {
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1);

                if (digitos > 10 && digitos < 15)
                {

                    Pantalla.FontSize = Pantalla.FontSize + 5;

                }

                digitos--;
                if (digitos == 0)
                {
                    Pantalla.Text = "0";


                }
            }
            else {
                if (Pantalla.Text != "" && Pantalla.Text != "0")
                {
                    Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1);

                    if (digitos > 10 && digitos < 15)
                    {

                        Pantalla.FontSize = Pantalla.FontSize + 5;

                    }

                    if (Pantalla.Text == "") {

                        Pantalla.Text = "0";

                    }
                }
                
            
            }
            
        }

    }
}