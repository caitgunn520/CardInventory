using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

/// <summary>
/// Developer: Cait Morgan
/// Date: December 12, 2022
/// Description: To hold an inventory of playing cards. 
/// </summary>

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
            ViewCard(nameInput.Text, descripInput.Text, Convert.ToInt32(healthInput.Value), Convert.ToInt32(powInput.Value));
        }

        //Each card's information is saved to an xml file. 
        private void saveButton_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("cardInfo.xml");

            writer.WriteStartElement("Deck");
            
            foreach (Card card in cards)
            {
                writer.WriteStartElement("Card");

                writer.WriteElementString("name", card.name);
                writer.WriteElementString("descrip", card.descrip);
                writer.WriteElementString("health", Convert.ToString(card.health));
                writer.WriteElementString("power", Convert.ToString(card.power));

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }

        //Reads xml file and adds described cards to list. 
        private void loadButton_Click(object sender, EventArgs e)
        {
            string newName, newDescrip;
            int newHealth, newPower;
            
            XmlReader reader = XmlReader.Create("cardInfo.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newName = reader.ReadString();

                    reader.ReadToNextSibling("descrip");
                    newDescrip = reader.ReadString();

                    reader.ReadToNextSibling("health");
                    newHealth = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("power");
                    newPower = Convert.ToInt32(reader.ReadString());

                    Card c = new Card(newName, newHealth, newPower, newDescrip);
                    cards.Add(c);
                }
            }
        }

        private void viewSelectButton_Click(object sender, EventArgs e)
        {
            //Searches for card written in selectInput. Returns an error if card doesn't exist or if selectInput is empty. 
            if (selectInput.Text != "")
            {
                int index = cards.FindIndex(n => n.name == selectInput.Text);

                if (index >= 0)
                {
                    ViewCard(cards[index].name, cards[index].descrip, cards[index].health, cards[index].power);
                }
                else
                {
                    MessageBox.Show("That card does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please select a card to view.", "Error");
            }
        }

        private void removeSelectButton_Click(object sender, EventArgs e)
        {
            if (selectInput.Text != "")
            {
                int index = cards.FindIndex(n => n.name == selectInput.Text);

                if (index >= 0)
                {
                    cards.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("That card does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please select a card to remove.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Card> searchResults = new List<Card>();

            cardList.Text = "";
            
            ///Uses input from checkboxes to see which conditions to search for.
            ///If no conditions are selected, shows all cards. 
            if (nameSearchTrue.Checked == true)
            {
                if (healthSearchTrue.Checked == true)
                {
                    if (powerSearchTrue.Checked == true)
                    {
                        searchResults = cards.FindAll(x => x.name == nameSearch.Text && x.health == healthSearch.Value 
                        && x.power == powerSearch.Value);
                    }
                    else
                    {
                        searchResults = cards.FindAll(x => x.name == nameSearch.Text && x.health == healthSearch.Value);
                    }
                }
                else
                {
                    if (powerSearchTrue.Checked == true)
                    {
                        searchResults = cards.FindAll(x => x.name == nameSearch.Text && x.power == powerSearch.Value);
                    }
                    else
                    {
                        searchResults = cards.FindAll(x => x.name == nameSearch.Text);
                    }
                }
            }
            else
            {
                if (healthSearchTrue.Checked == true)
                {
                    if (powerSearchTrue.Checked == true)
                    {
                        searchResults = cards.FindAll(x => x.health == healthSearch.Value && x.power == powerSearch.Value);
                    }
                    else
                    {
                        searchResults = cards.FindAll(x => x.health == healthSearch.Value);
                    }
                }
                else
                {
                    if (powerSearchTrue.Checked == true)
                    {
                        searchResults = cards.FindAll(x => x.power == powerSearch.Value);
                    }
                    else
                    {
                        searchResults = cards;
                    }
                }
            }

            foreach (Card c in searchResults)
            {
                cardList.Text += $"{c.name}{Environment.NewLine}{c.descrip}{Environment.NewLine}" +
                    $"Health: {c.health} Power: {c.power}{Environment.NewLine}{Environment.NewLine}";
            }
        }

        //Adds new card with inputted properties into cardList. 
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

        //Puts card data into preview image. 
        public void ViewCard(string name, string descrip, int health, int power)
        {
            nameDisplay.Text = name;
            healthDisplay.Text = Convert.ToString(health);
            powerDisplay.Text = Convert.ToString(power);
            descripDisplay.Text = descrip;
        }
    }
}
