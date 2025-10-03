namespace AplicacaoAPI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_NomePoke = new System.Windows.Forms.TextBox();
            this.BTM_BuscarPoke = new System.Windows.Forms.Button();
            this.L_HpPoke = new System.Windows.Forms.Label();
            this.L_AtkPoke = new System.Windows.Forms.Label();
            this.L_DefPoke = new System.Windows.Forms.Label();
            this.L_SpAtkPoke = new System.Windows.Forms.Label();
            this.L_SpDefPoke = new System.Windows.Forms.Label();
            this.L_SpdPoke = new System.Windows.Forms.Label();
            this.PB_SpriteFromPK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SpriteFromPK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NomePokemon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ATK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DEF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "SP.ATK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SP.DEF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "SPD:";
            // 
            // TB_NomePoke
            // 
            this.TB_NomePoke.Location = new System.Drawing.Point(316, 57);
            this.TB_NomePoke.Name = "TB_NomePoke";
            this.TB_NomePoke.Size = new System.Drawing.Size(164, 26);
            this.TB_NomePoke.TabIndex = 7;
            // 
            // BTM_BuscarPoke
            // 
            this.BTM_BuscarPoke.Location = new System.Drawing.Point(518, 53);
            this.BTM_BuscarPoke.Name = "BTM_BuscarPoke";
            this.BTM_BuscarPoke.Size = new System.Drawing.Size(95, 35);
            this.BTM_BuscarPoke.TabIndex = 9;
            this.BTM_BuscarPoke.Text = "Buscar";
            this.BTM_BuscarPoke.UseVisualStyleBackColor = true;
            this.BTM_BuscarPoke.Click += new System.EventHandler(this.BTM_BuscarPoke_Click);
            // 
            // L_HpPoke
            // 
            this.L_HpPoke.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.L_HpPoke.AllowDrop = true;
            this.L_HpPoke.AutoEllipsis = true;
            this.L_HpPoke.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.L_HpPoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_HpPoke.Cursor = System.Windows.Forms.Cursors.Default;
            this.L_HpPoke.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L_HpPoke.ForeColor = System.Drawing.SystemColors.InfoText;
            this.L_HpPoke.Location = new System.Drawing.Point(396, 120);
            this.L_HpPoke.Name = "L_HpPoke";
            this.L_HpPoke.Size = new System.Drawing.Size(84, 20);
            this.L_HpPoke.TabIndex = 10;
            // 
            // L_AtkPoke
            // 
            this.L_AtkPoke.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.L_AtkPoke.AllowDrop = true;
            this.L_AtkPoke.AutoEllipsis = true;
            this.L_AtkPoke.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.L_AtkPoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_AtkPoke.Cursor = System.Windows.Forms.Cursors.Default;
            this.L_AtkPoke.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L_AtkPoke.ForeColor = System.Drawing.SystemColors.InfoText;
            this.L_AtkPoke.Location = new System.Drawing.Point(396, 157);
            this.L_AtkPoke.Name = "L_AtkPoke";
            this.L_AtkPoke.Size = new System.Drawing.Size(84, 20);
            this.L_AtkPoke.TabIndex = 11;
            // 
            // L_DefPoke
            // 
            this.L_DefPoke.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.L_DefPoke.AllowDrop = true;
            this.L_DefPoke.AutoEllipsis = true;
            this.L_DefPoke.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.L_DefPoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_DefPoke.Cursor = System.Windows.Forms.Cursors.Default;
            this.L_DefPoke.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L_DefPoke.ForeColor = System.Drawing.SystemColors.InfoText;
            this.L_DefPoke.Location = new System.Drawing.Point(396, 193);
            this.L_DefPoke.Name = "L_DefPoke";
            this.L_DefPoke.Size = new System.Drawing.Size(84, 20);
            this.L_DefPoke.TabIndex = 12;
            // 
            // L_SpAtkPoke
            // 
            this.L_SpAtkPoke.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.L_SpAtkPoke.AllowDrop = true;
            this.L_SpAtkPoke.AutoEllipsis = true;
            this.L_SpAtkPoke.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.L_SpAtkPoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_SpAtkPoke.Cursor = System.Windows.Forms.Cursors.Default;
            this.L_SpAtkPoke.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L_SpAtkPoke.ForeColor = System.Drawing.SystemColors.InfoText;
            this.L_SpAtkPoke.Location = new System.Drawing.Point(396, 226);
            this.L_SpAtkPoke.Name = "L_SpAtkPoke";
            this.L_SpAtkPoke.Size = new System.Drawing.Size(84, 20);
            this.L_SpAtkPoke.TabIndex = 13;
            // 
            // L_SpDefPoke
            // 
            this.L_SpDefPoke.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.L_SpDefPoke.AllowDrop = true;
            this.L_SpDefPoke.AutoEllipsis = true;
            this.L_SpDefPoke.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.L_SpDefPoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_SpDefPoke.Cursor = System.Windows.Forms.Cursors.Default;
            this.L_SpDefPoke.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L_SpDefPoke.ForeColor = System.Drawing.SystemColors.InfoText;
            this.L_SpDefPoke.Location = new System.Drawing.Point(396, 259);
            this.L_SpDefPoke.Name = "L_SpDefPoke";
            this.L_SpDefPoke.Size = new System.Drawing.Size(84, 20);
            this.L_SpDefPoke.TabIndex = 14;
            // 
            // L_SpdPoke
            // 
            this.L_SpdPoke.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.L_SpdPoke.AllowDrop = true;
            this.L_SpdPoke.AutoEllipsis = true;
            this.L_SpdPoke.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.L_SpdPoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_SpdPoke.Cursor = System.Windows.Forms.Cursors.Default;
            this.L_SpdPoke.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L_SpdPoke.ForeColor = System.Drawing.SystemColors.InfoText;
            this.L_SpdPoke.Location = new System.Drawing.Point(396, 295);
            this.L_SpdPoke.Name = "L_SpdPoke";
            this.L_SpdPoke.Size = new System.Drawing.Size(84, 20);
            this.L_SpdPoke.TabIndex = 15;
            // 
            // PB_SpriteFromPK
            // 
            this.PB_SpriteFromPK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PB_SpriteFromPK.Image = global::AplicacaoAPI.Properties.Resources.Test21;
            this.PB_SpriteFromPK.Location = new System.Drawing.Point(540, 120);
            this.PB_SpriteFromPK.Name = "PB_SpriteFromPK";
            this.PB_SpriteFromPK.Size = new System.Drawing.Size(218, 195);
            this.PB_SpriteFromPK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_SpriteFromPK.TabIndex = 16;
            this.PB_SpriteFromPK.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.PB_SpriteFromPK);
            this.Controls.Add(this.L_SpdPoke);
            this.Controls.Add(this.L_SpDefPoke);
            this.Controls.Add(this.L_SpAtkPoke);
            this.Controls.Add(this.L_DefPoke);
            this.Controls.Add(this.L_AtkPoke);
            this.Controls.Add(this.L_HpPoke);
            this.Controls.Add(this.BTM_BuscarPoke);
            this.Controls.Add(this.TB_NomePoke);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.PB_SpriteFromPK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_NomePoke;
        private System.Windows.Forms.Button BTM_BuscarPoke;
        private System.Windows.Forms.Label L_HpPoke;
        private System.Windows.Forms.Label L_AtkPoke;
        private System.Windows.Forms.Label L_DefPoke;
        private System.Windows.Forms.Label L_SpAtkPoke;
        private System.Windows.Forms.Label L_SpDefPoke;
        private System.Windows.Forms.Label L_SpdPoke;
        private System.Windows.Forms.PictureBox PB_SpriteFromPK;
    }
}

