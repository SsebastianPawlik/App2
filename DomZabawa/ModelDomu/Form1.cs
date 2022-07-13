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
        int Moves;
        Location curretLocation;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        OutSideWithDoor frontYard;
        OutSideWithDoor backYard;
        OutSideWithHidingPlace garden;
        OutSideWithHidingPlace driveway;
        Opponent opponent;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antczny dywan","w szafie", "dębowe drzwi");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "kryształ","w wysokiej szafie");
            kitchen = new RoomWithDoor("Kuchnia", "stalowe sztućce","w szafce", "rozsuwane drzwi");
            stairs = new Room("Schody", "drewniana poręcz");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazk z psem", "w szafie");
            bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
            masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko", "pod łóżkiem");
            secondBedroom = new RoomWithHidingPlace("Duga sypialnia", "małe łóżko", "pod łóżkiem");
            frontYard = new OutSideWithDoor("Podwórko przed domem", false, "dębowe drzwi");
            backYard = new OutSideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new OutSideWithHidingPlace("ogród", false, "w szopie");
            driveway = new OutSideWithHidingPlace("Droga dojazdowa", true, "w garażu");
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalazłeś mnie w " + Moves + " ruchach!");
                IHidingPlace foundLocation = curretLocation as IHidingPlace;
                descryption.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach! Ukrywał się " + foundLocation.HidingPlaceName;
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughtDoor.Visible = false;
            exits.Visible = false;
        }
        private void MoveToNewLocation(Location newLocation)
        {
            Moves++;
            curretLocation = newLocation;
            RedrawFrom();
        }
        private void RedrawFrom()
        {
            exits.Items.Clear();
            for (int i = 0; i < curretLocation.Exits.Length; i++)
                exits.Items.Add(curretLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            descryption.Text = curretLocation.Descrption + "\r\n(ruch numer " + Moves + ")";
            if (curretLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = curretLocation as IHidingPlace;
                check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(curretLocation))
                ResetGame(true);
            else
                RedrawFrom();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for(int i = 1; i<=10; i++)
            {
                opponent.Move();
                descryption.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            descryption.Text = "Gotowy czy nie szukam!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToNewLocation(livingRoom);
        }
    }
}
