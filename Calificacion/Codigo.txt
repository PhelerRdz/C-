namespace Practica_1_Unidad_1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Calcular.Enabled = false;
            Resetear.Enabled = false;
            segundo.Enabled = false;
            tercero.Enabled = false;
            examen.Enabled = false;
            trabajo.Enabled = false;
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            decimal calif50 =(50*((decimal.Parse(primer.Text)+ decimal.Parse(segundo.Text)+ decimal.Parse(tercero.Text))/3))/100;
            decimal calif30 =(30*decimal.Parse(examen.Text))/100;
            decimal calif15 =(15*decimal.Parse(trabajo.Text)/100);
            final.Text = ""+(decimal.Round((calif50+calif30+calif15),2));
            if((decimal.Round((calif50 + calif30 + calif15), 2))>=(decimal)8.5)
            {
                beca.Text = "Se le Otorgara una Beca";
            }
            else
            {
                beca.Text = "NO Se le Otorgara una Beca";
            }
            Resetear.Enabled = true;
        }

        private void Resetear_Click(object sender, EventArgs e)
        {
            primer.Text = "";
            segundo.Text = "";
            tercero.Text = "";
            examen.Text = "";
            trabajo.Text = "";
            final.Text = "";
            Calcular.Enabled = false;
            Resetear.Enabled = false;
            segundo.Enabled = false;
            tercero.Enabled = false;
            examen.Enabled = false;
            trabajo.Enabled = false;
        }

        private void Adios_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KeyPresso(object sender, KeyPressEventArgs e)
        {
            String Aceptados = "0123456789.," + Convert.ToChar(8);

            if (Aceptados.Contains(""+e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void primer_TextChanged(object sender, EventArgs e)
        {
            segundo.Enabled = true;
        }

        private void segundo_TextChanged(object sender, EventArgs e)
        {
            tercero.Enabled = true;
        }

        private void tercero_TextChanged(object sender, EventArgs e)
        {
            examen.Enabled = true;
        }

        private void examen_TextChanged(object sender, EventArgs e)
        {
            trabajo.Enabled = true;
        }

        private void trabajo_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = true;
        }

        private void primer_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresso(primer, e);
        }

        private void segundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresso(segundo, e);
        }

        private void tercero_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresso(tercero, e);
        }

        private void examen_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresso(examen, e);
        }

        private void trabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPresso(trabajo, e);
        }
    }
}