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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeskBandUI));
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rightClick.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonGo.FlatAppearance.BorderSize = 0;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Image = ((System.Drawing.Image)(resources.GetObject("buttonGo.Image")));
            this.buttonGo.Location = new System.Drawing.Point(161, 0);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(28, 28);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.Black;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.ContextMenuStrip = this.rightClick;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.White;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(161, 28);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.WordWrap = false;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.tableLayoutPanel1.Controls.Add(this.buttonGo);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(189, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DeskBandUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeskBandUI";
            this.Size = new System.Drawing.Size(189, 28);
            this.rightClick.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}
