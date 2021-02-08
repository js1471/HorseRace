
namespace HorseRace
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
            this.racebtn = new System.Windows.Forms.Button();
            this.SahibBet = new System.Windows.Forms.Label();
            this.InderBet = new System.Windows.Forms.Label();
            this.JashanBet = new System.Windows.Forms.Label();
            this.sahibButton = new System.Windows.Forms.RadioButton();
            this.inderRButton = new System.Windows.Forms.RadioButton();
            this.jashanRButton = new System.Windows.Forms.RadioButton();
            this.Bets = new System.Windows.Forms.Button();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.HorseNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.Horse1 = new System.Windows.Forms.PictureBox();
            this.Horse2 = new System.Windows.Forms.PictureBox();
            this.Horse3 = new System.Windows.Forms.PictureBox();
            this.Horse4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jbet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).BeginInit();
            this.SuspendLayout();
            // 
            // racebtn
            // 
            this.racebtn.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.racebtn.FlatAppearance.BorderSize = 5;
            this.racebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.racebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.racebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.racebtn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.racebtn.Location = new System.Drawing.Point(1074, 386);
            this.racebtn.Name = "racebtn";
            this.racebtn.Size = new System.Drawing.Size(139, 60);
            this.racebtn.TabIndex = 0;
            this.racebtn.Text = "RACE";
            this.racebtn.UseVisualStyleBackColor = true;
            this.racebtn.Click += new System.EventHandler(this.racebtn_Click);
            // 
            // SahibBet
            // 
            this.SahibBet.BackColor = System.Drawing.SystemColors.Info;
            this.SahibBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SahibBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SahibBet.Location = new System.Drawing.Point(613, 407);
            this.SahibBet.Name = "SahibBet";
            this.SahibBet.Size = new System.Drawing.Size(301, 29);
            this.SahibBet.TabIndex = 12;
            this.SahibBet.Text = "Sahib";
            this.SahibBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SahibBet.Click += new System.EventHandler(this.sahibBet_Click);
            // 
            // InderBet
            // 
            this.InderBet.BackColor = System.Drawing.SystemColors.Info;
            this.InderBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InderBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InderBet.Location = new System.Drawing.Point(613, 465);
            this.InderBet.Name = "InderBet";
            this.InderBet.Size = new System.Drawing.Size(301, 29);
            this.InderBet.TabIndex = 13;
            this.InderBet.Text = "Inder";
            this.InderBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InderBet.Click += new System.EventHandler(this.RogerBet_Click);
            // 
            // JashanBet
            // 
            this.JashanBet.BackColor = System.Drawing.SystemColors.Info;
            this.JashanBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JashanBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JashanBet.Location = new System.Drawing.Point(613, 343);
            this.JashanBet.Name = "JashanBet";
            this.JashanBet.Size = new System.Drawing.Size(301, 28);
            this.JashanBet.TabIndex = 14;
            this.JashanBet.Text = "Jashan";
            this.JashanBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sahibButton
            // 
            this.sahibButton.AutoSize = true;
            this.sahibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sahibButton.Location = new System.Drawing.Point(256, 409);
            this.sahibButton.Name = "sahibButton";
            this.sahibButton.Size = new System.Drawing.Size(68, 22);
            this.sahibButton.TabIndex = 15;
            this.sahibButton.Text = "Sahib";
            this.sahibButton.UseVisualStyleBackColor = true;
            this.sahibButton.CheckedChanged += new System.EventHandler(this.sahibButton_CheckedChanged);
            // 
            // inderRButton
            // 
            this.inderRButton.AutoSize = true;
            this.inderRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inderRButton.Location = new System.Drawing.Point(256, 467);
            this.inderRButton.Name = "inderRButton";
            this.inderRButton.Size = new System.Drawing.Size(63, 22);
            this.inderRButton.TabIndex = 16;
            this.inderRButton.Text = "Inder";
            this.inderRButton.UseVisualStyleBackColor = true;
            this.inderRButton.CheckedChanged += new System.EventHandler(this.inderRButton_CheckedChanged);
            // 
            // jashanRButton
            // 
            this.jashanRButton.AutoSize = true;
            this.jashanRButton.Checked = true;
            this.jashanRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jashanRButton.Location = new System.Drawing.Point(256, 349);
            this.jashanRButton.Name = "jashanRButton";
            this.jashanRButton.Size = new System.Drawing.Size(80, 22);
            this.jashanRButton.TabIndex = 17;
            this.jashanRButton.TabStop = true;
            this.jashanRButton.Text = "Jashan";
            this.jashanRButton.UseVisualStyleBackColor = true;
            this.jashanRButton.CheckedChanged += new System.EventHandler(this.JashanRButton_CheckedChanged);
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bets.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Bets.FlatAppearance.BorderSize = 3;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.Location = new System.Drawing.Point(407, 440);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(108, 49);
            this.Bets.TabIndex = 18;
            this.Bets.Text = "Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // BettingAmount
            // 
            this.BettingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BettingAmount.Location = new System.Drawing.Point(379, 391);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(79, 22);
            this.BettingAmount.TabIndex = 19;
            this.BettingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BettingAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // HorseNumber
            // 
            this.HorseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorseNumber.Location = new System.Drawing.Point(486, 389);
            this.HorseNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HorseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorseNumber.Name = "HorseNumber";
            this.HorseNumber.Size = new System.Drawing.Size(79, 22);
            this.HorseNumber.TabIndex = 20;
            this.HorseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HorseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Horse no:";
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(81, 386);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(96, 25);
            this.MaximumBet.TabIndex = 22;
            this.MaximumBet.Text = "Max bet";
            this.MaximumBet.Visible = false;
            this.MaximumBet.Click += new System.EventHandler(this.MaximumBet_Click);
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, 11);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1364, 278);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 23;
            this.racetrack.TabStop = false;
            // 
            // Horse1
            // 
            this.Horse1.BackColor = System.Drawing.Color.Transparent;
            this.Horse1.Image = ((System.Drawing.Image)(resources.GetObject("Horse1.Image")));
            this.Horse1.Location = new System.Drawing.Point(63, 22);
            this.Horse1.Name = "Horse1";
            this.Horse1.Size = new System.Drawing.Size(72, 48);
            this.Horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse1.TabIndex = 24;
            this.Horse1.TabStop = false;
            this.Horse1.Click += new System.EventHandler(this.Horse1_Click);
            // 
            // Horse2
            // 
            this.Horse2.Image = ((System.Drawing.Image)(resources.GetObject("Horse2.Image")));
            this.Horse2.Location = new System.Drawing.Point(63, 94);
            this.Horse2.Name = "Horse2";
            this.Horse2.Size = new System.Drawing.Size(72, 43);
            this.Horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse2.TabIndex = 25;
            this.Horse2.TabStop = false;
            // 
            // Horse3
            // 
            this.Horse3.Image = ((System.Drawing.Image)(resources.GetObject("Horse3.Image")));
            this.Horse3.Location = new System.Drawing.Point(63, 155);
            this.Horse3.Name = "Horse3";
            this.Horse3.Size = new System.Drawing.Size(72, 48);
            this.Horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse3.TabIndex = 26;
            this.Horse3.TabStop = false;
            // 
            // Horse4
            // 
            this.Horse4.Image = ((System.Drawing.Image)(resources.GetObject("Horse4.Image")));
            this.Horse4.Location = new System.Drawing.Point(63, 228);
            this.Horse4.Name = "Horse4";
            this.Horse4.Size = new System.Drawing.Size(72, 46);
            this.Horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse4.TabIndex = 27;
            this.Horse4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bet Amount:";
            // 
            // jbet
            // 
            this.jbet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jbet.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.jbet.FlatAppearance.BorderSize = 3;
            this.jbet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jbet.Location = new System.Drawing.Point(86, 337);
            this.jbet.Name = "jbet";
            this.jbet.Size = new System.Drawing.Size(108, 49);
            this.jbet.TabIndex = 29;
            this.jbet.Text = "0";
            this.jbet.UseVisualStyleBackColor = false;
            this.jbet.Click += new System.EventHandler(this.jbet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1370, 536);
            this.Controls.Add(this.jbet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Horse4);
            this.Controls.Add(this.Horse3);
            this.Controls.Add(this.Horse2);
            this.Controls.Add(this.Horse1);
            this.Controls.Add(this.racetrack);
            this.Controls.Add(this.MaximumBet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HorseNumber);
            this.Controls.Add(this.BettingAmount);
            this.Controls.Add(this.Bets);
            this.Controls.Add(this.jashanRButton);
            this.Controls.Add(this.inderRButton);
            this.Controls.Add(this.sahibButton);
            this.Controls.Add(this.JashanBet);
            this.Controls.Add(this.InderBet);
            this.Controls.Add(this.SahibBet);
            this.Controls.Add(this.racebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button racebtn;
        private System.Windows.Forms.Label SahibBet;
        private System.Windows.Forms.Label InderBet;
        private System.Windows.Forms.Label JashanBet;
        private System.Windows.Forms.RadioButton sahibButton;
        private System.Windows.Forms.RadioButton inderRButton;
        private System.Windows.Forms.RadioButton jashanRButton;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.NumericUpDown HorseNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox Horse1;
        private System.Windows.Forms.PictureBox Horse2;
        private System.Windows.Forms.PictureBox Horse3;
        private System.Windows.Forms.PictureBox Horse4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jbet;
    }
}

