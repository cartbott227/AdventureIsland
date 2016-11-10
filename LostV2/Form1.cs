/// Program created by Carter Bott
/// on Nov 8th, 2016. 
/// Description: A basic text adventure.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostV2
{
    public partial class Form1 : Form
    {
        int scene = 0;  // tracks what part of the game the user is at

        Random randGen = new Random();

        SoundPlayer boooPlayer = new SoundPlayer(Properties.Resources.boooo);           //Creates players for different sound effects
        SoundPlayer applausePlayer = new SoundPlayer(Properties.Resources.applause);
        SoundPlayer oceanPlayer = new SoundPlayer(Properties.Resources.beach);

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You awake on a deserted beach, to your south is the ocean and to the north is a forest. Where do you want to go?";
            redLabel.Text = "North";
            blueLabel.Text = "South";
            oceanPlayer.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 7)
                {
                    scene = 0;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 50)
                    {
                        scene = 3;
                    }
                    else
                    {
                        scene = 2;
                    }
                }
                else if (scene == 1)
                {
                    scene = 5;
                }
                else if (scene == 2)
                {
                    scene = 11;
                }
                else if (scene == 3)
                {
                    scene = 10;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }

                else if (scene == 7)
                {
                    scene = 10;
                }
                else if (scene == 8)
                {
                    scene = 6;
                }
                else if (scene == 4)
                {
                    scene = 11;
                }
                else if (scene == 9)
                {
                    scene = 11;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
            }
            else if (e.KeyCode == Keys.C) //green button press
            {
                if (scene == 0)
                {
                    scene = 10;
                }
            }

                /// Display text and game options to screen based on the current scene
                switch (scene)
            {
                case 0:  //start scene
                    outputLabel.Text = "You awake on a deserted beach, to your south is the ocean and to the north is a forest. Where do you want to go?";
                    redLabel.Text = "North";
                    blueLabel.Text = "South";
                    greenLabel.Text = "Go back to sleep.";             
                    oceanPlayer.Play();
                    this.BackgroundImage = (Properties.Resources.island); //Changes backround to match scenes
                    break;
                case 1:
                    outputLabel.Text = "You trek through the forest and come to a tribe of natives. Do you ask them for help or continue on your way?";
                    redLabel.Text = "Ask for help.";
                    blueLabel.Text = "Continue on your way.";
                    greenLabel.Text = "";
                    this.BackgroundImage = (Properties.Resources.forestpixel);
                    break;
                case 2:
                    outputLabel.Text = "You wrangle the shark and ride it to safety. You win! Play again?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";
                    applausePlayer.Play();
                    this.BackgroundImage = (Properties.Resources.island);
                    break;
                case 3:
                    outputLabel.Text = "You were eaten by a shark. Play again?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";                   
                    boooPlayer.Play();
                    this.BackgroundImage = (Properties.Resources.island);
                    break;
                case 4:
                    outputLabel.Text = "You are speared by the natives and eaten. Play again?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";
                    boooPlayer.Play();
                    this.BackgroundImage = (Properties.Resources.forestpixel);
                    break;
                case 5:
                    outputLabel.Text = "You continue on your way and stumble upon a paddle boat with a hole in the side of it. There is a roll of duck tape and a blanket. What do you use to cover the hole?";
                    redLabel.Text = "Duck tape?";
                    blueLabel.Text = "Blanket?";
                    greenLabel.Text = "";
                    this.BackgroundImage = (Properties.Resources.island);
                    break;
                case 6:
                    outputLabel.Text = "You continue on your way and are rescued by the coast guard. You Win! Play again?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";
                    applausePlayer.Play();
                    this.BackgroundImage = (Properties.Resources.water);
                    break;
                case 7:
                    outputLabel.Text = "You venture into the ocean in the paddle boat. Water seeps through the blanket and you sink. Play again?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";
                    this.BackgroundImage = (Properties.Resources.water);
                    break;
                case 8:
                    outputLabel.Text = "You venture into the ocean and see a boat in the distance. Do you signal for help?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";
                    this.BackgroundImage = (Properties.Resources.water);
                    break;
                case 9:
                    outputLabel.Text = "The boat is a pirate ship and you are kidnapped and forced to be a pirate. Play again?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";
                    boooPlayer.Play();
                    this.BackgroundImage = (Properties.Resources.water);
                    break;
                case 10:
                    outputLabel.Text = "You fall asleep and are eaten by crabs. Play again?";
                    redLabel.Text = "Yes.";
                    blueLabel.Text = "No.";
                    greenLabel.Text = "";
                    boooPlayer.Play();
                    this.BackgroundImage = (Properties.Resources.island);
                    break;
                case 11:
                    Refresh();
                    outputLabel.Text = "Thanks for playing!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    this.BackgroundImage = (Properties.Resources.island);
                    Thread.Sleep(3000);
                    this.Close();       //Waits for 3 seconds then ends the program. 
                    break;
                default:
                    break;
            }
        }
    }
}

