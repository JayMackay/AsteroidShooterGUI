using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AsteroidShooterGUI
{
    public partial class AsteroidShooter : Window
    {
        //Game Time
        DispatcherTimer gameTimer = new DispatcherTimer();

        //Movement
        bool moveLeft, moveRight;

        //Item Remove List
        //This will be used to remove assets that are no longer needed in the main window
        //for example destroyed ships, player bullets etc.
        List<Rectangle> removeItems = new List<Rectangle>();

        //Random Class Generator
        //This will be used to position random enemies in the game to spawn
        Random rand = new Random();


        int enemySpriteCounter; //Change Enemy Images
        int enemyCounter = 100; //Enemy Spawn Time
        int playerSpeed = 10; //Player Movement Speed
        int limit = 50; //Enemy Spawn Limiter
        int score = 0; //Default Score
        int damage = 0; //Default Player Damage

        //Player Hitbox
        Rect playerHitBox;

        //MAIN WINDOW INITIALIZE
        public AsteroidShooter()
        {
            InitializeComponent();

            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            //Link The Game Engine To The Game Timer & Start
            gameTimer.Tick += gameEngine;
            gameTimer.Start();
            MyCanvas.Focus();

            //Initialize The Main Window Canvas Background Using An Image
            ImageBrush backgroundImage = new ImageBrush();
            backgroundImage.ImageSource = new BitmapImage(new Uri("/Game Assets/Background.png"));
            backgroundImage.TileMode = TileMode.Tile;
            backgroundImage.Viewport = new Rect(0, 0, 0.15, 0.15);
            backgroundImage.ViewportUnits = BrushMappingMode.RelativeToBoundingBox;
            MyCanvas.Background = backgroundImage;


            //Initialize The Player Sprite 
            ImageBrush playerImage = new ImageBrush();
            playerImage.ImageSource = new BitmapImage(new Uri("/Game Assets/Player.png"));
            player.Fill = playerImage;
        }

        //APPLICATION DRAG MOVE METHOD
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        //PLAYER KEY INPUT MOVEMENT
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            //Set Left Or Right Movement Bool On Key Down Input
            if (e.Key == Key.Left)
            {
                moveLeft = true;
            }
            if (e.Key == Key.Right)
            {
                moveRight = true;
            }

        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            //Revert Left Or Right Movement Bool On Key Up Input
            if (e.Key == Key.Left)
            {
                moveLeft = false;
            }
            if (e.Key == Key.Right)
            {
                moveRight = false;
            }

            //SET BULLET OBJECT ON SPACE KEY INPUT
            if (e.Key == Key.Space)
            {
                Rectangle newBullet = new Rectangle
                {
                    Tag = "bullet",
                    Height = 20,
                    Width = 5,
                    Fill = Brushes.White,
                    Stroke = Brushes.Red
                };

                //Set Bullet Location On Player Object
                Canvas.SetTop(newBullet, Canvas.GetTop(player) - newBullet.Height);
                Canvas.SetLeft(newBullet, Canvas.GetLeft(player) + player.Width / 2);

                //Initialize TThe Bullets On The Canvas
                MyCanvas.Children.Add(newBullet);
            }
        }

        private void makeEnemies()
        {

        }

        private void gameEngine()
        {

        }
    }
}
