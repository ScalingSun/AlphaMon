using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alphamon
{
    public partial class GameForm : Form
    {
        UsedAlphamon AlphamonData;
        UsedAlphamon OpponentAlphamonData;
        DB getpower = new DB();
        public CalcDamage calc;
        bool MoveIsSelected = false;
        Stadium Stadium;

        public GameForm()
        {
            InitializeComponent();
            calc = new CalcDamage(AlphamonData, OpponentAlphamonData);
        }

        private void btnSwapAlphamon_Click(object sender, EventArgs e)
        {

        }
        public void setAlphamonData(Stadium Stadium, UsedAlphamon AlphamonData, UsedAlphamon OpponentAlphamonData)
        {
            this.AlphamonData = AlphamonData;
            this.OpponentAlphamonData = OpponentAlphamonData;
            this.Stadium = Stadium;
            //own alphamon
            lblHPBar.Text = AlphamonData.currentHP.ToString() + "/" + AlphamonData.AlphamonData.HP.ToString();
            lblOwnName.Text = AlphamonData.AlphamonData.name;
            lblOwnStatus.Text = AlphamonData.statusID.ToString();
            lbxMoves.Items.Clear();
            lbxMoves.Items.AddRange(AlphamonData.AlphamonData.moves.Select(item => item.name).ToArray());

            //opponent alphamon
            lblOpponentHPBar.Text = OpponentAlphamonData.currentHP.ToString() + "/" + OpponentAlphamonData.AlphamonData.HP.ToString();
            lblOpponentName.Text = OpponentAlphamonData.AlphamonData.name;
            lblOpponentStatus.Text = OpponentAlphamonData.statusID.ToString();
        }

        private void lbxMoves_MouseClick(object sender, MouseEventArgs e)
        {
            lblTurnState.Text = AlphamonData.AlphamonData.name + " will be using: " + lbxMoves.SelectedItem.ToString();
            MoveIsSelected = true;

            Thread thread = new Thread(() =>
            {
                bool clicked = false;
                while(clicked == false)
                {
                    clicked = Stadium.CheckPlayers();
                    Thread.Sleep(10000);
                }
                
                Action ActionOne = new Action(Attack);
                this.BeginInvoke(ActionOne);
                clicked = false;
            });
            thread.Start();

            MessageBox.Show("Wacht op de tegenstander");
        }
        public bool isClicked()
        {
            return MoveIsSelected;
        }

        private void Attack()
        {
            string move = lbxMoves.SelectedItem.ToString();
            int power = getpower.getPowerFromMove(move);
            Stadium.Attack(power);
        }
    }
}
