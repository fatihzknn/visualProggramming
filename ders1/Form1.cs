namespace ders1
{
    public partial class Form1 : Form
    {
        int[] notlar = new int[5];
        int indexim = 0;
        int total = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(indexim > 4)
            {
                MessageBox.Show("Arrayde yer kalmadı");
            }
            else
            {
                notlar[indexim] = Convert.ToInt32(textBox1.Text);

                indexim++;
            }
            
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for(int i = 0; i < notlar.Length; i++)
            {
                
                total += notlar[i];
                
            }
            double ortalama = total / notlar.Length;
            MessageBox.Show("Ortalama = " + ortalama);
        }
    }
}