using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skidaddle_or_get_skadaddled
{
    public partial class Form1 : Form
    {
        int sceneOneChance;
        int sceneNineChance;
        int sceneBlankChance;
        int scene;
        int state = 0;
        public Form1()
        {
            InitializeComponent();
            Random randGen = new Random();
            outputLabel.Text = "you wake up one morning in and you cell door is wide open";
            redLabel.Text = "do you leave?";
            blueLabel.Text = "do you stay?";
            button1.Visible = false;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Random randGen = new Random();
            if (e.KeyCode == Keys.M) // red button
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    sceneOneChance = randGen.Next(1, 101);
                     if (sceneOneChance > 70)
                    {
                        scene = 5;
                    }
                    else
                    {
                        scene = 4;
                    }
                    
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    sceneOneChance = randGen.Next(1, 101);
                    if (sceneOneChance > 90)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 19;
                    } 
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 16;
                }
                else if (scene == 9)
                {
                    scene = 12;
                }
                else if (scene == 17)
                {
                    scene = 24;
                }
                else if (scene == 13)
                {
                    scene = 21;
                }
                else if (scene == 1)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 0;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 16)
                {
                    scene = 0;
                }
                else if (scene == 22)
                {
                    scene = 0;
                }
                else if (scene == 19)
                {
                    scene = 0;
                }
            }


            else if (e.KeyCode == Keys.B)  //blue button press
            {
               if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    sceneOneChance = randGen.Next(1, 101);
                    if (sceneOneChance > 85)
                    {
                        scene = 15;
                    }
                    else
                    {
                        scene = 14;
                    }
                }
                else if (scene == 13)
                {
                    scene = 22;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 11;
                }
                else if (scene == 10)
                {
                    scene = 18;
                }
                else if (scene == 8)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 23;
                }
            }
               
            
            else if (e.KeyCode == Keys.Space)// green button
            {
                if (scene == 9)
                {
                    scene = 13;
                }
            }
                
            
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                // start scene
                case 0:
                    outputLabel.Text = "you wake up one morning in and you cell door is wide open";
                    redLabel.Text = "do you leave?";
                    blueLabel.Text = "do you stay?";
                    break;
                case 1:
                    outputLabel.Text = "if you stay you will have to stay in prison and you get stabbed two months later.";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "you leave you cell and walk down you hallway and when you reach the end you see a gaurd.";
                    redLabel.Text = "do you kill him?";
                    blueLabel.Text = "do you try to hide?";
                    greenLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "You hide the guard finds you and beats you to death and no one ask any questions";
                    redLabel.Text = "You lose press M to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = " You kill the gaurd and come to another decision.";
                    redLabel.Text = "Do you steal his uniform and all his gear?";
                    blueLabel.Text = "Do you steal just his weapons?";
                    greenLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "You get turned on by the guard and he beats you to death without asking any questions.";
                    redLabel.Text = "You lose press M to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "You just take all his gear and then you come to a end of the hall do you turn";

                    redLabel.Text = "Left?";
                    blueLabel.Text = "Right?";
                    greenLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You just take get one grenade and his baton.you then start to make you way down a new hall way ";
                    redLabel.Text = "Do you turn left?";
                    blueLabel.Text = " Do you turn right?";
                    greenLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You find a single gaurd";
                    redLabel.Text = "do you beat him?";
                    blueLabel.Text = "do you taser him?";
                    greenLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "you find 5 gaurds walking towards you";
                    redLabel.Text = "?";
                    blueLabel.Text = "?";
                    greenLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "you find a guard";
                    redLabel.Text = " do you disguise yourself as a gaurd?";
                    blueLabel.Text = "do you run and drop kick him?";
                    greenLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "you find 5 guards and get knocked out and put back in your cell they realized it was you";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "you try to fight them you get knocked out and sent back to your cell";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "you run away and hide under a stair case ";
                    redLabel.Text = "do you stealth kill the gaurds?";
                    blueLabel.Text = "do you try to wait out the gaurds so they will leave?";
                    greenLabel.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "you kill all the guards and walk out of the front doors safely";
                    redLabel.Text = "?";
                    blueLabel.Text = "?";
                    greenLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "you for get to throw the grenade and get blown up all over the room and the gaurd have a  big mess to clean up";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 16:
                    outputLabel.Text = " you try to beat him he turns on you and you get beat to death";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "you taser him you get him on the ground but he hits a button for back up";
                    redLabel.Text = "do you make a break for it out the door?";
                    blueLabel.Text = "do you steal the gaurd outfit and walk out the door?";
                    greenLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "you drop kick the guard and knock him unconscious. then you walk out the door and escape";
                    redLabel.Text = "?";
                    blueLabel.Text = "?";
                    greenLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "you get caught and he takes you back to your cell";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "?";
                    greenLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "you escape the prison successfully through the back door";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "you a make an awesome escape";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 22:
                    outputLabel.Text = "you wait and you starve to death";
                    redLabel.Text = "You lose press M to restart";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "You walk out the with ear the tower thinks you are a guard looking for the escaping prisoner and you get free";
                    redLabel.Text = "press any m to end?";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 24:
                    outputLabel.Text = "if you make a break for it the guard tower in on alert and they snipe you before you can escape";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "?";
                    greenLabel.Text = "";
                    break;
                case 25:
                    outputLabel.Text = "you win congratulations ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    button1.Visible = true;
                    break;
               



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scene = 0;
            sceneOneChance = 0;
            sceneNineChance = 0;
            sceneBlankChance = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            scene = 0;
            sceneOneChance = 0;
            sceneNineChance = 0;
            sceneBlankChance = 0;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            scene = 0;
            sceneOneChance = 0;
            sceneNineChance = 0;
            sceneBlankChance = 0;
        }
    }
}
