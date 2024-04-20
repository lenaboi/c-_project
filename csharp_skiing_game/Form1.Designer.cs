namespace csharp_skiing_game
{
    partial class Box
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Box));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            skier = new PictureBox();
            tree1 = new PictureBox();
            cash2 = new PictureBox();
            cash1 = new PictureBox();
            rock = new PictureBox();
            cash3 = new PictureBox();
            tree2 = new PictureBox();
            tree3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            gameover = new PictureBox();
            cash_label = new Label();
            score_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cash2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cash1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cash3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameover).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(374, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(13, 522);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Location = new Point(-5, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(13, 522);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // skier
            // 
            skier.Image = (Image)resources.GetObject("skier.Image");
            skier.Location = new Point(182, 432);
            skier.Name = "skier";
            skier.Size = new Size(34, 47);
            skier.SizeMode = PictureBoxSizeMode.StretchImage;
            skier.TabIndex = 2;
            skier.TabStop = false;
            // 
            // tree1
            // 
            tree1.Image = (Image)resources.GetObject("tree1.Image");
            tree1.Location = new Point(322, 200);
            tree1.Name = "tree1";
            tree1.Size = new Size(34, 47);
            tree1.SizeMode = PictureBoxSizeMode.StretchImage;
            tree1.TabIndex = 3;
            tree1.TabStop = false;
            // 
            // cash2
            // 
            cash2.Image = (Image)resources.GetObject("cash2.Image");
            cash2.Location = new Point(108, 101);
            cash2.Name = "cash2";
            cash2.Size = new Size(42, 32);
            cash2.SizeMode = PictureBoxSizeMode.StretchImage;
            cash2.TabIndex = 4;
            cash2.TabStop = false;
            // 
            // cash1
            // 
            cash1.Image = (Image)resources.GetObject("cash1.Image");
            cash1.Location = new Point(63, 313);
            cash1.Name = "cash1";
            cash1.Size = new Size(35, 25);
            cash1.SizeMode = PictureBoxSizeMode.StretchImage;
            cash1.TabIndex = 5;
            cash1.TabStop = false;
            // 
            // rock
            // 
            rock.Image = (Image)resources.GetObject("rock.Image");
            rock.Location = new Point(144, 229);
            rock.Name = "rock";
            rock.Size = new Size(34, 47);
            rock.SizeMode = PictureBoxSizeMode.StretchImage;
            rock.TabIndex = 6;
            rock.TabStop = false;
            // 
            // cash3
            // 
            cash3.Image = (Image)resources.GetObject("cash3.Image");
            cash3.Location = new Point(216, 12);
            cash3.Name = "cash3";
            cash3.Size = new Size(32, 38);
            cash3.SizeMode = PictureBoxSizeMode.StretchImage;
            cash3.TabIndex = 7;
            cash3.TabStop = false;
            // 
            // tree2
            // 
            tree2.Image = (Image)resources.GetObject("tree2.Image");
            tree2.Location = new Point(18, 113);
            tree2.Name = "tree2";
            tree2.Size = new Size(34, 47);
            tree2.SizeMode = PictureBoxSizeMode.StretchImage;
            tree2.TabIndex = 8;
            tree2.TabStop = false;
            // 
            // tree3
            // 
            tree3.Image = (Image)resources.GetObject("tree3.Image");
            tree3.Location = new Point(255, 101);
            tree3.Name = "tree3";
            tree3.Size = new Size(34, 47);
            tree3.SizeMode = PictureBoxSizeMode.StretchImage;
            tree3.TabIndex = 9;
            tree3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // gameover
            // 
            gameover.Image = (Image)resources.GetObject("gameover.Image");
            gameover.Location = new Point(-1, 0);
            gameover.Name = "gameover";
            gameover.Size = new Size(388, 127);
            gameover.SizeMode = PictureBoxSizeMode.StretchImage;
            gameover.TabIndex = 10;
            gameover.TabStop = false;
            // 
            // cash_label
            // 
            cash_label.AutoSize = true;
            cash_label.BackColor = Color.Transparent;
            cash_label.Location = new Point(15, 9);
            cash_label.Name = "cash_label";
            cash_label.Size = new Size(45, 15);
            cash_label.TabIndex = 11;
            cash_label.Text = "Cash: 0";
            // 
            // score_label
            // 
            score_label.AutoSize = true;
            score_label.Location = new Point(15, 35);
            score_label.Name = "score_label";
            score_label.Size = new Size(48, 15);
            score_label.TabIndex = 12;
            score_label.Text = "Score: 0";
            // 
            // Box
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(384, 521);
            Controls.Add(score_label);
            Controls.Add(cash_label);
            Controls.Add(gameover);
            Controls.Add(tree3);
            Controls.Add(tree2);
            Controls.Add(cash3);
            Controls.Add(rock);
            Controls.Add(cash1);
            Controls.Add(cash2);
            Controls.Add(tree1);
            Controls.Add(skier);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Box";
            Text = "Skiing Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)skier).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cash2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cash1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rock).EndInit();
            ((System.ComponentModel.ISupportInitialize)cash3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox skier;
        private PictureBox tree1;
        private PictureBox cash2;
        private PictureBox cash1;
        private PictureBox rock;
        private PictureBox cash3;
        private PictureBox tree2;
        private PictureBox tree3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox gameover;
        private Label cash_label;
        private Label score_label;
    }
}
