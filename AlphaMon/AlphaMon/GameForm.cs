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
        int OwnSpeed;
        int OwnPower;
        int OpponentSpeed;
        public GameForm()
        {
            InitializeComponent();
            calc = new CalcDamage(AlphamonData, OpponentAlphamonData);
        }
        public GameForm(int speed, int power)
        {
           OwnSpeed = speed;
           OwnPower = power;
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
            
            if (AlphamonData.statusID == 4)
            {
                 OwnSpeed = AlphamonData.AlphamonData.Speed / 2;
            }
            else
            {
                OwnSpeed = AlphamonData.AlphamonData.Speed;
            }
            


            //opponent alphamon
            lblOpponentHPBar.Text = OpponentAlphamonData.currentHP.ToString() + "/" + OpponentAlphamonData.AlphamonData.HP.ToString();
            lblOpponentName.Text = OpponentAlphamonData.AlphamonData.name;
            lblOpponentStatus.Text = OpponentAlphamonData.statusID.ToString();
            
            if (OpponentAlphamonData.statusID == 4)
            {
                OpponentSpeed = OpponentAlphamonData.AlphamonData.Speed / 2;
            }
            else
            {
                OpponentSpeed = OpponentAlphamonData.AlphamonData.Speed;
            }
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
                    Thread.Sleep(3000);
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
            List<GameForm> AttackData = new List<GameForm>();
            AttackData.Add(this);
            AttackData.Add(new GameForm(OwnSpeed,OwnPower));
            Stadium.Attack(AttackData);
        }
    }
}
