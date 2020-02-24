//Jake Cermak

using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string sentinelValue;
            int playerCount = 0;
            double salaryTotal = 0;
            int rankBank = 0;

            string[,] name = { //populating data in the player object
                                        {"Joe Burrow", "Tua Tagovailoa", "Justin Herbert", "Jordan Love", "Jake Fromm"},
                                        {"D'Andre Swift", "Jonathan Taylor", "J.K. Dobbins", "Zack Moss", "Cam Akers"},
                                        {"CeeDee Lamb", "Jerry Jeudy", "Tee Higgins", "Henry Ruggs III", "Tyler Johnson"},
                                        {"Chase Young", "Derrick Brown", "A.J. Epenesa", "Javon Kinlaw", "Yetur Gross-Matos"},
                                        {"Jeff Okudah", "Grant Delpit", "Kristian Fulton", "Xavier McKinney", "CJ Henderson"},
                                        {"Cole Kmet", "Brycen Hopkins", "Hunter Bryant", "Jared Pinkney", "Jacob Breeland"},
                                        {"Isaiah Simmons", "Kenneth Murray", "Zack Buan", "Akeem Davis-Gaither", "Troy Dye"},
                                        {"Jedrick Wills Jr.", "Andrew Thomas", "Tristan Wirfs", "Tyler Biadasz", "Mekhi Becton"}
                             };

            string[,] institution = { //populating data in the player object
                                        {"LSU", "Alabama", "Oregon", "Utah St.", "Georgia"},
                                        {"Georgia", "Wisconsin", "Ohio St.", "Utah", "Florida St."},
                                        {"Oklahoma", "Alabama", "Clemson", "Alabama", "Minnesota"},
                                        {"Ohio St.", "Auborn", "Iowa", "So. Carolina", "Penn St."},
                                        {"Ohio St.", "LSU", "LSU", "Alabama", "Florida"},
                                        {"Notre Dame", "Purdue", "Washington", "Vanderbilt", "Oregon"},
                                        {"Clemson", "Oklahoma", "Wisconsin", "App. St.", "Oregon"},
                                        {"Alabama", "Georgia", "Iowa", "Wisconsin", "Louisville"},

                                    };

            string[,] position = { //populating data in the player object
                                        {"Quarterback", "Quarterback", "Quarterback", "Quarterback", "Quarterback"},
                                        {"Running back", "Running back", "Running back", "Running back", "Running back"},
                                        {"Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver"},
                                        {"Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman"},
                                        {"Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back"},
                                        {"Tight Ends", "Tight Ends", "Tight Ends", "Tight Ends", "Tight Ends"},
                                        {"Line-Backer's", "Line-Backer's", "Line-Backer's", "Line-Backer's", "Line-Backer's"},
                                        {"Offensive Tackles", "Offensive Tackles", "Offensive Tackles", "Offensive Tackles", "Offensive Tackles"}
                                 };

            double[,] salary = { //populating data in the player object
                                        {26400100, 20300100, 17420300, 13100145, 10300000},
                                        {24500100, 19890200 , 18700800, 15000000, 11600400},
                                        {23400000, 21900300, 19300230, 13400230, 10000000},
                                        {26200300, 22000000, 16000000, 18000000, 13000000},
                                        {24000000, 22500249, 20000100, 16000200, 11899999},
                                        {27800900, 21000800, 17499233, 27900200, 14900333},
                                        {22900300, 19000590, 18000222, 12999999, 10000100},
                                        {23000000, 20000000, 19400000, 16200700, 15900000}
                               };


            string[,] best = { //populating data in the player object
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                        {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"}
                             };

            List<Player> playerList = new List<Player>();
            List<Player> selectedPlayers = new List<Player>();

            for (var i = 0; i < 8; i++) //populating the player list
            {
                for (var x = 0; x < 5; x++)
                {
                    Player aPlayer = new Player(count++, name[i, x], institution[i, x], position[i, x], salary[i, x], true, best[i, x]);
                    playerList.Add(aPlayer);


                    //Console.WriteLine("{0} goes for {1}", selection[i, x], price[i, x].ToString("c"));
                }
            }


            //Beginning
                Console.WriteLine("Welcome to the NFL drafting program");
                Console.WriteLine("Press any key to get started or X to exit the program");
                sentinelValue = Console.ReadLine().ToUpper();
            
            while (sentinelValue != "X")
            {
                Console.Clear(); //clears existing text if the program is restarted
                playerList.ForEach(x => Console.WriteLine($"{x.ToString()}"));
                Console.WriteLine("Please enter the ID of the player you want to select");

                int selection = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < playerList.Count; i++)
                {
                    if (selection == playerList[i].id)
                    {
                        selectedPlayers.Add(playerList[i]);
                        playerList.RemoveAt(i);
                        //playerList[i] = bPlayer;
                        Console.WriteLine(playerList);
                        playerCount = playerCount + 1;
                        //salaryTotal = salaryTotal + playerList[i].Salary;
                        Console.WriteLine(playerList[i].Name);

                    }
                    
                }
                //Console.Clear();

                //if ()
                Console.WriteLine("Existing players to select from");
                playerList.ForEach(x => Console.WriteLine(x.ToString()));

                Console.WriteLine("Coaches Selected Players");
                selectedPlayers.ForEach(x => Console.WriteLine(x.ToString()));

                
                Console.WriteLine("Do you want to play again?");
                sentinelValue = Console.ReadLine().ToUpper();
            }

        }
    }
}
class Player //Making a player class for the players
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Institution { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public bool Availability { get; set; }
    public string Best { get; set; }
	//Making a constructor
	public Player(int id, string Name, string Institution, string Position, double Salary, bool Availability, string Best)
	{
        this.id = id;
		this.Name = Name;
		this.Institution = Institution;
		this.Position = Position;
		this.Salary = Salary;
        this.Availability = Availability;
        this.Best = Best;
	}
    public override string ToString()
    {
        return String.Format($"ID: {id}  Name: {Name} Institution: {Institution} Position: {Position} Salary: {Salary.ToString("c")}" +
            $" Availability: {Availability}  Best: {Best} \n");
    }
}