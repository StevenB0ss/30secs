using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Objectcreator;
using Objectcreator.Classes;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

namespace Objectcreator
{
    public partial class Form1 : Form
    {
        public List<UCTeams> UCTeamList { get; set; }
        public List<UCPlayers> UCPlayersList { get; set; }
        public static new Form1 Instance { get; set; }
        public int test { get; set; }
        public UCPlayers ucPlayers = null;
        public List<UCPlayers> listUserControls = new List<UCPlayers>();
        public UCTeams ucTeams = null;
        public List<UCTeams> listTeams = new List<UCTeams>();
        int playerCountSbos = 0;
        int teamCountSbos = 0;
        public List<string[]> gameData = new List<string[]>();
        public List<string> gameList = new List<string>();
        public int gameState = 0;
        int gameTick = 0;
        bool gameRunning = false;
        public List<string[]> teamScore = new List<string[]>();
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            TabControl2Sbos.Appearance = TabAppearance.FlatButtons;
            TabControl2Sbos.ItemSize = new Size(0, 1);
            TabControl2Sbos.SizeMode = TabSizeMode.Fixed;
        }
        private void btnStartGameSbos_Click_1(object sender, EventArgs e)
        {
            bool succes = false;
            gameData.Clear();
            UCTeamList = this.pnlTeams.Controls.OfType<UCTeams>().ToList();
            UCPlayersList = this.pnlPlayers.Controls.OfType<UCPlayers>().ToList();
            foreach (UCPlayers player in UCPlayersList)
            {
                string[] data = {
                    Convert.ToString(player.ID),
                    player.Name,
                    player.connectedTeam
                };
                if (data[2] == null)
                {
                    succes = false;
                }
                else
                {
                    succes = true;
                }
                gameData.Add(data);
            }
            if (gameData.Count >= 4)
            {
                if ( succes == true)
                {
                    dgvTeamList.Rows.Clear();
                    dgvTeamList.Columns.Clear();
                    gameList.Clear();
                    foreach (string line in File.ReadLines(Application.StartupPath + "\\WordlistToUseForAppr.txt"))
                    {
                        gameList.Add(line);
                    };
                    foreach (UCTeams teams in UCTeamList)
                    {
                        int index = dgvTeamList.Columns.Add($"Column {teams.teamIDSbos}", teams.Name);
                        string[] listInput = { teams.Name, Convert.ToString(index), Convert.ToString(0) };
                        teamScore.Add(listInput);
                    }
                    TabControl2Sbos.SelectedIndex = 1;
                    gameState = 0;
                    tmrGameSbos.Start();
                    gameRunning = true;
                }
                if (succes == false)
                {
                    MessageBox.Show("Please give every player a team!", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                
            }
            else
            {
                MessageBox.Show("Please play with atleast 4 players!", "Wrong input", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        public void tmrGameSbos_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            if (gameRunning == true)
            {
                if (gameState < gameData.Count)
                {
                    if (gameTick == 0)
                    {
                        UCPlayersList = this.pnlPlayers.Controls.OfType<UCPlayers>().ToList();
                        foreach (UCPlayers player in UCPlayersList)
                        {
                            if (player.Name == gameData[gameState][1])
                            {
                                pnlTopBar.BackColor = player.BackColor;
                            }
                        }
                        clbGameWords.Items.Clear();
                        lblPlayerName.Text = gameData[gameState][1];
                        lblTeamName.Text = gameData[gameState][2];
                        lblGameWord.Text = "";
                        int[] randomWords = { 
                            rd.Next(1, gameList.Count), 
                            rd.Next(1, gameList.Count), 
                            rd.Next(1, gameList.Count),
                            rd.Next(1, gameList.Count),
                            rd.Next(1, gameList.Count), 
                        };
                        foreach (int word in randomWords)
                        {
                            clbGameWords.Items.Add(gameList[word]);
                        }
                    }

                    gameTick++;
                    int miliseconds = (int)(gameTick % 100);
                    if (miliseconds >= 10)
                    {
                        int amount = 10 - miliseconds;
                    }
                    int seconds = (int)(gameTick / 60 % 60);
                    lblTimer.Text = $"{seconds}:{miliseconds}";
                    if (gameTick >= 180)
                    {
                        int pointWon = 0;
                        for (int i = 0; i < clbGameWords.Items.Count; i++)
                        {
                            if (clbGameWords.GetItemChecked(i) == true)
                            {
                                pointWon++;
                            }
                        }
                        string teamName;
                        foreach (string[] score in teamScore)
                        {
                            if (score[0] == gameData[gameState][2])
                            {
                                int newScore = Convert.ToInt32(score[2]) + pointWon;
                                teamName = score[0];
                                score[2] = Convert.ToString(newScore);
                                if (score[1] == "0")
                                {
                                    dgvTeamList.Rows.Add(Convert.ToString(pointWon));
                                    break;
                                }
                                if (score[1] == "1")
                                {
                                    dgvTeamList.Rows.Add("", Convert.ToString(pointWon));
                                    break;
                                }
                                if (score[1] == "2")
                                {
                                    dgvTeamList.Rows.Add("", "", Convert.ToString(pointWon));
                                    break;
                                }
                                if (score[1] == "3")
                                {
                                    dgvTeamList.Rows.Add("", "", "", Convert.ToString(pointWon));
                                    break;
                                }
                            }
                        }
                        gameState++;
                        gameTick = 0;
                     }
                    
                }
                else
                {
                    nudLoop.DownButton();
                    if (nudLoop.Value > 0)
                    {
                        gameTick = 0;
                        gameState = 0;

                        foreach (string[] score in teamScore)
                        {
                            if (Convert.ToInt32(score[2]) >= 30)
                            {
                                MessageBox.Show(score[0] + " Won the game!\nResults are saved in the application folder", "WE HAVE A WINNEEERRRRRR!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string export = "\n" + DateTime.Now + "\n";
                                foreach (string[] scores in teamScore)
                                {
                                    export += scores[0] + " Has scored " + scores[2] + " Points!\n";
                                }
                                File.AppendAllText(Application.StartupPath + "\\export.txt", export);
                                TabControl2Sbos.SelectedIndex = 0;
                                gameRunning = false;
                                tmrGameSbos.Stop();
                            }
                        }
                    }
                    else
                    {
                        string export = "\n" + DateTime.Now +"\n";
                        int winner = 0;
                        string winnder = "";
                        foreach (string[] score in teamScore)
                        {
                            export += score[0] + " Has scored " + score[2] + " Points!\n";
                            if (Convert.ToInt32(score[2]) >= winner)
                            {
                                winner = Convert.ToInt32(score[2]);
                                winnder = score[0];
                            }
                        }
                        File.AppendAllText(Application.StartupPath + "\\export.txt", export);
                        TabControl2Sbos.SelectedIndex = 0;
                        gameRunning = false;
                        MessageBox.Show(winnder + " Won the game!\nResults are saved in the application folder", "WE HAVE A WINNEEERRRRRR!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tmrGameSbos.Stop();
                    }
                }
            }
        }
        private void btnQuickAdd_Click(object sender, EventArgs e)
        {
            int playersLeft = 8 - GetPlayerCount();
            if (GetPlayerCount() < 8)
            {
                AddPlayer(true, null);
            }
        }
        private void btnAddTeams_Click(object sender, EventArgs e)
        {
            int playersLeft = 2 - GetTeamCount();
            if (GetTeamCount() < 2)
            {
                AddTeam(Convert.ToInt32(nudAmountTeams.Value), null);
            }
        }
        #region Methods
        public int GetPlayerCount()
        {
            UCPlayersList = this.pnlPlayers.Controls.OfType<UCPlayers>().ToList();
            return UCPlayersList.Count;
        }
        private int GetTeamCount()
        {
            UCTeamList = this.pnlTeams.Controls.OfType<UCTeams>().ToList();
            return UCTeamList.Count;
        }
        public void AddTeam(int amountSbos, string name)
        {
            for (int i = 0; i < amountSbos; i++)
            {
                ucTeams = new UCTeams(teamCountSbos, GetTeamName(name));
                Random rd = new Random();
                Color color = Color.FromArgb(rd.Next(1, 255), rd.Next(1, 255), rd.Next(1, 255));
                ucTeams.BackColor = color;
                ucTeams.teamIDSbos = teamCountSbos;
                listTeams.Add(ucTeams);
                pnlTeams.Controls.Add(ucTeams);
                teamCountSbos++;

            }
        }
        public string GetTeamName(string name)
        {
            string output = name;
            if (output == null)
            {
                output = $"Team {listTeams.Count + 1}";
            }
            return output;
        }
        private void btnAddTimer_Click(object sender, EventArgs e)
        {
            if (GetPlayerCount() < 8)
            {
                AddPlayer(false, tbxPlayerName.Text);
            }
        }



        public void AddPlayer(bool quickAdd, string name)
        {
            int loop = 1;
            if (quickAdd == true)
            {
                loop = Convert.ToInt32(nudQuickAdd.Value);
            }
            for (int i = 0; i < loop; i++)
            {
                Color color = Color.White;

                if (name != null)
                {
                    foreach (UCPlayers userControl in listUserControls)
                    {
                        if (userControl.controlName == tbxPlayerName.Text)
                        {
                            name = $"Player{playerCountSbos}";
                        }
                        else
                        {
                            name = tbxPlayerName.Text;
                        }
                    }
                }
                if (quickAdd == true)
                {
                    name = $"Player{playerCountSbos}";
                }
                ucPlayers = new Objectcreator.UCPlayers(name);
                if (quickAdd == true)
                {
                    Random rd = new Random();
                    color = Color.FromArgb(rd.Next(1, 255), rd.Next(1, 255), rd.Next(1, 255));
                }
                if (quickAdd == false)
                {
                    colorDialogSbos.ShowDialog();
                    color = colorDialogSbos.Color;
                    if (color == Color.Black)
                    {
                        ucPlayers.ForeColor = Color.White;
                    }
                }
                ucPlayers.BackColor = color;
                ucPlayers.ID = playerCountSbos;
                listUserControls.Add(ucPlayers);
                pnlPlayers.Controls.Add(ucPlayers);
                playerCountSbos++;
            }
        }


        #endregion
        private void pnlPlayers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void nudLoop_ValueChanged(object sender, EventArgs e)
        {
            if (nudLoop.Value == 0)
            {
                btnStartGameSbos.Enabled = false;
            }
            else
            {
                btnStartGameSbos.Enabled = true;
            }
        }

        private void clbGameWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

