///////////////////////////////////
//Name: Jake Cermak
//Course: CWEB2010
//Date: 2/27/2020
//Program Name: NFL Draft Selection
///////////////////////////////////
using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int draftPrimer;
            int draftSentinel = 0;
            Console.WriteLine("To enter the draft, please enter any number but 0");
            draftPrimer = Convert.ToInt32(Console.ReadLine());
            while (draftPrimer != draftSentinel)
            {
             
                //declaring variables
                int count = 0;
                string sentinelValue;
                int playerCount = 0;
                double salaryTotal = 0;
                int rankBank = 0;
                double salaryAccum = 0;
                double budget = 95000000;

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
                                            {"Tight Ends", "Tight End", "Tight End", "Tight End", "Tight End"},
                                            {"Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer"},
                                            {"Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle"}
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

                List<Player> playerList = new List<Player>(); //list to put the players in from the arrays
                List<Player> selectedPlayers = new List<Player>(5); //list to put the selections in at a cap of 5
                selectedPlayers.Clear();

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
                    Console.WriteLine("Welcome to the NFL drafting program"); //welcome text

                    Console.WriteLine("Press any key to get started or X to exit the program"); //prompt text

                    sentinelValue = Console.ReadLine().ToUpper(); //establishes sentinel value

                    while (sentinelValue != "X" && playerCount < 5 && salaryTotal < 95000000) //takes inputs until the player count is maxed, the salary
                                                                                              //total went over, or the sentinel value was pressed.
                    {
                        Console.Clear(); //clears existing text if the program is restarted
                        playerList.ForEach(x => Console.WriteLine($"{x.ToString()}")); //outputs list of available players
                        Console.WriteLine("Please enter the ID of the player you want to select"); //prompt text

                        int selection = Convert.ToInt32(Console.ReadLine()); //waiting for an input for an ID

                        for (int i = 0; i < playerList.Count; i++) //iterates through the player list
                        {
                            if (selection == playerList[i].id) //if the selection was an available ID, output whats's below
                            {
                                selectedPlayers.Add(playerList[i]); //adds to selected players list from position in player list
                                salaryTotal = salaryTotal + playerList[i].Salary; //adjusting the salary total
                                budget = budget - playerList[i].Salary; //adjusting the budget
                                playerList.RemoveAt(i); //removes player from the original list so that you can't select him again
                                playerCount = playerCount + 1; //adds to the player count so that the while loop breaks if you picked more than 5
                            }
                        }

                        Console.Clear(); //clears the console

                        Console.WriteLine("Coaches Selected Players");
                        selectedPlayers.ForEach(x => Console.WriteLine(x.ToString())); //outputs list of selected players

                        Console.WriteLine("Salary Total: " + salaryTotal.ToString("c")); //displays salary total

                        Console.WriteLine("Budget: " + budget.ToString("c")); //displays budget remaining

                        Console.WriteLine("Press any key to pick again or 'X' to exit the player selection");
                        sentinelValue = Console.ReadLine().ToUpper(); //waits to get input to see if it's the sentinel value

                    } //end of while loop

                    Console.Clear(); //clears console

                    if (salaryTotal > 95000000) //notifies you if the while loop broke for this reason
                    {
                        Console.WriteLine("Salary was exceeded");
                    }
                    else if (playerCount == 5) //notifies you if the while loop broke for this reason
                    {
                        Console.WriteLine("Player count has reached 5");
                    }
                    else if (sentinelValue == "X") //notifies you that the while loop broke because you entered in "X".
                    {
                        Console.WriteLine("Selection was exited");
                    }


                    for (int i = 0; i < selectedPlayers.Count; i++) //iterates through the selected player list to determine the size of rank bank
                                                                    //adds to the rankbank and accumulated salary if the selected player was a best,
                                                                    //second best, or third best.
                    {
                        if (selectedPlayers[i].Best == "The Best" || selectedPlayers[i].Best == "2nd Best" || selectedPlayers[i].Best == "3rd Best")
                        {
                            salaryAccum += selectedPlayers[i].Salary;
                            rankBank = rankBank + 1;
                        }
                    }

                    if (rankBank >= 3 && salaryAccum < 65000000) //if the rank bank is equal to 3 or greater than 3 and the
                                                                 //accumulated salary is less than 65 mil, output that it
                                                                 //was cost effective
                    {
                        Console.WriteLine("The picks were cost effective");
                    }

                    Console.WriteLine("Enter in 0 to stop the program, otherwise enter any other number to restart"); //looks for an input so that you can exit the program
                    draftPrimer = Convert.ToInt32(Console.ReadLine()); //Your draft primer is going to be asked again until they enter 0                                                                 
            } //End of my outter while loop 
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
    public override string ToString() //making ToString method
    {
        return String.Format($"ID: {id},  Name: {Name}, Institution: {Institution}, Position: {Position}, Salary: {Salary.ToString("c")}," +
            $" Availability: {Availability},  Best: {Best} \n");
    }
}