using GuyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        private Guy guy1;
        private Guy guy2;

        public Form1()
        {
            InitializeComponent();
            guy1 = new Guy() { Name = "John", Cash = 3000 };
            guy2 = new Guy() { Name = "Bob", Cash = 5000 };
            UpdateScreen();
        }

        private void guy1GiveButton_Click(object sender, EventArgs e)
        {
            guy2.ReceiveCash(guy1.GiveCash(600));
            UpdateScreen();
        }

        private void guy2GiveButton_Click(object sender, EventArgs e)
        {
            guy1.ReceiveCash(guy2.GiveCash(1200));
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            this.guy1Name.Text = guy1.Name;
            this.guy1Cash.Text = guy1.Cash.ToString();
            this.guy2Name.Text = guy2.Name;
            this.guy2Cash.Text = guy2.Cash.ToString();
        }
    }
}