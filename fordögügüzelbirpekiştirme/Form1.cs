namespace fordögügüzelbirpekiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt16(textBox1.Text);
            int bitis = Convert.ToInt16(textBox2.Text);
            
            int deger1 = 0;
            int deger2 = 0;

            for(int i = 0; i < baslangic; i++)
            {
                if(i % 2 == 1)
                {
                    deger1 = deger1 + i;
                }
            }
            for(int i = 0; i < bitis;i++)
            {
                if(i % 2 == 1)
                {
                    deger2 = deger2 + i;
                }
            }
            int toplam = deger1 + deger2;
            textBox3.Text = toplam.ToString();
        }
    }
}
