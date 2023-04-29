# C-Sharp-Dersleri-2-
## İlk Proje Örneği

## Tasarım
![image](https://user-images.githubusercontent.com/124431035/235318454-ba7a944b-4c0d-4298-ac62-6c5a20edcba1.png)

## Kodlar
<pre>
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

        private void buttonMesajGörüntüle_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Ders 1 : GUI Tasarımı";
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

        private void buttonLabelDeğiştir_Click(object sender, EventArgs e)
        {
            labelYazılanİsim.Text = textBoxMesaj.Text;
        }

        private void listBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
</pre>

## İşlevi

• Mesaj yaz butonuna basınca 'Ders 1 : GUI Tasarımı' diye yazdırıyor

• Sil butonuna basınca yazılan yazıyı siliyor

• Ekle butou TextBox'a yazılan şeyi comboBox'a ve listBox'a ekler 

• Label Değiştir butonuna basınca TextBox'a yazılan şeyi label1'e yazdırır
