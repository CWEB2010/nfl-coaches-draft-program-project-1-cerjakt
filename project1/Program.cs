//Jake Cermak

using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
class Player //Making a player class for the players
{
	public string FirstName { get; set; } //first name method
	public string LastName { get; set; } //last name method
	public string Institution { get; set; } //institution method
	public string Position { get; set; } //position method
	public double Salary { get; set; } //salary method

	//Making a constructor
	public Player(string FirstName, string LastName, string Institution, string Position, double Salary)
	{
		this.FirstName = FirstName;
		this.LastName = LastName;
		this.Institution = Institution;
		this.Position = Position;
		this.Salary = Salary;
	}
}