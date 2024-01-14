namespace Prueba
{
    public partial class Form1 : Form
    {
        public int progress;
        public Form1()
        {
            InitializeComponent();
            progress = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (progress >= 10 && progress <= 100)
            {
                progress -= 10;
                progressBar1.Value = progress;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            while(progress < 100) 
            {
                progress += 10;
                progressBar1.Value = progress;
            }
        }
    }
}