using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaMon
{
    public partial class GameForm : Form
    {
        UsedAlphaMon AlphamonData;
        UsedAlphaMon OpponentAlphamonData;
        DB getpower = new DB();
        public CalcDamage calc;
        bool MoveIsSelected = false;

        public GameForm()
        {
            InitializeComponent();
            calc = new CalcDamage(AlphamonData, OpponentAlphamonData);
        }

        private void btnSwapAlphamon_Click(object sender, EventArgs e)
        {

        }
        public void setAlphamonData(UsedAlphaMon AlphamonData, UsedAlphaMon OpponentAlphamonData)
        {
            this.AlphamonData = AlphamonData;
            this.OpponentAlphamonData = OpponentAlphamonData;
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
            string move = lbxMoves.SelectedItem.ToString();
            int power = getpower.getPowerFromMove(move);
            MoveIsSelected = true;
            isClicked();
            calc.Attack(power);
        }
        public bool isClicked()
        {
            return MoveIsSelected;
        }
    }
}
