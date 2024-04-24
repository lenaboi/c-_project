using System;
using System.Drawing;
using System.Media;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace csharp_skiing_game
{
    public partial class Box : Form
    {
        int gamespeed1 = 1;

        int score1 = 0;
        int distancetravelled = 0;

        Point[] originalskierLocations;
        Point[] originalCashLocations;
        Point[] originalEnemyLocations;

        public Box()
        {
            InitializeComponent();
            this.KeyDown += Box_KeyDown;
            gameover.Visible = false;
            play_again.Visible = false;

           
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            InitializeOriginalLocations();

        }

        private void InitializeOriginalLocations()
        {
            originalskierLocations = new Point[] { skier.Location };
            originalCashLocations = new Point[] { cash1.Location, cash2.Location, cash3.Location };
            originalEnemyLocations = new Point[] { rock.Location, tree1.Location, tree2.Location, tree3.Location };


        }

        private void resetLocations()
        {
            // Reset skier location
            skier.Location = originalskierLocations[0];

            // Reset enemy locations
            for (int i = 0; i < originalEnemyLocations.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        rock.Location = originalEnemyLocations[i];
                        break;
                    case 1:
                        tree1.Location = originalEnemyLocations[i];
                        break;
                    case 2:
                        tree2.Location = originalEnemyLocations[i];
                        break;
                    case 3:
                        tree3.Location = originalEnemyLocations[i];
                        break;
                }
            }

            // Reset cash locations
            for (int j = 0; j < originalCashLocations.Length; j++)
            {
                switch (j)
                {
                    case 0:
                        cash1.Location = originalCashLocations[j];
                        break;
                    case 1:
                        cash2.Location = originalCashLocations[j];
                        break;
                    case 2:
                        cash3.Location = originalCashLocations[j];
                        break;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy(gamespeed1);
            gameover1();
            cashh(gamespeed1);
            cashcollection();
            playagain();


            score1 = distancetravelled / 20;
            score_label.Text = "Score: " + score1;



            distancetravelled += gamespeed1;
            if (distancetravelled % 650 == 0)
            {
                if (gamespeed1 < 6)
                    gamespeed1++;
            }


        }
        int collectedcash;
        int x, y;
        Random rand = new Random();

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

        void cashh(int speed)
        {
            if (cash1.Top >= 500)
            {
                x = rand.Next(0, 350);
                cash1.Location = new Point(x, 0);
            }
            else { cash1.Top += speed; }

            if (cash2.Top >= 500)
            {
                x = rand.Next(0, 350);
                cash2.Location = new Point(x, 0);
            }
            else { cash2.Top += speed; }

            if (cash3.Top >= 500)
            {
                x = rand.Next(0, 350);
                cash3.Location = new Point(x, 0);
            }
            else { cash3.Top += speed; }
        }
        void gameover1()
        {
            if (skier.Bounds.IntersectsWith(rock.Bounds) ||
                skier.Bounds.IntersectsWith(tree1.Bounds) ||
                skier.Bounds.IntersectsWith(tree2.Bounds) ||
                skier.Bounds.IntersectsWith(tree3.Bounds))

            {
                timer1.Enabled = false;
                gameover.Visible = true;
               
            }

        }
        void playagain()
        {
            if (skier.Bounds.IntersectsWith(rock.Bounds) ||
                skier.Bounds.IntersectsWith(tree1.Bounds) ||
                skier.Bounds.IntersectsWith(tree2.Bounds) ||
                skier.Bounds.IntersectsWith(tree3.Bounds))

            {
                timer1.Enabled = false;
                play_again.Visible = true;

            }

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
        void cashcollection()
        {

            if (skier.Bounds.IntersectsWith(cash1.Bounds))
            {
                collectedcash++;
                cash_label.Text = "Cash=" + collectedcash.ToString();
                x = rand.Next(50, 300);

                cash1.Location = new Point(x, 0);

                playSound("raha_wav.wav");

            }

            if (skier.Bounds.IntersectsWith(cash2.Bounds))
            {
                collectedcash += 2;
                cash_label.Text = "Cash=" + collectedcash.ToString();
                x = rand.Next(50, 300);

                cash2.Location = new Point(x, 0);

                playSound("raha_wav.wav");
            }

            if (skier.Bounds.IntersectsWith(cash3.Bounds))
            {
                collectedcash += 4;
                cash_label.Text = "Cash=" + collectedcash.ToString();
                x = rand.Next(50, 300);

                cash3.Location = new Point(x, 0);

                playSound("mario.wav");
            }
        }

        private void playSound(string file_name)
        {
            string assemblyDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            DirectoryInfo currentDirectory = new DirectoryInfo(assemblyDirectory);
            while (currentDirectory != null)
            {
                string resourcesDirectory = Path.Combine(currentDirectory.FullName, "Resources");
                if (Directory.Exists(resourcesDirectory))
                {
                    string soundFilePath = Path.Combine(resourcesDirectory, file_name);

                    if (File.Exists(soundFilePath))
                    {
                        using (SoundPlayer player = new SoundPlayer(soundFilePath))
                        {
                            player.Play();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sound file not found.");
                    }

                    break;
                }

                currentDirectory = currentDirectory.Parent;
            }
        }
        private void play_again_Click_1(object sender, EventArgs e)
        {
            distancetravelled = 0;
            collectedcash = 0;
            cash_label.Text = "Cash = 0";
            gamespeed1 = 2;
            gameover.Visible = false;
            play_again.Visible = false;
            timer1.Enabled = true;


            resetLocations();

            this.Focus();
        }
    }




}
