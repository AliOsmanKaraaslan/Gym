namespace Gym
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // FormClosing olay�n� elle ba�layal�m
            this.FormClosing += Form1_FormClosing;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // E�er Form1 kapan�yorsa, di�er t�m formlar� kapat�yoruz.
            Application.Exit();  // Uygulamay� sonland�r�r, t�m formlar kapan�r
        }

    }
}
