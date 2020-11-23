using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRooms
{
    public partial class Form1 : Form
    {
        int Moves;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;


        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);

        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        



        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Гостиная", "старинный ковер","в гардеробе",
               "дубовая дверь с латунной ручкой");
            diningRoom = new RoomWithHidingPlace("Столовая", "хрустальная люстра","в высоком шкафу");
            stairs = new Room("Лестница","деревянные перила");
            kitchen = new RoomWithDoor("Кухня", "плита из нержавеющей стали","в сундуке" ,"сетчатая дверь");
            frontYard = new OutsideWithDoor("лужайка", false, "дубовая дверь с латунной ручкой");
            backYard = new OutsideWithDoor("Задний двор", true, "сетчатая дверь");
            hallway = new RoomWithHidingPlace("Верхний коридор", "картина с собакой",
              "в гардеробе");
            bathroom = new RoomWithHidingPlace("Ванная", "раковина и туалет",
                      "в душе");
            masterBedroom = new RoomWithHidingPlace("Главная спальня", "большая кровать",
                      "под кроватью");
            secondBedroom = new RoomWithHidingPlace("Вторая спальня", "маленькая кровать",
                      "под кроватью");
            frontYard = new OutsideWithDoor("лужайка", false, "тяжелая дубовая дверь");
            backYard = new OutsideWithDoor("Задний двор", true, "сетчатая дверь");
            garden = new OutsideWithHidingPlace("Сад", false, "в сарае");
            driveway = new OutsideWithHidingPlace("Подъезд", true, "в гараже");




            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom,stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway};
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden ,driveway};
            backYard.Exits = new Location[] { frontYard, garden ,driveway};
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard,frontYard};

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
                for (int i = 0; i < currentLocation.Exits.Length; i++)
                {
                    exits.Items.Add(currentLocation.Exits[i].Name);
                }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + $"\r\n(перемещение #{Moves})";
            if(currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Check " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
            {
                check.Visible = false;
            }


            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;

        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Меня нашли за " + Moves + " ходов.");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = $"Соперник найден за {Moves} ходов! Он прятался {foundLocation.HidingPlaceName}.";
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }






        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Я иду искать!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);

        }
    }
}
