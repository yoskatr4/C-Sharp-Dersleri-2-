namespace _1.ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMesajG�r�nt�le_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Ders 1 : GUI Tasar�m�";
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }

        private void comboBoxIsimler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekleIIsim_Click(object sender, EventArgs e)
        {
            comboBoxIsimler.Items.Add(textBoxMesaj.Text);
            listBoxDersler.Items.Add(textBoxMesaj.Text);
        }

        private void buttonLabelDe�i�tir_Click(object sender, EventArgs e)
        {
            labelYaz�lan�sim.Text = textBoxMesaj.Text;
        }

        private void listBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}