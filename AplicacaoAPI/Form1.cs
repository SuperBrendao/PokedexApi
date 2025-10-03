using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace AplicacaoAPI
{
    public partial class Form1 : Form
    {
        //CONSTRUTOR
        public Form1()
        {
            InitializeComponent();
        }

        //EVENTOS DE BOTAO
        private void BTM_BuscarPoke_Click(object sender, EventArgs e)
        {
            try
            {
                TB_NomePoke.Text = TB_NomePoke.Text.ToLower();
                MostarSatusPK();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        //METODOS PRIVATOS
        private void MostarSatusPK() 
        {
            BuscarPK.BuscaPK(TB_NomePoke.Text);
            
            L_HpPoke.Text = StatusPK.HP;
            L_AtkPoke.Text = StatusPK.ATK;
            L_DefPoke.Text = StatusPK.DEF;
            L_SpAtkPoke.Text = StatusPK.SPATK;
            L_SpDefPoke.Text = StatusPK.SPDEF;
            L_SpdPoke.Text = StatusPK.SPE;

            PB_SpriteFromPK.ImageLocation = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{StatusPK.Id}.png";
        }


        private void AllClear() 
        {
            L_HpPoke.Text = string.Empty;
            L_AtkPoke.Text = string.Empty;
            L_DefPoke.Text = string.Empty;
            L_SpAtkPoke.Text = string.Empty;
            L_SpDefPoke.Text = string.Empty;
            L_SpdPoke.Text = string.Empty;

            TB_NomePoke.Clear();
            TB_NomePoke.Focus();
        }

       
    }
}
