namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Location = new Point(20, 10);
            this.txtNombre.Text = "Soy un string";
            this.txtNombre.Width = 220;
            this.txtNombre.TextAlign = HorizontalAlignment.Right;
            this.btnPulsar.BackColor = Color.Fuchsia;
            //
        }
    }
}
