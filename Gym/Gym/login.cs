﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym {
    public partial class login : Form {
        public login() {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text == "admin" && textBox2.Text == "1234") {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

    }
}