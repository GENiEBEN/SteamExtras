namespace GameSearchDeskBand
{
    partial class DeskBandUI
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
            this.rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSteam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEGS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGOG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrigin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuITD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCME = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSHgames = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSHachs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSHprofiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEXO = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.rightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightClick
            // 
            this.rightClick.BackColor = System.Drawing.SystemColors.Control;
            this.rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSteam,
            this.menuEGS,
            this.menuGOG,
            this.menuOrigin,
            this.menuITD,
            this.toolStripSeparator1,
            this.menuCME,
            this.menuSH,
            this.menuEXO});
            this.rightClick.Name = "contextMenuStrip1";
            this.rightClick.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rightClick.Size = new System.Drawing.Size(156, 186);
            // 
            // menuSteam
            // 
            this.menuSteam.Checked = true;
            this.menuSteam.CheckOnClick = true;
            this.menuSteam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSteam.Name = "menuSteam";
            this.menuSteam.Size = new System.Drawing.Size(155, 22);
            this.menuSteam.Text = "Steam";
            // 
            // menuEGS
            // 
            this.menuEGS.CheckOnClick = true;
            this.menuEGS.Name = "menuEGS";
            this.menuEGS.Size = new System.Drawing.Size(155, 22);
            this.menuEGS.Text = "Epic Games";
            // 
            // menuGOG
            // 
            this.menuGOG.CheckOnClick = true;
            this.menuGOG.Name = "menuGOG";
            this.menuGOG.Size = new System.Drawing.Size(155, 22);
            this.menuGOG.Text = "GOG.com";
            // 
            // menuOrigin
            // 
            this.menuOrigin.CheckOnClick = true;
            this.menuOrigin.Name = "menuOrigin";
            this.menuOrigin.Size = new System.Drawing.Size(155, 22);
            this.menuOrigin.Text = "Origin";
            // 
            // menuITD
            // 
            this.menuITD.CheckOnClick = true;
            this.menuITD.Name = "menuITD";
            this.menuITD.Size = new System.Drawing.Size(155, 22);
            this.menuITD.Text = "IsThereAnyDeal";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // menuCME
            // 
            this.menuCME.CheckOnClick = true;
            this.menuCME.Name = "menuCME";
            this.menuCME.Size = new System.Drawing.Size(155, 22);
            this.menuCME.Text = "Completionist";
            // 
            // menuSH
            // 
            this.menuSH.CheckOnClick = true;
            this.menuSH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSHgames,
            this.menuSHachs,
            this.menuSHprofiles});
            this.menuSH.Name = "menuSH";
            this.menuSH.Size = new System.Drawing.Size(155, 22);
            this.menuSH.Text = "SteamHunters";
            // 
            // menuSHgames
            // 
            this.menuSHgames.Checked = true;
            this.menuSHgames.CheckOnClick = true;
            this.menuSHgames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSHgames.Name = "menuSHgames";
            this.menuSHgames.Size = new System.Drawing.Size(149, 22);
            this.menuSHgames.Text = "Games";
            // 
            // menuSHachs
            // 
            this.menuSHachs.CheckOnClick = true;
            this.menuSHachs.Name = "menuSHachs";
            this.menuSHachs.Size = new System.Drawing.Size(149, 22);
            this.menuSHachs.Text = "Achievements";
            // 
            // menuSHprofiles
            // 
            this.menuSHprofiles.CheckOnClick = true;
            this.menuSHprofiles.Name = "menuSHprofiles";
            this.menuSHprofiles.Size = new System.Drawing.Size(149, 22);
            this.menuSHprofiles.Text = "Profiles";
            // 
            // menuEXO
            // 
            this.menuEXO.CheckOnClick = true;
            this.menuEXO.Name = "menuEXO";
            this.menuEXO.Size = new System.Drawing.Size(155, 22);
            this.menuEXO.Text = "Exophase";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Black;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.ContextMenuStrip = this.rightClick;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.White;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 27);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.WordWrap = false;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // DeskBandUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.textBoxSearch);
            this.Name = "DeskBandUI";
            this.Size = new System.Drawing.Size(150, 28);
            this.rightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip rightClick;
        private System.Windows.Forms.ToolStripMenuItem menuSteam;
        private System.Windows.Forms.ToolStripMenuItem menuEGS;
        private System.Windows.Forms.ToolStripMenuItem menuGOG;
        private System.Windows.Forms.ToolStripMenuItem menuOrigin;
        private System.Windows.Forms.ToolStripMenuItem menuITD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuCME;
        private System.Windows.Forms.ToolStripMenuItem menuSH;
        private System.Windows.Forms.ToolStripMenuItem menuSHgames;
        private System.Windows.Forms.ToolStripMenuItem menuSHachs;
        private System.Windows.Forms.ToolStripMenuItem menuSHprofiles;
        private System.Windows.Forms.ToolStripMenuItem menuEXO;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}
