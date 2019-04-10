namespace High_Proirity_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnChooseProgram = new System.Windows.Forms.Button();
            this.BtnRunProgram = new System.Windows.Forms.Button();
            this.priorList = new System.Windows.Forms.ComboBox();
            this.SteamTxt = new System.Windows.Forms.TextBox();
            this.steamCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnChooseProgram
            // 
            this.BtnChooseProgram.Location = new System.Drawing.Point(12, 12);
            this.BtnChooseProgram.Name = "BtnChooseProgram";
            this.BtnChooseProgram.Size = new System.Drawing.Size(274, 23);
            this.BtnChooseProgram.TabIndex = 0;
            this.BtnChooseProgram.Text = "Choose Program";
            this.BtnChooseProgram.UseVisualStyleBackColor = true;
            this.BtnChooseProgram.Click += new System.EventHandler(this.BtnChooseProgram_Click);
            // 
            // BtnRunProgram
            // 
            this.BtnRunProgram.Location = new System.Drawing.Point(12, 41);
            this.BtnRunProgram.Name = "BtnRunProgram";
            this.BtnRunProgram.Size = new System.Drawing.Size(274, 23);
            this.BtnRunProgram.TabIndex = 1;
            this.BtnRunProgram.Text = "Run Program";
            this.BtnRunProgram.UseVisualStyleBackColor = true;
            this.BtnRunProgram.Click += new System.EventHandler(this.BtnRunProgram_Click);
            // 
            // priorList
            // 
            this.priorList.FormattingEnabled = true;
            this.priorList.Items.AddRange(new object[] {
            "Idle (Not Recommended)",
            "BelowNormal",
            "Normal (Using the internet)",
            "AboveNormal",
            "High (Games and Productivity)",
            "RealTime (Dangerous)"});
            this.priorList.Location = new System.Drawing.Point(12, 70);
            this.priorList.Name = "priorList";
            this.priorList.Size = new System.Drawing.Size(274, 21);
            this.priorList.TabIndex = 2;
            // 
            // SteamTxt
            // 
            this.SteamTxt.Location = new System.Drawing.Point(12, 98);
            this.SteamTxt.Name = "SteamTxt";
            this.SteamTxt.ReadOnly = true;
            this.SteamTxt.Size = new System.Drawing.Size(274, 20);
            this.SteamTxt.TabIndex = 3;
            // 
            // steamCheck
            // 
            this.steamCheck.AutoSize = true;
            this.steamCheck.FlatAppearance.BorderSize = 0;
            this.steamCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.steamCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.steamCheck.Location = new System.Drawing.Point(12, 124);
            this.steamCheck.Name = "steamCheck";
            this.steamCheck.Size = new System.Drawing.Size(53, 17);
            this.steamCheck.TabIndex = 4;
            this.steamCheck.Text = "Steam";
            this.steamCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.steamCheck);
            this.Controls.Add(this.SteamTxt);
            this.Controls.Add(this.priorList);
            this.Controls.Add(this.BtnRunProgram);
            this.Controls.Add(this.BtnChooseProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "High Priority Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChooseProgram;
        private System.Windows.Forms.Button BtnRunProgram;
        public System.Windows.Forms.ComboBox priorList;
        public System.Windows.Forms.TextBox SteamTxt;
        public System.Windows.Forms.CheckBox steamCheck;
    }
}

