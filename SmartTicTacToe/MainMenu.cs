using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTicTacToe
{
    public partial class MainMenu : Form
    {
        public static MainMenu instance;
        public MainMenu()
        {
            InitializeComponent();
            instance = this;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "RandomComputer" || textBox2.Text == "SmartComputer")
                textBox2.Text = "";

            TicTacToe ticTacToe = new TicTacToe(textBox1.Text, textBox2.Text);
            ticTacToe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicTacToe ticTacToe = new TicTacToe(textBox1.Text, "RandomComputer");
            ticTacToe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            TicTacToe ticTacToe = new TicTacToe(textBox1.Text, "SmartComputer");
            ticTacToe.Show();
        }
    }
}
