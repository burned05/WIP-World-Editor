using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldEditor.Objects;

namespace WorldEditor
{
    public partial class Form1 : Form
    {
        enum SI{ Object, Tile, Event, Placed, None };
        SI selectedItem = SI.None;
        decimal numLayers = 0;
        List<Object> objects;
        

        public Form1()
        {
            InitializeComponent();
            ObjectListBox.Items.Add("Key");
            ObjectListBox.Items.Add("Ammo");
            ObjectListBox.Items.Add("Health");
            ObjectListBox.Items.Add("Adrenaline");

            ObjectListBox.Items.Add("Barrel");
            ObjectListBox.Items.Add("Pipe");

            ObjectListBox.Items.Add("Couch");
            ObjectListBox.Items.Add("Wardrobe");
            ObjectListBox.Items.Add("Lamp");
            ObjectListBox.Items.Add("Desk");
            ObjectListBox.Items.Add("Tree");
            ObjectListBox.Items.Add("China");
            ObjectListBox.Items.Add("Table");
            ObjectListBox.Items.Add("Chair");
            ObjectListBox.Items.Add("Door");

            ObjectListBox.Items.Add("Pistol");
            ObjectListBox.Items.Add("Assault Rifle");
            ObjectListBox.Items.Add("Shotgun");
            ObjectListBox.Items.Add("Rocket Launcher");
            ObjectListBox.Items.Add("Laser Cannon");

            ObjectListBox.Items.Add("Player");
            ObjectListBox.Items.Add("Cop");
            ObjectListBox.Items.Add("Civilian");
            ObjectListBox.Items.Add("Enemy");
            ObjectListBox.Items.Add("Boss");
        }

        private void World_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            switch(selectedItem)
            {
                case SI.Object:
                    PlaceObject();
                    break;
                case SI.Event:

                    break;
                case SI.Tile:

                    break;
                case SI.None:

                    break;

                default:
                    break;
            };
            World_Panel.Invalidate();
        }

        private void AddLayerButton_Click(object sender, EventArgs e)
        {
            numLayers += 1;
            string nextLayer = "Layer " + numLayers.ToString();
            LayerListBox.Items.Add(new Layer(nextLayer, numLayers));
            LayerListBox.Invalidate();
        }

        private void LayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListBox.ClearSelected();
        }

        private void ObjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = ObjectListBox.SelectedIndex;
            PlacedObjectListBox.ClearSelected();
            ObjectListBox.SelectedIndex = selected;
            selectedItem = SI.Object;
        }
        
        public void PlaceObject()
        {
            Object temp;
            switch (ObjectListBox.SelectedItem.ToString())
                    { 
                        case "Key":
                            temp = new Key();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Ammo":
                            temp = new Ammo();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Health":
                            temp = new Health();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Adrenaline":
                            temp = new Adrenaline();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Barrel":
                            temp = new Barrel();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Pipe":
                            temp = new Pipe();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Couch":
                            temp = new Couch();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Wardrobe":
                            temp = new Wardrobe();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Lamp":
                            temp = new Lamp();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Desk":
                            temp = new Desk();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Tree":
                            temp = new Tree();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "China":
                            temp = new China();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Table":
                            temp = new Table();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Chair":
                            temp = new Chair();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Pistol":
                            temp = new Pistol();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Door":
                            temp = new Door();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Assault Rifle":
                            temp = new AssaultRifle();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Shotgun":
                            temp = new Shotgun();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Rocket Launcher":
                            temp = new RocketLauncher();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Laser Cannon":
                            temp = new LaserCannon();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Player":
                            temp = new Player();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Enemy":
                            temp = new Enemy();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Civilian":
                            temp = new Civilian();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Boss":
                            temp = new Boss();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                        case "Cop":
                            temp = new Cop();
                            PlacedObjectListBox.Items.Add(temp);
                            break;
                    };        
        }

        private void PlacedObjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = PlacedObjectListBox.SelectedIndex;
            ObjectListBox.ClearSelected();
            PlacedObjectListBox.SelectedIndex = selected;
            selectedItem = SI.Placed;
        }
    }
}
