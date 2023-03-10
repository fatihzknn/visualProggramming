namespace fati
{
    public partial class Form1 : Form
    {
        List<Kitap> list = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Kitap Kodu";
            dataGridView1.Columns[1].Name = "Kitap Adı";
            dataGridView1.Columns[2].Name = "Yazar";
            dataGridView1.Columns[3].Name = "Sayfa Sayısı";
            dataGridView1.Columns[4].Name = "Tipi";
            dataGridView1.Columns[5].Name = "Ödünç Alan Kişi";
        }
    }
}