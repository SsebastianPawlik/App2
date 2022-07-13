using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelDomu
{
    public partial class Form1 : Form
    {
        Location curretLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        Outside garden;
        OutSideWithDoor frontYard;
        OutSideWithDoor backYard;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToNewLocation(livingRoom);
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antczny dywan", "dębowe drzwi");
            diningRoom = new Room("Jadalnia", "kryształ");
            kitchen = new RoomWithDoor("Kuchnia", "stalowe sztućce", "rozsuwane drzwi");
            frontYard = new OutSideWithDoor("Podwórko przed domem", false, "dębowe drzwi");
            backYard = new OutSideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new Outside("ogród", false);
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToNewLocation(Location newLocation)
        {
            curretLocation = newLocation;
            exits.Items.Clear();
            for(int i = 0; i < curretLocation.Exits.Length; i++) 
                exits.Items.Add(curretLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            descryption.Text = curretLocation.Descrption;
            if (curretLocation is IHasExteriorDoor)
                goThroughtDoor.Visible = true;
            else
                goThroughtDoor.Visible = false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(curretLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughtDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = curretLocation as IHasExteriorDoor;
            MoveToNewLocation(hasDoor.DoorLocation);
        }
    }
}
