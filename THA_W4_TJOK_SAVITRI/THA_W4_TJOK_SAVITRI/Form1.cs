using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace THA_W4_TJOK_SAVITRI
{
    public partial class Form1 : Form
    {
        List<Team> teamlist = new List<Team>();
        List<Player> playerlist = new List<Player>();
        public Form1()
        {
            InitializeComponent();
            Team team1 = new Team("Manchester United", "England", "Manchester");
            team1.playerList.Add(new Player("David De Gea", "01", "GK"));
            team1.playerList.Add(new Player("Victor Lindelof", "02", "DF"));
            team1.playerList.Add(new Player("Phil Jones", "04", "DF"));
            team1.playerList.Add(new Player("Harry Maguire", "05", "DF"));
            team1.playerList.Add(new Player("Lisandro Martinez", "06", "DF"));
            team1.playerList.Add(new Player("Bruno Femandez", "08", "MF"));
            team1.playerList.Add(new Player("Anthony Martial", "09", "FW"));
            team1.playerList.Add(new Player("Marcus Rashford", "10", "FW"));
            team1.playerList.Add(new Player("Tyrell Malacia", "12", "DF"));
            team1.playerList.Add(new Player("Christian Eriksen", "14", "MF"));
            team1.playerList.Add(new Player("Casemiro", "18", "MF"));
            teamlist.Add(team1);

            Team team2 = new Team("Chelsea", "England", "Chelsea");
            team2.playerList.Add(new Player("Kepa Amizabalaga", "01", "GK"));
            team2.playerList.Add(new Player("Benoit Badiashile", "04", "DF"));
            team2.playerList.Add(new Player("Enzo Fernandez", "05", "MF"));
            team2.playerList.Add(new Player("Thiago Silva", "06", "DF"));
            team2.playerList.Add(new Player("N'Golo Kante", "07", "MF"));
            team2.playerList.Add(new Player("Mateo Kovacic", "08", "MF"));
            team2.playerList.Add(new Player("PiemeEmerick Aubameyang", "09", "FW"));
            team2.playerList.Add(new Player("Christian Pulisic", "10", "MF"));
            team2.playerList.Add(new Player("Joao Felix", "11", "FW"));
            team2.playerList.Add(new Player("Ruben Loftus Cheek", "12", "MF"));
            team2.playerList.Add(new Player("Raheem Sterling", "17", "MF"));
            teamlist.Add(team2);

            Team team3 = new Team("Bayem Munich", "Germany", "München");
            team3.playerList.Add(new Player("Manuel Neuer", "01", "GK"));
            team3.playerList.Add(new Player("Dayot Upamecano", "02", "DF"));
            team3.playerList.Add(new Player("Matthijs de Ligt", "04", "DF"));
            team3.playerList.Add(new Player("Benjamin Pavard", "05", "DF"));
            team3.playerList.Add(new Player("Joshua Kimmich", "06", "MF"));
            team3.playerList.Add(new Player("Serge Gnabry", "07", "FW"));
            team3.playerList.Add(new Player("Leon Goretzka", "08", "MF"));
            team3.playerList.Add(new Player("Leroy Sane", "10", "FW"));
            team3.playerList.Add(new Player("Paul Wanner", "14", "MF"));
            team3.playerList.Add(new Player("Lucas Hemandez", "21", "DF"));
            team3.playerList.Add(new Player("Thomas Muller", "25", "FW"));
            teamlist.Add(team3);
            comboBoxCountry.Items.Add("England");
            comboBoxCountry.Items.Add("Germany");
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {

            bool ada = false;
            bool nama = false;
            if (string.IsNullOrWhiteSpace(textBoxTeamName.Text) || string.IsNullOrWhiteSpace(textBoxTeamCountry.Text) || string.IsNullOrWhiteSpace(textBoxTeamCity.Text))
            {
                MessageBox.Show("Please input all textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Team timtiman = new Team(textBoxTeamName.Text, textBoxTeamCountry.Text, textBoxTeamCity.Text);

                foreach (Team t in teamlist)
                {

                    if (t.teamName == textBoxTeamName.Text)
                    {
                        MessageBox.Show("Team already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nama = true;
                        break;
                    }
                }
                bool country = false;
                if (ada == false)
                {
                    teamlist.Add(timtiman);
                    foreach (string a in comboBoxCountry.Items)
                    {
                        if (a == timtiman.teamCountry)
                        {
                            country = true;
                        }
                    }
                    if (country == false)
                    {
                        comboBoxCountry.Items.Add(timtiman.teamCountry);
                    }
                }
                else
                {
                    MessageBox.Show("Team already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            textBoxTeamName.Text = "";
            textBoxTeamCountry.Text = "";
            textBoxTeamCity.Text = "";
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxPlayerName.Text) || string.IsNullOrWhiteSpace(textBoxPlayerNumber.Text) || comboBoxPlayerPosition.SelectedItem == null)
            {
                MessageBox.Show("Please input all textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCountry.SelectedItem == null || comboBoxTeam.SelectedItem == null)
            {
                MessageBox.Show("Please choose country / team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool adaplayer = false;
            foreach (Team t in teamlist)
            {
                Player players = new Player(textBoxPlayerName.Text, textBoxPlayerNumber.Text, comboBoxPlayerPosition.Text);
                if (comboBoxTeam.Text == t.teamName)
                {
                    foreach (Player player in t.playerList)
                    {

                        if (player.playerName == textBoxPlayerName.Text)
                        {
                            adaplayer = true;
                            MessageBox.Show("Player already exists.");
                            return;
                        }

                        if (player.playerNum == textBoxPlayerNumber.Text)
                        {
                            adaplayer = true;
                            MessageBox.Show("Player already exists.");
                            return;
                        }
                        
                    }
                    if (adaplayer == false)
                        t.playerList.Add(players);
                }
                

            }

            listBoxData.Items.Clear();
            printPlayer();
            textBoxPlayerName.Text = "";
            textBoxPlayerNumber.Text = "";

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeam.Items.Clear();
            foreach (Team a in teamlist)
            {
                if (comboBoxCountry.Text == a.teamCountry)
                {
                    comboBoxTeam.Items.Add(a.teamName);
                }
            }

        }
        public void printPlayer()
        {
            foreach (Team a in teamlist)
            {
                if (comboBoxTeam.Text == a.teamName && comboBoxCountry.Text == a.teamCountry)
                {
                    foreach (Player player in a.playerList)
                    {
                        string playerName = player.playerName;
                        string playerNum = player.playerNum;
                        string playerPos = player.playerPos;
                        string result = "(" + playerNum + ") " + playerName + " " + playerPos;
                        listBoxData.Items.Add(result);

                    }
                }
            }
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            printPlayer();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxData.SelectedIndex;
            if (listBoxData.Items.Count > 11)
            {
                foreach (Team t in teamlist)
                {
                    if (t.teamName == comboBoxTeam.Text)
                    { 
                            t.playerList.RemoveAt(index);                   
                    }                   
                }
                listBoxData.Items.RemoveAt(listBoxData.SelectedIndex);
                listBoxData.Items.Clear();
                printPlayer();
            } else
            {
                MessageBox.Show("Unable to remove. If player less than equal 11.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBoxData.Items.Count > 0)
            {
                foreach (Team teams in teamlist)
                {

                    foreach (Player player in teams.playerList)
                    {
                        MessageBox.Show(player.playerName.ToString());
                        break;
                    }

                }
            }
        }
    }
}
