namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.kosnica = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.kosnicka1 = new System.Windows.Forms.PictureBox();
            this.kosnicka2 = new System.Windows.Forms.PictureBox();
            this.kosnicka3 = new System.Windows.Forms.PictureBox();
            this.kosnicka4 = new System.Windows.Forms.PictureBox();
            this.kosnicka5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gjubre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewGame = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kosnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // kosnica
            // 
            this.kosnica.BackColor = System.Drawing.Color.Transparent;
            this.kosnica.Image = ((System.Drawing.Image)(resources.GetObject("kosnica.Image")));
            this.kosnica.Location = new System.Drawing.Point(254, 313);
            this.kosnica.Name = "kosnica";
            this.kosnica.Size = new System.Drawing.Size(167, 80);
            this.kosnica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kosnica.TabIndex = 0;
            this.kosnica.TabStop = false;
            this.kosnica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.kosnica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer3
            // 
            this.timer3.Interval = 1500;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Image = global::WindowsFormsApplication1.Properties.Resources.frame;
            this.pictureBox5.Location = new System.Drawing.Point(617, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(220, 393);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(641, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 44);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(753, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 57);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(837, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // kosnicka1
            // 
            this.kosnicka1.BackColor = System.Drawing.Color.White;
            this.kosnicka1.Enabled = false;
            this.kosnicka1.Image = global::WindowsFormsApplication1.Properties.Resources.full_viollet_basket;
            this.kosnicka1.Location = new System.Drawing.Point(715, 313);
            this.kosnicka1.Name = "kosnicka1";
            this.kosnicka1.Size = new System.Drawing.Size(97, 55);
            this.kosnicka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kosnicka1.TabIndex = 9;
            this.kosnicka1.TabStop = false;
            this.kosnicka1.Visible = false;
            // 
            // kosnicka2
            // 
            this.kosnicka2.BackColor = System.Drawing.Color.White;
            this.kosnicka2.Image = global::WindowsFormsApplication1.Properties.Resources.full_red_basket;
            this.kosnicka2.Location = new System.Drawing.Point(715, 273);
            this.kosnicka2.Name = "kosnicka2";
            this.kosnicka2.Size = new System.Drawing.Size(97, 44);
            this.kosnicka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kosnicka2.TabIndex = 10;
            this.kosnicka2.TabStop = false;
            this.kosnicka2.Visible = false;
            // 
            // kosnicka3
            // 
            this.kosnicka3.BackColor = System.Drawing.Color.White;
            this.kosnicka3.Image = global::WindowsFormsApplication1.Properties.Resources.full_basket_blue;
            this.kosnicka3.Location = new System.Drawing.Point(715, 225);
            this.kosnicka3.Name = "kosnicka3";
            this.kosnicka3.Size = new System.Drawing.Size(97, 52);
            this.kosnicka3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kosnicka3.TabIndex = 11;
            this.kosnicka3.TabStop = false;
            this.kosnicka3.Visible = false;
            // 
            // kosnicka4
            // 
            this.kosnicka4.BackColor = System.Drawing.Color.White;
            this.kosnicka4.Image = global::WindowsFormsApplication1.Properties.Resources.full_yellow_basket;
            this.kosnicka4.Location = new System.Drawing.Point(715, 181);
            this.kosnicka4.Name = "kosnicka4";
            this.kosnicka4.Size = new System.Drawing.Size(97, 48);
            this.kosnicka4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kosnicka4.TabIndex = 12;
            this.kosnicka4.TabStop = false;
            this.kosnicka4.Visible = false;
            // 
            // kosnicka5
            // 
            this.kosnicka5.BackColor = System.Drawing.Color.White;
            this.kosnicka5.Image = global::WindowsFormsApplication1.Properties.Resources.full_green_basket;
            this.kosnicka5.Location = new System.Drawing.Point(715, 137);
            this.kosnicka5.Name = "kosnicka5";
            this.kosnicka5.Size = new System.Drawing.Size(97, 48);
            this.kosnicka5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kosnicka5.TabIndex = 13;
            this.kosnicka5.TabStop = false;
            this.kosnicka5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(638, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Scores:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(674, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(37, 25);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gjubre
            // 
            this.gjubre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gjubre.Enabled = false;
            this.gjubre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gjubre.Location = new System.Drawing.Point(679, 328);
            this.gjubre.Multiline = true;
            this.gjubre.Name = "gjubre";
            this.gjubre.ReadOnly = true;
            this.gjubre.Size = new System.Drawing.Size(32, 29);
            this.gjubre.TabIndex = 16;
            this.gjubre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.korpa;
            this.pictureBox1.Location = new System.Drawing.Point(641, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewGame.Location = new System.Drawing.Point(641, 195);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(68, 23);
            this.NewGame.TabIndex = 18;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rules.Location = new System.Drawing.Point(641, 224);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(68, 23);
            this.rules.TabIndex = 19;
            this.rules.Text = "Rules";
            this.rules.UseVisualStyleBackColor = false;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // scores
            // 
            this.scores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.scores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scores.Location = new System.Drawing.Point(641, 254);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(68, 23);
            this.scores.TabIndex = 20;
            this.scores.Text = "Scores";
            this.scores.UseVisualStyleBackColor = false;
            this.scores.Click += new System.EventHandler(this.scores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(155, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 112);
            this.label2.TabIndex = 21;
            this.label2.Text = "Level 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(638, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(664, 166);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(47, 25);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 413);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gjubre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kosnicka5);
            this.Controls.Add(this.kosnicka4);
            this.Controls.Add(this.kosnicka3);
            this.Controls.Add(this.kosnicka2);
            this.Controls.Add(this.kosnicka1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.kosnica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Maniac";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.kosnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnicka5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox kosnica;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox kosnicka1;
        private System.Windows.Forms.PictureBox kosnicka2;
        private System.Windows.Forms.PictureBox kosnicka3;
        private System.Windows.Forms.PictureBox kosnicka4;
        private System.Windows.Forms.PictureBox kosnicka5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox gjubre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button rules;
        private System.Windows.Forms.Button scores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

