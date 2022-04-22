namespace Objectcreator
{
    partial class UCPlayers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNameSbos = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.pnlControllSbos = new System.Windows.Forms.Panel();
            this.cbxTeamsSbos = new System.Windows.Forms.ComboBox();
            this.lblTeamsSbos = new System.Windows.Forms.Label();
            this.btnRemoveSbos = new System.Windows.Forms.Button();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.colorDialog1Sbos = new System.Windows.Forms.ColorDialog();
            this.pnlControllSbos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameSbos
            // 
            this.lblNameSbos.AutoSize = true;
            this.lblNameSbos.Location = new System.Drawing.Point(10, 17);
            this.lblNameSbos.Name = "lblNameSbos";
            this.lblNameSbos.Size = new System.Drawing.Size(38, 13);
            this.lblNameSbos.TabIndex = 0;
            this.lblNameSbos.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(54, 14);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 3;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 10;
            this.tmrTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlControllSbos
            // 
            this.pnlControllSbos.Controls.Add(this.cbxTeamsSbos);
            this.pnlControllSbos.Controls.Add(this.lblTeamsSbos);
            this.pnlControllSbos.Controls.Add(this.btnRemoveSbos);
            this.pnlControllSbos.Controls.Add(this.btnSetColor);
            this.pnlControllSbos.Controls.Add(this.tbxName);
            this.pnlControllSbos.Controls.Add(this.lblNameSbos);
            this.pnlControllSbos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControllSbos.Location = new System.Drawing.Point(0, 0);
            this.pnlControllSbos.Name = "pnlControllSbos";
            this.pnlControllSbos.Size = new System.Drawing.Size(282, 66);
            this.pnlControllSbos.TabIndex = 4;
            this.pnlControllSbos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControllSbos_Paint);
            // 
            // cbxTeamsSbos
            // 
            this.cbxTeamsSbos.FormattingEnabled = true;
            this.cbxTeamsSbos.Location = new System.Drawing.Point(53, 40);
            this.cbxTeamsSbos.Name = "cbxTeamsSbos";
            this.cbxTeamsSbos.Size = new System.Drawing.Size(100, 21);
            this.cbxTeamsSbos.TabIndex = 7;
            this.cbxTeamsSbos.SelectedIndexChanged += new System.EventHandler(this.cbxTeamsSbos_SelectedIndexChanged);
            this.cbxTeamsSbos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxTeamsSbos_MouseClick);
            // 
            // lblTeamsSbos
            // 
            this.lblTeamsSbos.AutoSize = true;
            this.lblTeamsSbos.Location = new System.Drawing.Point(10, 40);
            this.lblTeamsSbos.Name = "lblTeamsSbos";
            this.lblTeamsSbos.Size = new System.Drawing.Size(37, 13);
            this.lblTeamsSbos.TabIndex = 6;
            this.lblTeamsSbos.Text = "Team:";
            // 
            // btnRemoveSbos
            // 
            this.btnRemoveSbos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveSbos.Location = new System.Drawing.Point(233, 0);
            this.btnRemoveSbos.Name = "btnRemoveSbos";
            this.btnRemoveSbos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRemoveSbos.Size = new System.Drawing.Size(49, 66);
            this.btnRemoveSbos.TabIndex = 5;
            this.btnRemoveSbos.UseVisualStyleBackColor = true;
            this.btnRemoveSbos.Click += new System.EventHandler(this.btnRemoveSbos_Click);
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(160, 14);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(66, 20);
            this.btnSetColor.TabIndex = 4;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // UCPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControllSbos);
            this.Name = "UCPlayers";
            this.Size = new System.Drawing.Size(282, 66);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.pnlControllSbos.ResumeLayout(false);
            this.pnlControllSbos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameSbos;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.Panel pnlControllSbos;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.ColorDialog colorDialog1Sbos;
        private System.Windows.Forms.Button btnRemoveSbos;
        private System.Windows.Forms.Label lblTeamsSbos;
        public System.Windows.Forms.ComboBox cbxTeamsSbos;
    }
}
