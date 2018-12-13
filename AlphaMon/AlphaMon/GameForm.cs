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
        public GameForm()
        {
            InitializeComponent();
        }

        private void btnSwapAlphamon_Click(object sender, EventArgs e)
        {

        }
        public void setAlphamonData(UsedAlphaMon AlphamonData, UsedAlphaMon OpponentAlphamonData)
        {
            this.AlphamonData = AlphamonData;
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
        }
    }
}
