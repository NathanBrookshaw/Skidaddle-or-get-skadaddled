using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
            SoundPlayer player = new SoundPlayer(Properties.Resources.prisoncell);
            outputLabel.Text = "you wake up one morning and you cell door is wide open";
            redLabel.Text = "do you leave?";
            blueLabel.Text = "do you stay?";
            button1.Visible = false;
            BackgroundImage = Properties.Resources.open_door;
            greenLabel.Text = "";

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Random randGen = new Random();
            if (e.KeyCode == Keys.M) // red button press or m key
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
                else if (scene == 24)
                {
                    scene = 0;
                }
            }


            else if (e.KeyCode == Keys.B)  //blue button press or b key
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
                else if (scene == 13)
                {
                    scene = 21;
                }
                else if (scene == 1)
                {
                    scene = 26;
                }
                else if (scene == 3)
                {
                    scene = 26;
                }
                else if (scene == 5)
                {
                    scene = 26;
                }
                else if (scene == 11)
                {
                    scene = 26;
                }
                else if (scene == 17)
                {
                    scene = 26;
                }
                else if (scene == 19)
                {
                    scene = 26;
                }
                else if (scene == 22)
                {
                    scene = 26;
                }
                else if (scene == 24)
                {
                    scene = 26;
                }
                else if (scene == 14)
                {
                    scene = 26;
                }
                else if (scene == 18)
                {
                    scene = 26;
                }
                else if (scene == 20)
                {
                    scene = 26;
                }
                else if (scene == 23)
                {
                    scene = 26;
                }
                else if (scene == 15)
                {
                    scene = 26;
                }
            }
               
            
            else if (e.KeyCode == Keys.Space)// green button or press space bar
            {
                if (scene == 9)
                {
                    scene = 13;
                }
            }
                
            
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                // start scenes
                // playsound
                //change background
                case 0:
                    SoundPlayer player = new SoundPlayer(Properties.Resources.prisoncell);
                    BackgroundImage = Properties.Resources.open_door;
                    outputLabel.Text = "you wake up one morning and you cell door is wide open";
                    redLabel.Text = "do you leave?";
                    blueLabel.Text = "do you stay?";
                    break;
                case 1:
                    BackgroundImage = Properties.Resources.dead_body;
                    outputLabel.Text = "you get stabbed two weeks later and die.";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.oof);
                    break;
                case 2:
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.footsteps);
                    BackgroundImage = Properties.Resources.guard_end_hall; 
                    outputLabel.Text = "you leave your cell and walk down the hallway and when you reach the end you see a couple gaurds.";
                    redLabel.Text = "do you kill them?";
                    blueLabel.Text = "do you try to hide?";
                    greenLabel.Text = "";
                    break;
                case 3:
                    BackgroundImage = Properties.Resources.dead_body;
                    outputLabel.Text = "You hide and the guard finds you and beats you to death.";
                    redLabel.Text = "You lose press M to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.oof);
                    break;
                case 4:
                    BackgroundImage = Properties.Resources.guard_gear;
                    outputLabel.Text = " You kill the gaurd and come to another decision.";
                    redLabel.Text = "Do you steal his uniform and all his gear?";
                    blueLabel.Text = "Do you steal just his weapons?";
                    greenLabel.Text = "";
                    break;
                case 5:
                    BackgroundImage = Properties.Resources.dead_body;
                    outputLabel.Text = "the guards turn on you and they beats you to death.";
                    redLabel.Text = "You lose press M to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    SoundPlayer player4 = new SoundPlayer(Properties.Resources.oof);
                    break;
                case 6:
                    BackgroundImage = Properties.Resources.full_gear;
                    outputLabel.Text = "You take all his gear and then you make your way to the end of the hallway";
                    redLabel.Text = "Left?";
                    blueLabel.Text = "Right?";
                    greenLabel.Text = "";
                    SoundPlayer player5 = new SoundPlayer(Properties.Resources.takegear);
                    break;
                case 7:
                    BackgroundImage = Properties.Resources.guard_gear;
                    outputLabel.Text = "You take a grenade and his baton. you then start to make your way down a new hallway ";
                    redLabel.Text = "Do you turn left?";
                    blueLabel.Text = " Do you turn right?";
                    greenLabel.Text = "";
                    SoundPlayer player6 = new SoundPlayer(Properties.Resources.takegear);
                    break;
                case 8:
                    BackgroundImage = Properties.Resources.guardone;
                    outputLabel.Text = "You find a single gaurd";
                    redLabel.Text = "do you beat him?";
                    blueLabel.Text = "do you taser him?";
                    greenLabel.Text = "";
                    SoundPlayer player7 = new SoundPlayer(Properties.Resources.footsteps);
                    break;
                case 9:
                    BackgroundImage = Properties.Resources.alabama_guards;
                    outputLabel.Text = "you find 5 gaurds walking towards you";
                    redLabel.Text = "do you fight them with your baton?";
                    blueLabel.Text = "do you throw your grenade at them?";
                    greenLabel.Text = "do you hide under the stairs";
                    SoundPlayer player8 = new SoundPlayer(Properties.Resources.footsteps);
                    break;
                    
                case 10:
                    BackgroundImage = Properties.Resources.guard_two;
                    outputLabel.Text = "you find a guard";
                    redLabel.Text = " do you disguise yourself as a gaurd?";
                    blueLabel.Text = "do you run and drop kick him?";
                    greenLabel.Text = "";
                    SoundPlayer player9 = new SoundPlayer(Properties.Resources.footsteps);
                    break;
                    
                case 11:
                    BackgroundImage = Properties.Resources.alabama_guards;
                    outputLabel.Text = "you find 5 guards and you get recognized and beaten";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    SoundPlayer player10 = new SoundPlayer(Properties.Resources.oof);
                    break;
                case 12:
                    SoundPlayer player11 = new SoundPlayer(Properties.Resources.prisoncell);
                    
                    BackgroundImage = Properties.Resources.open_door;
                    outputLabel.Text = "you try to fight them you get knocked out and sent back to your cell";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 13:
                    SoundPlayer player12 = new SoundPlayer(Properties.Resources.footsteps);
                    BackgroundImage = Properties.Resources.hinding_spot;
                    outputLabel.Text = "you run away and hide under a stair case ";
                    redLabel.Text = "do you stealth kill the gaurds?";
                    blueLabel.Text = "do you try to wait out the gaurds so they will leave?";
                    greenLabel.Text = "";
                    break;
                case 14:
                    SoundPlayer player13 = new SoundPlayer(Properties.Resources.endnoise);
                    BackgroundImage = Properties.Resources.ending;
                    outputLabel.Text = "you kill all the guards and walk out of the front doors safely";
                    redLabel.Text = "";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 15:
                    SoundPlayer player14 = new SoundPlayer(Properties.Resources.explosion);
                    BackgroundImage = Properties.Resources.dead_body;
                    outputLabel.Text = "you forget to throw the grenade and get blown up all over the room and the gaurd have a big mess to clean up";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "press b to exit";
                    greenLabel.Text = "";
                    break;
                case 16:
                    SoundPlayer player15 = new SoundPlayer(Properties.Resources.oof);
                    BackgroundImage = Properties.Resources.dead_body;
                    outputLabel.Text = " you try to beat him he turns on you and you get beat to death";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 17:
                    SoundPlayer player16= new SoundPlayer(Properties.Resources.alarm);
                    BackgroundImage = Properties.Resources.alertbutton;
                    outputLabel.Text = "you taser him you get him on the ground but he hits a button for back up";
                    redLabel.Text = "do you make a break for it out the door?";
                    blueLabel.Text = "do you steal the gaurd outfit and walk out the door?";
                    greenLabel.Text = "";
                    break;
                case 18:
                    SoundPlayer player17 = new SoundPlayer(Properties.Resources.endnoise);
                    BackgroundImage = Properties.Resources.ending;
                    outputLabel.Text = "you drop kick the guard and knock him unconscious. then you walk out the door and escape";
                    redLabel.Text = "";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 19:
                    SoundPlayer player18 = new SoundPlayer(Properties.Resources.oof);
                    BackgroundImage = Properties.Resources.open_door;
                    outputLabel.Text = "you get caught and he takes you back to your cell";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 20:
                    SoundPlayer player19 = new SoundPlayer(Properties.Resources.endnoise);
                    BackgroundImage = Properties.Resources.ending;
                    outputLabel.Text = "you escape the prison successfully through the back door";
                    redLabel.Text = "";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 21:
                    SoundPlayer player20 = new SoundPlayer(Properties.Resources.endnoise);
                    BackgroundImage = Properties.Resources.ending;
                    outputLabel.Text = "you a make an awesome escape";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 22:
                    SoundPlayer player21 = new SoundPlayer(Properties.Resources.oof);
                    BackgroundImage = Properties.Resources.dead_body;
                    outputLabel.Text = "you wait and you starve to death";
                    redLabel.Text = "You lose press M to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 23:
                    SoundPlayer player22 = new SoundPlayer(Properties.Resources.endnoise);
                    BackgroundImage = Properties.Resources.ending;
                    outputLabel.Text = "You walk out the tower thinks you are a guard looking for the escaping prisoner and you get free";
                    redLabel.Text = "";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 24:
                    SoundPlayer player23 = new SoundPlayer(Properties.Resources.snipershot);
                    BackgroundImage = Properties.Resources.sniper;
                    outputLabel.Text = "You make a break for it and the guard tower in on alert and they snipe you before you can escape";
                    redLabel.Text = "you lose press m to restart";
                    blueLabel.Text = "press B to exit";
                    greenLabel.Text = "";
                    break;
                case 25:
                    BackgroundImage = Properties.Resources.ending;
                    break;
                case 26:
                    BackgroundImage = Properties.Resources.alabama_guards;

                    Close();
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
