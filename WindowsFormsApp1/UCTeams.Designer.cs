namespace Objectcreator
{
    partial class UCTeams
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
            this.tbxTeamName = new System.Windows.Forms.TextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.btnRemoveSbos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTeamName
            // 
            this.tbxTeamName.Location = new System.Drawing.Point(78, 10);
            this.tbxTeamName.Name = "tbxTeamName";
            this.tbxTeamName.Size = new System.Drawing.Size(147, 20);
            this.tbxTeamName.TabIndex = 0;
            this.tbxTeamName.TextChanged += new System.EventHandler(this.tbxTeamName_TextChanged);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(4, 13);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(68, 13);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Team Name:";
            // 
            // btnRemoveSbos
            // 
            this.btnRemoveSbos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveSbos.Location = new System.Drawing.Point(231, 0);
            this.btnRemoveSbos.Name = "btnRemoveSbos";
            this.btnRemoveSbos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRemoveSbos.Size = new System.Drawing.Size(49, 39);
            this.btnRemoveSbos.TabIndex = 6;
            this.btnRemoveSbos.UseVisualStyleBackColor = true;
            this.btnRemoveSbos.Click += new System.EventHandler(this.btnRemoveSbos_Click);
            // 
            // UCTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveSbos);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.tbxTeamName);
            this.Name = "UCTeams";
            this.Size = new System.Drawing.Size(280, 39);
            this.Load += new System.EventHandler(this.UCTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Button btnRemoveSbos;
        public System.Windows.Forms.TextBox tbxTeamName;
    }
}
