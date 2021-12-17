using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Card> cards = new List<Card>();

        private void addButton_Click(object sender, EventArgs e)
        {
            MakeNewCard();
        }

        private void viewPreviewButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void viewSelectButton_Click(object sender, EventArgs e)
        {

        }

        private void removeSelectButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        public void MakeNewCard()
        {
            if (nameInput.Text != "" && descripInput.Text != "")
            {
                string name = nameInput.Text;
                int health = Convert.ToInt32(healthInput.Value);
                int power = Convert.ToInt32(powInput.Value);
                string descrip = descripInput.Text;

                Card card = new Card(name, health, power, descrip);
                cards.Add(card);
                MessageBox.Show("Card made successfully.");
            }
            else if (nameInput.Text == "")
            {
                MessageBox.Show("No name was entered.", "Error");
            }
            else if (descripInput.Text == "")
            {
                MessageBox.Show("No description was entered.", "Error");
            }
        }
    }
}
