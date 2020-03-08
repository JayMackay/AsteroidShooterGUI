using System;
using System.Collections.Generic;
using System.Linq;
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
            backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Background.png"));
            backgroundImage.TileMode = TileMode.Tile;
            backgroundImage.Viewport = new Rect(0, 0, 0.15, 0.15);
            backgroundImage.ViewportUnits = BrushMappingMode.RelativeToBoundingBox;
            MyCanvas.Background = backgroundImage;


            //Initialize The Player Sprite 
            ImageBrush playerImage = new ImageBrush();
            playerImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/Player.png"));
            player.Fill = playerImage;
        }

        //APPLICATION DRAG MOVE METHOD
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        //PLAYER KEY INPUT MOVEMENT
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            //Set Left Or Right Movement Bool On Key Down Input
            if(e.Key == Key.Left)
            {
                moveLeft = true;
            }
            if(e.Key == Key.Right)
            {
                moveRight = true;
            }

        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            //Revert Left Or Right Movement Bool On Key Up Input
            if(e.Key == Key.Left)
            {
                moveLeft = false;
            }
            if(e.Key == Key.Right)
            {
                moveRight = false;
            }

            //SET BULLET OBJECT ON SPACE KEY INPUT
            if(e.Key == Key.Space)
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

        //INITIALIZE ENEMY OBJECTS
        private void makeEnemies()
        {
            //New Enemy Sprite Brush
            ImageBrush enemySprite = new ImageBrush();

            //Generate A Random Number Inside The Enemy Sprite Counter
            enemySpriteCounter = rand.Next(1, 5);

            //Switch Statement To Assign Enemy Sprite In relation To Enemy Sprite Counter
            switch(enemySpriteCounter)
            {
                case 1:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/1.png"));
                    break;
                case 2:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/2.png"));
                    break;
                case 3:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/3.png"));
                    break;
                case 4:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/4.png"));
                    break;
                case 5:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Game Assets/5.png"));
                    break;
                default:
                    enemySprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Game Assets/1.png"));
                    break;
            }

            //Initialize Enemy Object & Set Sprite Image
            Rectangle newEnemy = new Rectangle
            {
                Tag = "enemy",
                Height = 50,
                Width = 56,
                Fill = enemySprite
            };

            //Generate Enemy Object Within The Canvas
            Canvas.SetTop(newEnemy, -100);
            Canvas.SetLeft(newEnemy, rand.Next(30, 430));
            MyCanvas.Children.Add(newEnemy);

            //Garbage Collection, Collect Any Unused Resources
            GC.Collect();
        }


        //GAME LOGIC 
        private void gameEngine(object sender, EventArgs e)
        {
            //Link Player Hit Box To Player Object
            playerHitBox = new Rect(Canvas.GetLeft(player), Canvas.GetTop(player), player.Width, player.Height);

            //Score & Damage Display
            scoreText.Content = "Score: " + score;
            damageText.Content = "Damaged " + damage;

            //Reduce Enemy Counter To Set Spawn Loop
            enemyCounter--;

            //Generate Enemies Method
            if(enemyCounter < 0)
            {
                makeEnemies();
                enemyCounter = limit;
            }

            //Player Movement Method
            if(moveLeft && Canvas.GetLeft(player) > 0)
            {
                //If Move Left Is True & Player Is Within The Canvas Boundary Then Move Left
                Canvas.SetLeft(player, Canvas.GetLeft(player) - playerSpeed);
            }
            if(moveRight && Canvas.GetLeft(player) + 90 < Application.Current.MainWindow.Width)
            {
                //If Move Right Is True & Player "Left Position + 90" Is Less Than The Canvas Then Move Right
                Canvas.SetLeft(player, Canvas.GetLeft(player) + playerSpeed);
            }


            //BULLET & ENEMY LOGIC MAIN LOOP
            foreach(var x in MyCanvas.Children.OfType<Rectangle>())
            {
                //If a rectangle has the tag "bullet"
                if(x is Rectangle && (string)x.Tag == "bullet")
                {
                    //Move the bullet object towards top of the screen
                    Canvas.SetTop(x, Canvas.GetTop(x) - 20);

                    //Initialize a new "Rect" class with the bullet properties
                    Rect bullet = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    //If bullet has reached the top of the screen add to the remove list for garbage collection
                    if(Canvas.GetTop(x) < 10)
                    {
                        removeItems.Add(x);
                    }

                    //ENEMY INITIALIZATION LOOP
                    foreach (var y in MyCanvas.Children.OfType<Rectangle>())
                    {
                        //If a rectangle has the tag "enemy"
                        if (y is Rectangle && (string)y.Tag == "enemy")
                        {
                            //Initialize a new "Rect" class with the enemies properties
                            Rect enemy = new Rect(Canvas.GetLeft(y), Canvas.GetTop(y), y.Width, y.Height);

                            //ENEMY & BULLET COLLISION CHECK
                            if (bullet.IntersectsWith(enemy))
                            {
                                removeItems.Add(x); 
                                removeItems.Add(y);
                                score++;
                            }
                        }

                    }
                }

                //ENEMY MOVEMENT LOGIC
                if (x is Rectangle && (string)x.Tag == "enemy")
                {
                    //Enemy Movement
                    Canvas.SetTop(x, Canvas.GetTop(x) + 10);

                    //Enemy hit box initializion
                    Rect enemy = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    //Enemy position check
                    if (Canvas.GetTop(x) + 150 > 700)
                    {
                        //If enemy position is past the player position add 10 to the damage counter
                        removeItems.Add(x);
                        damage += 10;
                    }

                    //If the player and enemy hit box are colliding add 5 to the damage counter
                    if (playerHitBox.IntersectsWith(enemy))
                    {
                        damage += 5;
                        removeItems.Add(x);
                    }
                }


            }

            //GAME SCORE LOGIC
            //Reduce enemy spawn limiter so enemies will spawn faster
            if (score > 5)
            {
                limit = 20; 
            }

            //GAME LOOP STOPPER
            if (damage > 99)
            {
                gameTimer.Stop();
                damageText.Content = "Damaged: 100";
                damageText.Foreground = Brushes.Red;
                //Pop up message box
                MessageBox.Show("Well Done!" + Environment.NewLine + "You have destroyed " + score + " Alien ships");
            }

            //OBJECT REMOVE
            foreach (Rectangle y in removeItems)
            {
                MyCanvas.Children.Remove(y);
            }

        }

    }
}
