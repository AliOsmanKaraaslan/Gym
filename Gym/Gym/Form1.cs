namespace Gym
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // FormClosing olayýný elle baðlayalým
            this.FormClosing += Form1_FormClosing;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // Eðer Form1 kapanýyorsa, diðer tüm formlarý kapatýyoruz.
            Application.Exit();  // Uygulamayý sonlandýrýr, tüm formlar kapanýr
        }

    }
}
