using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objectcreator;
using Objectcreator.Classes;

namespace Objectcreator
{
    public partial class UCPlayers : UserControl
    {

        public player PlayersSbos = new player();
        public List<UCTeams> UCTeamList { get; set; }
        public int ID { get; set; }
        public string controlName { get; set; }
        public string connectedTeam { get; set; }
        public UCPlayers(string name)
        {
            InitializeComponent();
            tbxName.Text = name;
            controlName = name;
            this.Name = name;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            btnRemoveSbos.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemoveSbos.BackgroundImage = Objectcreator.Properties.Resources.cross;
        }

        private void cbxTeamsSbos_MouseClick(object sender, MouseEventArgs e)
        {

            cbxTeamsSbos.Items.Clear();
            UCTeamList = Form1.Instance.pnlTeams.Controls.OfType<UCTeams>().ToList(); 
            
            foreach (UserControl teams in UCTeamList)
            {
                cbxTeamsSbos.Items.Add(teams.Name);
            }
        }
        public void SetName(string NameSbos)
        {
            controlName = NameSbos;
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            Color color = Color.Aqua;
            colorDialog1Sbos.ShowDialog();
            color = colorDialog1Sbos.Color;
            if (color == Color.Black)
            {
                this.ForeColor = Color.White;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
            this.BackColor = color;
        }
        #region LolTimer

        long time = 0;
        int miliseconds = 0;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            tmrTick.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            miliseconds = (int)(time % 60);
            if (miliseconds >= 10)
            {
                int amount = 10 - miliseconds;
            }
            seconds = (int)(time / 60 % 60);
            minutes = (int)(time / 3600);
            hours = (int)(time / 216000);
            //label2.Text = $"{hours}:{minutes}:{seconds}:{miliseconds}";
        }
        #endregion

        private void pnlControllSbos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemoveSbos_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlPlayers.Controls.Remove(this);
            Form1.Instance.listUserControls.Remove(this);
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            if (tbxName.Text.Length > 0)
            {
                this.Name = tbxName.Text;
            }
        }

        private void cbxTeamsSbos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.connectedTeam = cbxTeamsSbos.Text;
        }
    }
}
