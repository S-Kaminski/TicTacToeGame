using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToeWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Player1Points { get; set; }
        public int Player2Points { get; set; }
        public int Round { get; set; }
        public int Turn { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            changeColorToLGray();
            Player1Points = 0;
            Player2Points = 0;
        }

        private void changeColorToLGray()
        {
            topLeft.Background = Brushes.LightGray;
            topCenter.Background = Brushes.LightGray;
            topRight.Background = Brushes.LightGray;
            middleLeft.Background = Brushes.LightGray;
            middleCenter.Background = Brushes.LightGray;
            middleRight.Background = Brushes.LightGray;
            botLeft.Background = Brushes.LightGray;
            botCenter.Background = Brushes.LightGray;
            botRight.Background = Brushes.LightGray;
        }
        private void EnableButtons()
        {
            topLeft.IsEnabled = true;
            topCenter.IsEnabled = true;
            topRight.IsEnabled = true;
            middleLeft.IsEnabled = true;
            middleCenter.IsEnabled = true;
            middleRight.IsEnabled = true;
            botLeft.IsEnabled = true;
            botCenter.IsEnabled = true;
            botRight.IsEnabled = true;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Button clickedButton = (Button)sender;
            
            if (clickedButton.Content.ToString() == "")
            {
                if (Turn % 2 == 0)
                {
                    TurnLabel.Content = "PLAYER2'S TURN";
                    clickedButton.Content = "O";
                    if ((string)topLeft.Content == "O" && (string)topCenter.Content == "O" && (string)topRight.Content == "O")
                    {
                        topLeft.Background = Brushes.LightGreen;
                        topCenter.Background = Brushes.LightGreen;
                        topRight.Background = Brushes.LightGreen;

                        middleLeft.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;

                        Player1Points += 1;

                        UpdateView();
                    }
                    if ((string)middleLeft.Content == "O" && (string)middleCenter.Content == "O" && (string)middleRight.Content == "O")
                    {
                        middleLeft.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        middleRight.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;

                        Player1Points += 1;

                        UpdateView();
                    }
                    if ((string)botLeft.Content == "O" && (string)botCenter.Content == "O" && (string)botRight.Content == "O")
                    {
                        botLeft.Background = Brushes.LightGreen;
                        botCenter.Background = Brushes.LightGreen;
                        botRight.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        Player1Points += 1;

                        UpdateView();
                    }
                    if ((string)topLeft.Content == "O" && (string)middleLeft.Content == "O" && (string)botLeft.Content == "O")
                    {
                        topLeft.Background = Brushes.LightGreen;
                        middleLeft.Background = Brushes.LightGreen;
                        botLeft.Background = Brushes.LightGreen;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;

                        Player1Points += 1;

                        UpdateView();
                    }
                    if ((string)topCenter.Content == "O" && (string)middleCenter.Content == "O" && (string)botCenter.Content == "O")
                    {
                        topCenter.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        botCenter.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botRight.IsEnabled = false;
                        Player1Points += 1;

                        UpdateView();
                    }
                    if ((string)topRight.Content == "O" && (string)middleRight.Content == "O" && (string)botRight.Content == "O")
                    {
                        topRight.Background = Brushes.LightGreen;
                        middleRight.Background = Brushes.LightGreen;
                        botRight.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        Player1Points += 1;

                        UpdateView();
                    }
                    if ((string)topLeft.Content == "O" && (string)middleCenter.Content == "O" && (string)botRight.Content == "O")
                    {
                        topLeft.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        botRight.Background = Brushes.LightGreen;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;

                        Player1Points += 1;

                        UpdateView();
                    }
                    if ((string)topRight.Content == "O" && (string)middleCenter.Content == "O" && (string)botLeft.Content == "O")
                    {
                        topRight.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        botLeft.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;
                        Player1Points += 1;

                        UpdateView();
                    }

                }
                else
                {
                    TurnLabel.Content = "PLAYER1'S TURN";
                    clickedButton.Content = "X";
                    if ((string)topLeft.Content == "X" && (string)topCenter.Content == "X" && (string)topRight.Content == "X")
                    {
                        topLeft.Background = Brushes.LightGreen;
                        topCenter.Background = Brushes.LightGreen;
                        topRight.Background = Brushes.LightGreen;
                        middleLeft.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }
                    if ((string)middleLeft.Content == "X" && (string)middleCenter.Content == "X" && (string)middleRight.Content == "X")
                    {
                        middleLeft.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        middleRight.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }
                    if ((string)botLeft.Content == "X" && (string)botCenter.Content == "X" && (string)botRight.Content == "X")
                    {
                        botLeft.Background = Brushes.LightGreen;
                        botCenter.Background = Brushes.LightGreen;
                        botRight.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }
                    if ((string)topLeft.Content == "X" && (string)middleLeft.Content == "X" && (string)botLeft.Content == "X")
                    {
                        topLeft.Background = Brushes.LightGreen;
                        middleLeft.Background = Brushes.LightGreen;
                        botLeft.Background = Brushes.LightGreen;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }
                    if ((string)topCenter.Content == "X" && (string)middleCenter.Content == "X" && (string)botCenter.Content == "X")
                    {
                        topCenter.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        botCenter.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botRight.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }
                    if ((string)topRight.Content == "X" && (string)middleRight.Content == "X" && (string)botRight.Content == "X")
                    {
                        topRight.Background = Brushes.LightGreen;
                        middleRight.Background = Brushes.LightGreen;
                        botRight.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleCenter.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }
                    if ((string)topLeft.Content == "X" && (string)middleCenter.Content == "X" && (string)botRight.Content == "X")
                    {
                        topLeft.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        botRight.Background = Brushes.LightGreen;
                        topCenter.IsEnabled = false;
                        topRight.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botLeft.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }
                    if ((string)topRight.Content == "X" && (string)middleCenter.Content == "X" && (string)botLeft.Content == "X")
                    {
                        topRight.Background = Brushes.LightGreen;
                        middleCenter.Background = Brushes.LightGreen;
                        botLeft.Background = Brushes.LightGreen;
                        topLeft.IsEnabled = false;
                        topCenter.IsEnabled = false;
                        middleLeft.IsEnabled = false;
                        middleRight.IsEnabled = false;
                        botCenter.IsEnabled = false;
                        botRight.IsEnabled = false;
                        Player2Points += 1;

                        UpdateView();
                    }

                }
                Turn++;
            }
            
            

        }

        private void InitGameStats()
        {
            Round = 1;
            Turn = 1;
        }

        private void UpdateView()
        {
            p1points.Content = Player1Points;
            p2points.Content = Player2Points;
        }

        private void NewGameButton_Click_1(object sender, RoutedEventArgs e)
        {
            topLeft.Content = "";
            topCenter.Content = "";
            topRight.Content = "";
            middleLeft.Content = "";
            middleCenter.Content = "";
            middleRight.Content = "";
            botLeft.Content = "";
            botCenter.Content = "";
            botRight.Content = "";

            changeColorToLGray();
            EnableButtons();
        }
        //private void startDraw() //decides who goes first in 1 round
        //{
        //    Random rnd = new Random();
        //    rnd.Next(0, 1);
        //    Round1_Commencer = rnd.Next(1, 10);
        //    MessageBox.Show(Round1_Commencer.ToString());


        //}

    }
}
