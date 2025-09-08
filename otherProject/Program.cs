string userName = "";

Console.Write("What is your name? ");
userName = Console.ReadLine();

string msg = "You dont know everything, " + userName;

if (userName == "Tobias" || userName == "Kian")
{
	msg = "Hello " + userName + "! You know everything <3";
}

Console.WriteLine(msg);
