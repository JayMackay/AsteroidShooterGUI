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
        List<Rectangle> itemstoremove = new List<Rectangle>();

        //Random Class Generator
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
        }

        //APPLICATION DRAG MOVE METHOD
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {

        }

        private void makeEnemies()
        {

        }

        private void gameEngine()
        {

        }
    }
}
