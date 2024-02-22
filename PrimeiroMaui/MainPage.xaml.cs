namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double c = Convert.ToDouble(txt_c.Text);

            double delta;
            double result1;
            double result2;

            delta = b * b - (4 * a * c);

            double valorraiz = Math.Sqrt(delta);

           if(valorraiz > 0)
            {
                result1 = ((b - (b * 2)) + valorraiz) / (2 * a);
                result2 = ((b - (b * 2)) - valorraiz) / (2 * a);

                string msg = $"O resultado de X1 é {result1}, O resultado de X2 é {result2} ";

                DisplayAlert("Valor Raiz", msg, "Fechar");
          
            }
            else
            {
                string msg = "Número sem raíz";
                DisplayAlert("Valor Raíz", msg, "Fechar");
            }
           

           

        }
    }

}
