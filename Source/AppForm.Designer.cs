namespace SuperHexabot
{
    partial class AppForm
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
            this.GameStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DieAfterXCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovementStyleDropdown = new System.Windows.Forms.ComboBox();
            this.DieAfterXCheck = new System.Windows.Forms.CheckBox();
            this.DontBeatScoresCheck = new System.Windows.Forms.CheckBox();
            this.ShouldPlayCheck = new System.Windows.Forms.CheckBox();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.WorldAngleLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SafestSideLabel = new System.Windows.Forms.Label();
            this.SideCountLabel = new System.Windows.Forms.Label();
            this.WallCountLabel = new System.Windows.Forms.Label();
            this.WallTree = new System.Windows.Forms.TreeView();
            this.LogOutput = new System.Windows.Forms.TextBox();
            this.PlayingStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameStatusLabel
            // 
            this.GameStatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStatusLabel.Location = new System.Drawing.Point(12, 9);
            this.GameStatusLabel.Name = "GameStatusLabel";
            this.GameStatusLabel.Size = new System.Drawing.Size(275, 33);
            this.GameStatusLabel.TabIndex = 0;
            this.GameStatusLabel.Text = "Super Hexagon is closed";
            this.GameStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DieAfterXCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MovementStyleDropdown);
            this.groupBox1.Controls.Add(this.DieAfterXCheck);
            this.groupBox1.Controls.Add(this.DontBeatScoresCheck);
            this.groupBox1.Controls.Add(this.ShouldPlayCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(125, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "seconds [TODO]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DieAfterXCount
            // 
            this.DieAfterXCount.Enabled = false;
            this.DieAfterXCount.Location = new System.Drawing.Point(80, 78);
            this.DieAfterXCount.Name = "DieAfterXCount";
            this.DieAfterXCount.Size = new System.Drawing.Size(39, 20);
            this.DieAfterXCount.TabIndex = 4;
            this.DieAfterXCount.Text = "56";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movement Style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MovementStyleDropdown
            // 
            this.MovementStyleDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovementStyleDropdown.FormattingEnabled = true;
            this.MovementStyleDropdown.Items.AddRange(new object[] {
            "Teleport",
            "Locomotion"});
            this.MovementStyleDropdown.Location = new System.Drawing.Point(101, 110);
            this.MovementStyleDropdown.Name = "MovementStyleDropdown";
            this.MovementStyleDropdown.Size = new System.Drawing.Size(111, 21);
            this.MovementStyleDropdown.TabIndex = 2;
            // 
            // DieAfterXCheck
            // 
            this.DieAfterXCheck.AutoSize = true;
            this.DieAfterXCheck.Enabled = false;
            this.DieAfterXCheck.Location = new System.Drawing.Point(16, 79);
            this.DieAfterXCheck.Name = "DieAfterXCheck";
            this.DieAfterXCheck.Size = new System.Drawing.Size(66, 17);
            this.DieAfterXCheck.TabIndex = 1;
            this.DieAfterXCheck.Text = "Die after";
            this.DieAfterXCheck.UseVisualStyleBackColor = true;
            // 
            // DontBeatScoresCheck
            // 
            this.DontBeatScoresCheck.AutoSize = true;
            this.DontBeatScoresCheck.Enabled = false;
            this.DontBeatScoresCheck.Location = new System.Drawing.Point(16, 52);
            this.DontBeatScoresCheck.Name = "DontBeatScoresCheck";
            this.DontBeatScoresCheck.Size = new System.Drawing.Size(176, 17);
            this.DontBeatScoresCheck.TabIndex = 1;
            this.DontBeatScoresCheck.Text = "Don\'t beat High Scores [TODO]";
            this.DontBeatScoresCheck.UseVisualStyleBackColor = true;
            // 
            // ShouldPlayCheck
            // 
            this.ShouldPlayCheck.AutoSize = true;
            this.ShouldPlayCheck.Location = new System.Drawing.Point(16, 25);
            this.ShouldPlayCheck.Name = "ShouldPlayCheck";
            this.ShouldPlayCheck.Size = new System.Drawing.Size(77, 17);
            this.ShouldPlayCheck.TabIndex = 1;
            this.ShouldPlayCheck.Text = "Play Game";
            this.ShouldPlayCheck.UseVisualStyleBackColor = true;
            this.ShouldPlayCheck.CheckedChanged += new System.EventHandler(this.ShouldPlayCheck_CheckedChanged);
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Tick += new System.EventHandler(this.TickTimer_Tick);
            // 
            // WorldAngleLabel
            // 
            this.WorldAngleLabel.AutoSize = true;
            this.WorldAngleLabel.Location = new System.Drawing.Point(19, 27);
            this.WorldAngleLabel.Name = "WorldAngleLabel";
            this.WorldAngleLabel.Size = new System.Drawing.Size(74, 13);
            this.WorldAngleLabel.TabIndex = 2;
            this.WorldAngleLabel.Text = "World Angle: -";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SafestSideLabel);
            this.groupBox2.Controls.Add(this.SideCountLabel);
            this.groupBox2.Controls.Add(this.WallCountLabel);
            this.groupBox2.Controls.Add(this.WorldAngleLabel);
            this.groupBox2.Location = new System.Drawing.Point(293, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // SafestSideLabel
            // 
            this.SafestSideLabel.AutoSize = true;
            this.SafestSideLabel.Location = new System.Drawing.Point(124, 27);
            this.SafestSideLabel.Name = "SafestSideLabel";
            this.SafestSideLabel.Size = new System.Drawing.Size(64, 13);
            this.SafestSideLabel.TabIndex = 2;
            this.SafestSideLabel.Text = "Safest Side:";
            // 
            // SideCountLabel
            // 
            this.SideCountLabel.AutoSize = true;
            this.SideCountLabel.Location = new System.Drawing.Point(19, 75);
            this.SideCountLabel.Name = "SideCountLabel";
            this.SideCountLabel.Size = new System.Drawing.Size(65, 13);
            this.SideCountLabel.TabIndex = 2;
            this.SideCountLabel.Text = "Wall Count: ";
            // 
            // WallCountLabel
            // 
            this.WallCountLabel.AutoSize = true;
            this.WallCountLabel.Location = new System.Drawing.Point(19, 51);
            this.WallCountLabel.Name = "WallCountLabel";
            this.WallCountLabel.Size = new System.Drawing.Size(65, 13);
            this.WallCountLabel.TabIndex = 2;
            this.WallCountLabel.Text = "Wall Count: ";
            // 
            // WallTree
            // 
            this.WallTree.Location = new System.Drawing.Point(293, 235);
            this.WallTree.Name = "WallTree";
            this.WallTree.Size = new System.Drawing.Size(273, 251);
            this.WallTree.TabIndex = 3;
            // 
            // LogOutput
            // 
            this.LogOutput.Location = new System.Drawing.Point(12, 235);
            this.LogOutput.Multiline = true;
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogOutput.Size = new System.Drawing.Size(275, 251);
            this.LogOutput.TabIndex = 4;
            // 
            // PlayingStatus
            // 
            this.PlayingStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlayingStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingStatus.Location = new System.Drawing.Point(293, 9);
            this.PlayingStatus.Name = "PlayingStatus";
            this.PlayingStatus.Size = new System.Drawing.Size(273, 33);
            this.PlayingStatus.TabIndex = 0;
            this.PlayingStatus.Text = "Not playing...";
            this.PlayingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Walls";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearLog
            // 
            this.ClearLog.Location = new System.Drawing.Point(227, 206);
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(56, 23);
            this.ClearLog.TabIndex = 5;
            this.ClearLog.Text = "Clear";
            this.ClearLog.UseVisualStyleBackColor = true;
            this.ClearLog.Click += new System.EventHandler(this.ClearLog_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 493);
            this.Controls.Add(this.ClearLog);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.WallTree);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlayingStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GameStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppForm";
            this.Text = "Super Hexabot";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameStatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox DontBeatScoresCheck;
        private System.Windows.Forms.CheckBox ShouldPlayCheck;
        private System.Windows.Forms.Timer TickTimer;
        private System.Windows.Forms.Label WorldAngleLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label WallCountLabel;
        private System.Windows.Forms.TreeView WallTree;
        private System.Windows.Forms.Label SideCountLabel;
        private System.Windows.Forms.Label SafestSideLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MovementStyleDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DieAfterXCount;
        private System.Windows.Forms.CheckBox DieAfterXCheck;
        private System.Windows.Forms.TextBox LogOutput;
        private System.Windows.Forms.Label PlayingStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearLog;
    }
}

