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
    public partial class UCTeams : UserControl
    {
        public string teamNameSbos { get; set; }
        public int teamIDSbos { get; set; }
        public List<string> teamMates { get; set; }

        public UCTeams(int ID, string nameSbos)
        {
            InitializeComponent();
            this.teamIDSbos = ID;
            this.teamNameSbos = nameSbos;
            this.Name = nameSbos;
        }

        private void UCTeams_Load(object sender, EventArgs e)
        {
            tbxTeamName.Text = teamNameSbos;
            btnRemoveSbos.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemoveSbos.BackgroundImage = Objectcreator.Properties.Resources.cross;
        }
        private void btnRemoveSbos_Click(object sender, EventArgs e)
        {
            Form1.Instance.pnlTeams.Controls.Remove(this);
            Form1.Instance.listTeams.Remove(this);
        }

        private void tbxTeamName_TextChanged(object sender, EventArgs e)
        {
            if (tbxTeamName.Text.Length > 0)
            {
                this.Name = tbxTeamName.Text;
            }
        }
    }
}
