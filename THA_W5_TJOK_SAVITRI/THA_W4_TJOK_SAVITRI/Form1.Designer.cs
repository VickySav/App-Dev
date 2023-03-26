namespace THA_W4_TJOK_SAVITRI
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPlayerPosition = new System.Windows.Forms.ComboBox();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBoxTeamCountry = new System.Windows.Forms.TextBox();
            this.textBoxPlayerNumber = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.textBoxTeamCity = new System.Windows.Forms.TextBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(164, 88);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(155, 24);
            this.comboBoxCountry.TabIndex = 1;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose Team:";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(164, 134);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(155, 24);
            this.comboBoxTeam.TabIndex = 3;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Team Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Team Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Team City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(694, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Player Position:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Player Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(694, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Player Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Adding Team";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(832, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Adding Players";
            // 
            // comboBoxPlayerPosition
            // 
            this.comboBoxPlayerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayerPosition.FormattingEnabled = true;
            this.comboBoxPlayerPosition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBoxPlayerPosition.Location = new System.Drawing.Point(803, 139);
            this.comboBoxPlayerPosition.Name = "comboBoxPlayerPosition";
            this.comboBoxPlayerPosition.Size = new System.Drawing.Size(155, 24);
            this.comboBoxPlayerPosition.TabIndex = 13;
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(509, 75);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(158, 22);
            this.textBoxTeamName.TabIndex = 14;
            // 
            // textBoxTeamCountry
            // 
            this.textBoxTeamCountry.Location = new System.Drawing.Point(507, 103);
            this.textBoxTeamCountry.Name = "textBoxTeamCountry";
            this.textBoxTeamCountry.Size = new System.Drawing.Size(158, 22);
            this.textBoxTeamCountry.TabIndex = 15;
            // 
            // textBoxPlayerNumber
            // 
            this.textBoxPlayerNumber.Location = new System.Drawing.Point(803, 110);
            this.textBoxPlayerNumber.Name = "textBoxPlayerNumber";
            this.textBoxPlayerNumber.Size = new System.Drawing.Size(158, 22);
            this.textBoxPlayerNumber.TabIndex = 17;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(803, 75);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(158, 22);
            this.textBoxPlayerName.TabIndex = 16;
            // 
            // textBoxTeamCity
            // 
            this.textBoxTeamCity.Location = new System.Drawing.Point(507, 135);
            this.textBoxTeamCity.Name = "textBoxTeamCity";
            this.textBoxTeamCity.Size = new System.Drawing.Size(158, 22);
            this.textBoxTeamCity.TabIndex = 18;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(554, 169);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(60, 23);
            this.buttonAddTeam.TabIndex = 19;
            this.buttonAddTeam.Text = "Add";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(847, 169);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(60, 23);
            this.buttonAddPlayer.TabIndex = 20;
            this.buttonAddPlayer.Text = "Add";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(31, 193);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(307, 164);
            this.listBoxData.TabIndex = 21;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(31, 363);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(77, 23);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.textBoxTeamCity);
            this.Controls.Add(this.textBoxPlayerNumber);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.textBoxTeamCountry);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.comboBoxPlayerPosition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPlayerPosition;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.TextBox textBoxTeamCountry;
        private System.Windows.Forms.TextBox textBoxPlayerNumber;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.TextBox textBoxTeamCity;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button button1;
    }
}

