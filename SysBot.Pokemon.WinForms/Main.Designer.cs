﻿using SysBot.Pokemon.WinForms.Properties;

namespace SysBot.Pokemon.WinForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "192.168.001.001",
            "6000",
            "LinkCode"}, -1);
            this.B_New = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.LV_Bots = new System.Windows.Forms.ListView();
            this.CH_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TC_Main = new System.Windows.Forms.TabControl();
            this.Tab_Bots = new System.Windows.Forms.TabPage();
            this.CB_Routine = new System.Windows.Forms.ComboBox();
            this.NUD_Port = new System.Windows.Forms.NumericUpDown();
            this.B_Stop = new System.Windows.Forms.Button();
            this.B_Start = new System.Windows.Forms.Button();
            this.Tab_Hub = new System.Windows.Forms.TabPage();
            this.PG_Hub = new System.Windows.Forms.PropertyGrid();
            this.Tab_Logs = new System.Windows.Forms.TabPage();
            this.RTB_Logs = new System.Windows.Forms.RichTextBox();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.TC_Main.SuspendLayout();
            this.Tab_Bots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).BeginInit();
            this.Tab_Hub.SuspendLayout();
            this.Tab_Logs.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_New
            // 
            this.B_New.Location = new System.Drawing.Point(3, 5);
            this.B_New.Name = "B_New";
            this.B_New.Size = new System.Drawing.Size(50, 20);
            this.B_New.TabIndex = 0;
            this.B_New.Text = "New";
            this.B_New.UseVisualStyleBackColor = true;
            this.B_New.Click += new System.EventHandler(this.B_New_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.Location = new System.Drawing.Point(59, 5);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(50, 20);
            this.B_Delete.TabIndex = 1;
            this.B_Delete.Text = "Delete";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // LV_Bots
            // 
            this.LV_Bots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Bots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_IP,
            this.CH_Port,
            this.CH_Name});
            this.LV_Bots.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Bots.HideSelection = false;
            this.LV_Bots.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.LV_Bots.Location = new System.Drawing.Point(3, 29);
            this.LV_Bots.Name = "LV_Bots";
            this.LV_Bots.Size = new System.Drawing.Size(511, 183);
            this.LV_Bots.TabIndex = 2;
            this.LV_Bots.UseCompatibleStateImageBehavior = false;
            this.LV_Bots.View = System.Windows.Forms.View.Details;
            // 
            // CH_IP
            // 
            this.CH_IP.Text = "IP";
            this.CH_IP.Width = 120;
            // 
            // CH_Port
            // 
            this.CH_Port.Text = "Port";
            // 
            // CH_Name
            // 
            this.CH_Name.Text = "Name";
            this.CH_Name.Width = 150;
            // 
            // TC_Main
            // 
            this.TC_Main.Controls.Add(this.Tab_Bots);
            this.TC_Main.Controls.Add(this.Tab_Hub);
            this.TC_Main.Controls.Add(this.Tab_Logs);
            this.TC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Main.Location = new System.Drawing.Point(0, 0);
            this.TC_Main.Name = "TC_Main";
            this.TC_Main.SelectedIndex = 0;
            this.TC_Main.Size = new System.Drawing.Size(525, 241);
            this.TC_Main.TabIndex = 3;
            // 
            // Tab_Bots
            // 
            this.Tab_Bots.Controls.Add(this.TB_IP);
            this.Tab_Bots.Controls.Add(this.CB_Routine);
            this.Tab_Bots.Controls.Add(this.NUD_Port);
            this.Tab_Bots.Controls.Add(this.B_Stop);
            this.Tab_Bots.Controls.Add(this.B_Start);
            this.Tab_Bots.Controls.Add(this.B_New);
            this.Tab_Bots.Controls.Add(this.LV_Bots);
            this.Tab_Bots.Controls.Add(this.B_Delete);
            this.Tab_Bots.Location = new System.Drawing.Point(4, 22);
            this.Tab_Bots.Name = "Tab_Bots";
            this.Tab_Bots.Size = new System.Drawing.Size(517, 215);
            this.Tab_Bots.TabIndex = 0;
            this.Tab_Bots.Text = "Bots";
            this.Tab_Bots.UseVisualStyleBackColor = true;
            // 
            // CB_Routine
            // 
            this.CB_Routine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Routine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Routine.FormattingEnabled = true;
            this.CB_Routine.Location = new System.Drawing.Point(300, 5);
            this.CB_Routine.Name = "CB_Routine";
            this.CB_Routine.Size = new System.Drawing.Size(103, 21);
            this.CB_Routine.TabIndex = 7;
            // 
            // NUD_Port
            // 
            this.NUD_Port.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Port.Location = new System.Drawing.Point(236, 6);
            this.NUD_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_Port.Name = "NUD_Port";
            this.NUD_Port.Size = new System.Drawing.Size(58, 20);
            this.NUD_Port.TabIndex = 6;
            this.NUD_Port.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            // 
            // B_Stop
            // 
            this.B_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Stop.Enabled = false;
            this.B_Stop.Location = new System.Drawing.Point(464, 5);
            this.B_Stop.Name = "B_Stop";
            this.B_Stop.Size = new System.Drawing.Size(50, 20);
            this.B_Stop.TabIndex = 4;
            this.B_Stop.Text = "Stop";
            this.B_Stop.UseVisualStyleBackColor = true;
            this.B_Stop.Click += new System.EventHandler(this.B_Stop_Click);
            // 
            // B_Start
            // 
            this.B_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Start.Enabled = false;
            this.B_Start.Location = new System.Drawing.Point(409, 5);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(50, 20);
            this.B_Start.TabIndex = 3;
            this.B_Start.Text = "Start";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // Tab_Hub
            // 
            this.Tab_Hub.Controls.Add(this.PG_Hub);
            this.Tab_Hub.Location = new System.Drawing.Point(4, 22);
            this.Tab_Hub.Name = "Tab_Hub";
            this.Tab_Hub.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Hub.Size = new System.Drawing.Size(517, 215);
            this.Tab_Hub.TabIndex = 2;
            this.Tab_Hub.Text = "Hub";
            this.Tab_Hub.UseVisualStyleBackColor = true;
            // 
            // PG_Hub
            // 
            this.PG_Hub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PG_Hub.Location = new System.Drawing.Point(3, 3);
            this.PG_Hub.Name = "PG_Hub";
            this.PG_Hub.Size = new System.Drawing.Size(511, 209);
            this.PG_Hub.TabIndex = 0;
            // 
            // Tab_Logs
            // 
            this.Tab_Logs.Controls.Add(this.RTB_Logs);
            this.Tab_Logs.Location = new System.Drawing.Point(4, 22);
            this.Tab_Logs.Name = "Tab_Logs";
            this.Tab_Logs.Size = new System.Drawing.Size(517, 215);
            this.Tab_Logs.TabIndex = 1;
            this.Tab_Logs.Text = "Logs";
            this.Tab_Logs.UseVisualStyleBackColor = true;
            // 
            // RTB_Logs
            // 
            this.RTB_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Logs.Location = new System.Drawing.Point(0, 0);
            this.RTB_Logs.Name = "RTB_Logs";
            this.RTB_Logs.Size = new System.Drawing.Size(517, 215);
            this.RTB_Logs.TabIndex = 0;
            this.RTB_Logs.Text = "";
            // 
            // TB_IP
            // 
            this.TB_IP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IP.Location = new System.Drawing.Point(115, 5);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(115, 20);
            this.TB_IP.TabIndex = 8;
            this.TB_IP.Text = "192.168.001.001";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 241);
            this.Controls.Add(this.TC_Main);
            this.Icon = global::SysBot.Pokemon.WinForms.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysBot: Pokémon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.TC_Main.ResumeLayout(false);
            this.Tab_Bots.ResumeLayout(false);
            this.Tab_Bots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).EndInit();
            this.Tab_Hub.ResumeLayout(false);
            this.Tab_Logs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_New;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.ListView LV_Bots;
        private System.Windows.Forms.ColumnHeader CH_Name;
        private System.Windows.Forms.ColumnHeader CH_IP;
        private System.Windows.Forms.ColumnHeader CH_Port;
        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage Tab_Bots;
        private System.Windows.Forms.TabPage Tab_Logs;
        private System.Windows.Forms.RichTextBox RTB_Logs;
        private System.Windows.Forms.TabPage Tab_Hub;
        private System.Windows.Forms.PropertyGrid PG_Hub;
        private System.Windows.Forms.Button B_Stop;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.NumericUpDown NUD_Port;
        private System.Windows.Forms.ComboBox CB_Routine;
        private System.Windows.Forms.TextBox TB_IP;
    }
}

