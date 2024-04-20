using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace csharp_skiing_game
{
    public partial class Form1 : Form
    {
        int gamespeed1 = 2;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Box_KeyDown;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy(gamespeed1);
        }








        private void Box_KeyDown(object? sender, KeyEventArgs e)
        {

            int movementSpeed = 25;

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (skier.Left > 31)
                    skier.Left -= movementSpeed;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (skier.Right < 360)
                    skier.Left += movementSpeed;
            }
        }

        Random rand = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (rock.Top >= 500)
            {
                x = rand.Next(0, 350);

                rock.Location = new Point(x, 0);
            }
            else { rock.Top += speed; }

            if (tree1.Top >= 500)
            {
                x = rand.Next(0, 350);

                tree1.Location = new Point(x, 0);
            }
            else { tree1.Top += speed; }


            if (tree2.Top >= 500)
            {
                x = rand.Next(0, 350);

                tree2.Location = new Point(x, 0);
            }
            else { tree2.Top += speed; }


            if (tree3.Top >= 500)
            {
                x = rand.Next(0, 350);

                tree3.Location = new Point(x, 0);
            }
            else { tree3.Top += speed; }

        }














        private void cash_label_Click(object sender, EventArgs e)
        {

        }

       
    }
}
