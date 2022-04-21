using ElementalFight.Entites;
using ElementalFight.Models;


namespace ElementalFight
{
    public partial class Form1 : Form
    {
        public Image groundMonk;
        public Entity player;


        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 20;
            timer1.Tick += new EventHandler(Update);
            KeyDown += new KeyEventHandler(OnPress);
            KeyUp +=new KeyEventHandler(OnKeyUp);
            
            Init();
        }

        public void OnKeyUp(object sender,KeyEventArgs e)
        {
            player.IsMoving = false;
        }

        public void OnPress(object sender, KeyEventArgs e )
        {
            switch(e.KeyCode)
            {               
                case Keys.A:
                    player.Move(-2, 0);
                    break;
                case Keys.D:
                    player.Move(2, 0);
                    break;
            }
            player.IsMoving = true;
        }
        
        public void Update(object sender, EventArgs e)
        {
            
            Invalidate();
        }

        public void Init()
        {   

            DoubleBuffered = true;
            var groundMonk = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\groundMonk"));
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += (s, e) => { Invalidate(); };
            timer.Start();
            player = new Entity(100, 100, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, groundMonk);
            Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.DrawImage(player.spriteSheet, new Rectangle(new Point(player.posX, player.posY), new Size(150, 200)), 0, 0, player.size, player.size, GraphicsUnit.Pixel);
            };

            Invalidate();
        }
        private void OnPaint(object sendere, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            player.PlayAnimation(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}