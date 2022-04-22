namespace Objectcreator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.nudLoop = new System.Windows.Forms.NumericUpDown();
            this.lblRounds = new System.Windows.Forms.Label();
            this.btnAddTeams = new System.Windows.Forms.Button();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.nudQuickAdd = new System.Windows.Forms.NumericUpDown();
            this.btnStartGameSbos = new System.Windows.Forms.Button();
            this.nudAmountTeams = new System.Windows.Forms.NumericUpDown();
            this.lblTeamAmountSbos = new System.Windows.Forms.Label();
            this.btnQuickAdd = new System.Windows.Forms.Button();
            this.btnAddTimer = new System.Windows.Forms.Button();
            this.pnlTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.TabControl2Sbos = new System.Windows.Forms.TabControl();
            this.tabPage1Sbos = new System.Windows.Forms.TabPage();
            this.tabPageGameSbos = new System.Windows.Forms.TabPage();
            this.clbGameWords = new System.Windows.Forms.CheckedListBox();
            this.lblGameWord = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.dgvTeamList = new System.Windows.Forms.DataGridView();
            this.colorDialogSbos = new System.Windows.Forms.ColorDialog();
            this.tmrGameSbos = new System.Windows.Forms.Timer(this.components);
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamNeem = new System.Windows.Forms.Label();
            this.lblPlayerneem = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuickAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTeams)).BeginInit();
            this.TabControl2Sbos.SuspendLayout();
            this.tabPage1Sbos.SuspendLayout();
            this.tabPageGameSbos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.nudLoop);
            this.pnlControl.Controls.Add(this.lblRounds);
            this.pnlControl.Controls.Add(this.btnAddTeams);
            this.pnlControl.Controls.Add(this.tbxPlayerName);
            this.pnlControl.Controls.Add(this.nudQuickAdd);
            this.pnlControl.Controls.Add(this.btnStartGameSbos);
            this.pnlControl.Controls.Add(this.nudAmountTeams);
            this.pnlControl.Controls.Add(this.lblTeamAmountSbos);
            this.pnlControl.Controls.Add(this.btnQuickAdd);
            this.pnlControl.Controls.Add(this.btnAddTimer);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControl.Location = new System.Drawing.Point(3, 3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(200, 418);
            this.pnlControl.TabIndex = 0;
            // 
            // nudLoop
            // 
            this.nudLoop.Location = new System.Drawing.Point(83, 251);
            this.nudLoop.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLoop.Name = "nudLoop";
            this.nudLoop.Size = new System.Drawing.Size(39, 20);
            this.nudLoop.TabIndex = 10;
            this.nudLoop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoop.ValueChanged += new System.EventHandler(this.nudLoop_ValueChanged);
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(3, 253);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(74, 13);
            this.lblRounds.TabIndex = 9;
            this.lblRounds.Text = "Total Rounds:";
            // 
            // btnAddTeams
            // 
            this.btnAddTeams.Location = new System.Drawing.Point(138, 111);
            this.btnAddTeams.Name = "btnAddTeams";
            this.btnAddTeams.Size = new System.Drawing.Size(56, 20);
            this.btnAddTeams.TabIndex = 8;
            this.btnAddTeams.Text = "ADD Teams";
            this.btnAddTeams.UseVisualStyleBackColor = true;
            this.btnAddTeams.Click += new System.EventHandler(this.btnAddTeams_Click);
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Location = new System.Drawing.Point(4, 56);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(114, 20);
            this.tbxPlayerName.TabIndex = 6;
            // 
            // nudQuickAdd
            // 
            this.nudQuickAdd.Location = new System.Drawing.Point(9, 11);
            this.nudQuickAdd.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudQuickAdd.Name = "nudQuickAdd";
            this.nudQuickAdd.Size = new System.Drawing.Size(61, 20);
            this.nudQuickAdd.TabIndex = 5;
            this.nudQuickAdd.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnStartGameSbos
            // 
            this.btnStartGameSbos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartGameSbos.Location = new System.Drawing.Point(0, 387);
            this.btnStartGameSbos.Name = "btnStartGameSbos";
            this.btnStartGameSbos.Size = new System.Drawing.Size(200, 31);
            this.btnStartGameSbos.TabIndex = 4;
            this.btnStartGameSbos.Text = "Start Game";
            this.btnStartGameSbos.UseVisualStyleBackColor = true;
            this.btnStartGameSbos.Click += new System.EventHandler(this.btnStartGameSbos_Click_1);
            // 
            // nudAmountTeams
            // 
            this.nudAmountTeams.Location = new System.Drawing.Point(93, 111);
            this.nudAmountTeams.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAmountTeams.Name = "nudAmountTeams";
            this.nudAmountTeams.Size = new System.Drawing.Size(39, 20);
            this.nudAmountTeams.TabIndex = 3;
            this.nudAmountTeams.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblTeamAmountSbos
            // 
            this.lblTeamAmountSbos.AutoSize = true;
            this.lblTeamAmountSbos.Location = new System.Drawing.Point(6, 113);
            this.lblTeamAmountSbos.Name = "lblTeamAmountSbos";
            this.lblTeamAmountSbos.Size = new System.Drawing.Size(81, 13);
            this.lblTeamAmountSbos.TabIndex = 2;
            this.lblTeamAmountSbos.Text = "Amount Teams:";
            // 
            // btnQuickAdd
            // 
            this.btnQuickAdd.Location = new System.Drawing.Point(72, 6);
            this.btnQuickAdd.Name = "btnQuickAdd";
            this.btnQuickAdd.Size = new System.Drawing.Size(122, 31);
            this.btnQuickAdd.TabIndex = 1;
            this.btnQuickAdd.Text = "Quick Add Player";
            this.btnQuickAdd.UseVisualStyleBackColor = true;
            this.btnQuickAdd.Click += new System.EventHandler(this.btnQuickAdd_Click);
            // 
            // btnAddTimer
            // 
            this.btnAddTimer.Location = new System.Drawing.Point(124, 50);
            this.btnAddTimer.Name = "btnAddTimer";
            this.btnAddTimer.Size = new System.Drawing.Size(70, 31);
            this.btnAddTimer.TabIndex = 0;
            this.btnAddTimer.Text = "ADD Player";
            this.btnAddTimer.UseVisualStyleBackColor = true;
            this.btnAddTimer.Click += new System.EventHandler(this.btnAddTimer_Click);
            // 
            // pnlTeams
            // 
            this.pnlTeams.AutoScroll = true;
            this.pnlTeams.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTeams.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTeams.Location = new System.Drawing.Point(494, 3);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(295, 418);
            this.pnlTeams.TabIndex = 2;
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.AutoScroll = true;
            this.pnlPlayers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPlayers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlayers.Location = new System.Drawing.Point(203, 3);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(291, 418);
            this.pnlPlayers.TabIndex = 1;
            this.pnlPlayers.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlayers_Paint);
            // 
            // TabControl2Sbos
            // 
            this.TabControl2Sbos.Controls.Add(this.tabPage1Sbos);
            this.TabControl2Sbos.Controls.Add(this.tabPageGameSbos);
            this.TabControl2Sbos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2Sbos.Location = new System.Drawing.Point(0, 0);
            this.TabControl2Sbos.Name = "TabControl2Sbos";
            this.TabControl2Sbos.SelectedIndex = 0;
            this.TabControl2Sbos.Size = new System.Drawing.Size(965, 450);
            this.TabControl2Sbos.TabIndex = 2;
            // 
            // tabPage1Sbos
            // 
            this.tabPage1Sbos.Controls.Add(this.pnlTeams);
            this.tabPage1Sbos.Controls.Add(this.pnlPlayers);
            this.tabPage1Sbos.Controls.Add(this.pnlControl);
            this.tabPage1Sbos.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Sbos.Name = "tabPage1Sbos";
            this.tabPage1Sbos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Sbos.Size = new System.Drawing.Size(957, 424);
            this.tabPage1Sbos.TabIndex = 0;
            this.tabPage1Sbos.Text = "Settings";
            this.tabPage1Sbos.UseVisualStyleBackColor = true;
            // 
            // tabPageGameSbos
            // 
            this.tabPageGameSbos.Controls.Add(this.clbGameWords);
            this.tabPageGameSbos.Controls.Add(this.pnlTopBar);
            this.tabPageGameSbos.Controls.Add(this.lblGameWord);
            this.tabPageGameSbos.Controls.Add(this.dgvTeamList);
            this.tabPageGameSbos.Location = new System.Drawing.Point(4, 22);
            this.tabPageGameSbos.Name = "tabPageGameSbos";
            this.tabPageGameSbos.Size = new System.Drawing.Size(957, 424);
            this.tabPageGameSbos.TabIndex = 2;
            this.tabPageGameSbos.Text = "Game";
            this.tabPageGameSbos.UseVisualStyleBackColor = true;
            // 
            // clbGameWords
            // 
            this.clbGameWords.CheckOnClick = true;
            this.clbGameWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbGameWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGameWords.FormattingEnabled = true;
            this.clbGameWords.Location = new System.Drawing.Point(284, 100);
            this.clbGameWords.Name = "clbGameWords";
            this.clbGameWords.Size = new System.Drawing.Size(673, 244);
            this.clbGameWords.TabIndex = 4;
            this.clbGameWords.SelectedIndexChanged += new System.EventHandler(this.clbGameWords_SelectedIndexChanged);
            // 
            // lblGameWord
            // 
            this.lblGameWord.AutoSize = true;
            this.lblGameWord.Location = new System.Drawing.Point(290, 101);
            this.lblGameWord.Name = "lblGameWord";
            this.lblGameWord.Size = new System.Drawing.Size(129, 13);
            this.lblGameWord.TabIndex = 3;
            this.lblGameWord.Text = "game word to be guessed";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(71, 38);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(64, 13);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "player name";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblTimer.Location = new System.Drawing.Point(393, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(89, 38);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "timer";
            // 
            // dgvTeamList
            // 
            this.dgvTeamList.AllowUserToAddRows = false;
            this.dgvTeamList.AllowUserToDeleteRows = false;
            this.dgvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTeamList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTeamList.Location = new System.Drawing.Point(0, 0);
            this.dgvTeamList.Name = "dgvTeamList";
            this.dgvTeamList.Size = new System.Drawing.Size(284, 424);
            this.dgvTeamList.TabIndex = 0;
            // 
            // tmrGameSbos
            // 
            this.tmrGameSbos.Interval = 10;
            this.tmrGameSbos.Tick += new System.EventHandler(this.tmrGameSbos_Tick);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblPlayerneem);
            this.pnlTopBar.Controls.Add(this.lblTeamNeem);
            this.pnlTopBar.Controls.Add(this.lblTeamName);
            this.pnlTopBar.Controls.Add(this.lblTimer);
            this.pnlTopBar.Controls.Add(this.lblPlayerName);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(284, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(673, 100);
            this.pnlTopBar.TabIndex = 5;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(71, 12);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(62, 13);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "team NAme";
            // 
            // lblTeamNeem
            // 
            this.lblTeamNeem.AutoSize = true;
            this.lblTeamNeem.Location = new System.Drawing.Point(6, 12);
            this.lblTeamNeem.Name = "lblTeamNeem";
            this.lblTeamNeem.Size = new System.Drawing.Size(63, 13);
            this.lblTeamNeem.TabIndex = 4;
            this.lblTeamNeem.Text = "Team name";
            // 
            // lblPlayerneem
            // 
            this.lblPlayerneem.AutoSize = true;
            this.lblPlayerneem.Location = new System.Drawing.Point(6, 38);
            this.lblPlayerneem.Name = "lblPlayerneem";
            this.lblPlayerneem.Size = new System.Drawing.Size(65, 13);
            this.lblPlayerneem.TabIndex = 5;
            this.lblPlayerneem.Text = "Player name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.TabControl2Sbos);
            this.Name = "Form1";
            this.Text = "30Seconds";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuickAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTeams)).EndInit();
            this.TabControl2Sbos.ResumeLayout(false);
            this.tabPage1Sbos.ResumeLayout(false);
            this.tabPageGameSbos.ResumeLayout(false);
            this.tabPageGameSbos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnAddTimer;
        private System.Windows.Forms.TabPage tabPage1Sbos;
        private System.Windows.Forms.TabPage tabPageGameSbos;
        private System.Windows.Forms.Button btnQuickAdd;
        private System.Windows.Forms.Button btnStartGameSbos;
        private System.Windows.Forms.NumericUpDown nudAmountTeams;
        private System.Windows.Forms.Label lblTeamAmountSbos;
        private System.Windows.Forms.NumericUpDown nudQuickAdd;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.ColorDialog colorDialogSbos;
        public System.Windows.Forms.FlowLayoutPanel pnlPlayers;
        private System.Windows.Forms.Button btnAddTeams;
        public System.Windows.Forms.FlowLayoutPanel pnlTeams;
        public System.Windows.Forms.TabControl TabControl2Sbos;
        private System.Windows.Forms.NumericUpDown nudLoop;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.DataGridView dgvTeamList;
        private System.Windows.Forms.Timer tmrGameSbos;
        private System.Windows.Forms.Label lblGameWord;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.CheckedListBox clbGameWords;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPlayerneem;
        private System.Windows.Forms.Label lblTeamNeem;
        private System.Windows.Forms.Label lblTeamName;
    }
}

