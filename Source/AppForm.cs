using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHexabot
{
    public partial class AppForm : Form
    {
        /// <summary>
        /// The Super Hexagon playing Bot.
        /// </summary>
        private SuperHexagonBot Bot;

        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            Bot = new SuperHexagonBot();

            MovementStyleDropdown.SelectedIndex = 0;
            Log.Output = LogOutput;
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            Bot.Tick();
            RefreshUI();
        }

        private void RefreshUI()
        {
            if( Bot.GameIsOpen )
            {
                GameStatusLabel.Text = "Super Hexagon detected.";
                GameStatusLabel.BackColor = Color.LightGreen;
            }
            else
            {
                GameStatusLabel.Text = "Super Hexagon is not running.";
                GameStatusLabel.BackColor = Color.OrangeRed;
            }

            if (Bot.IsPlaying)
            {
                PlayingStatus.Text = "Playing game...";
                PlayingStatus.BackColor = Color.LightGreen;
            }
            else
            {
                PlayingStatus.Text = "... Not playing.";
                PlayingStatus.BackColor = Color.OrangeRed;
            }


            WorldAngleLabel.Text = "World Angle: " + Bot.API.WorldAngle;
            WallCountLabel.Text  = "Wall Count: "  + Bot.API.WallCount;
            SideCountLabel.Text  = "Side Count: "  + Bot.API.SideCount;
            SafestSideLabel.Text = "Safest Side: " + Bot.SafestSide;

            ShowWallData();    
        }

        private void ShowWallData()
        {
            List<SuperHexagonAPI.Wall> wallList = Bot.API.GetAllWalls();

            for( int i=0; i < wallList.Count; ++i )
            {
                SuperHexagonAPI.Wall wall = wallList[i];

                if( i < WallTree.Nodes.Count )
                {
                    WallTree.Nodes[i].Text = string.Format("Slot: {0}, Dist: {1}, Width: {2}", wall.Side, wall.Distance, wall.Width);
                }
                else
                {
                    TreeNode node = new TreeNode(string.Format("Slot: {0}, Dist: {1}, Width: {2}", wall.Side, wall.Distance, wall.Width));
                    WallTree.Nodes.Add(node);
                }
            }
        }

        private void ShouldPlayCheck_CheckedChanged(object sender, EventArgs e)
        {
            Bot.ShouldPlay = ShouldPlayCheck.Checked;
        }

        private void ClearLog_Click(object sender, EventArgs e)
        {
            Log.Clear();
        }
    }
}
