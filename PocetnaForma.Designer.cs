namespace WindowsFormsApplication1.Resources
{
    partial class PocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma));
            this.Play = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Play.Enabled = false;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Location = new System.Drawing.Point(149, 282);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Rules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rules.Location = new System.Drawing.Point(343, 282);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(75, 23);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            this.Rules.UseVisualStyleBackColor = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your name:";
            // 
            // ime
            // 
            this.ime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ime.Location = new System.Drawing.Point(268, 256);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(234, 20);
            this.ime.TabIndex = 3;
            this.ime.TextChanged += new System.EventHandler(this.ime_TextChanged);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 335);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Maniac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime;
    }
}
