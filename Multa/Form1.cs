namespace Multa
{
    public partial class FrmMultas : Form
    {
        public FrmMultas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void FrmMultas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //capturando los datos
            string placa = txtPlaca.Text;
            double velocidad = double.Parse(txtVelocidad.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime hora = DateTime.Parse(lblHora.Text);

            //PROCESANDO

            double multa = 0;
            if (velocidad <= 70)
                multa = 0;
            else if (velocidad > 70 && velocidad <= 99)
                multa = 120;
            else if (velocidad > 100)
                multa = 350;


            //IMPRIMIENDO RESULTADOS 

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(velocidad.ToString("0.00"));
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lblHora.Text);
            fila.SubItems.Add(multa.ToString("C"));
            lvMulta.Items.Add(fila);

        }

        ListViewItem item;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvMulta_MouseClick(object sender, MouseEventArgs e)
        {
            item = lvMulta.GetItemAt(e.X, e.Y);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(item != null)
            {
                lvMulta.Items.Remove(item);
                MessageBox.Show("LA MULTA HA SIDO ELIMINADA CORRECTAMENTE");

            }
            else
            {
                MessageBox.Show("DEBE SELECIONAR UNA MULTA DE LA LISTA");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR?",
                                 "MEDIDAS",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}