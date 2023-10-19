// Goal Manager class
// The responsability of processing functions for the main class
using System.IO;
public class GoalManager
{

    private List<Goal> _goals;

    private int _score;

    public GoalManager()
    {

        _score = 0;
        _goals = new List<Goal>();
    }
    public void Start()
    {

        int option = 0;
        string fileName;
        do
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            // This new item will reset points and goals status. ( Exceeding Requirements)
            Console.WriteLine(" 6. Reset Goals/Points");
            Console.WriteLine(" 7. Quit");
            Console.WriteLine("Select a choice from the menu");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListGoalNames();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    SaveGoals(fileName);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    LoadGoals(fileName);
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    ResetGoals();
                    break;


            }

        } while (option != 7);

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {

        Console.WriteLine("");
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you ike to create? ");
        CreateGoal();


    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            string goalTextDetails = goal.GetDetailsString();
            goalTextDetails = goal.Iscomplete() ? goalTextDetails.Replace("[ ]", "[x]") : goalTextDetails;
            Console.WriteLine($"{i}. {goalTextDetails}");
            i++;
        }
    }

    public void CreateGoal()
    {
        int goalType;
        string name;
        string description;
        string points;
        int target;
        int bonus;

        goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();
        switch (goalType)
        {

            case 1:

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                bonus = int.Parse(Console.ReadLine());
                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, bonus, target);
                _goals.Add(checkListGoal);
                break;
        }

    }

    public void RecordEvent()
    {
        var goalsToBeCompleted = _goals.Where(w => w.Iscomplete() == false).ToList();

        if (goalsToBeCompleted.Count > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("The Goals are:");
            int i = 1;
            foreach (Goal goal in goalsToBeCompleted)
            {
                if (!goal.Iscomplete())
                {
                    Console.WriteLine($"{i}. {goal.GetName()}");
                    i++;
                }
            }
            Console.Write("Which goal did you accomplish ? ");
            int goalNumber = int.Parse(Console.ReadLine()) - 1;
            if (goalNumber < goalsToBeCompleted.Count)
            {
                int points = goalsToBeCompleted[goalNumber].RecordEvent(); ;
                _score = _score + points;
                DisplayPointsMessage(points);
            }
            else
            {
                Console.Write("Please select a valid goal ");
                RecordEvent();
            }

        }
        else
        {
            Console.Write("You have completed all your goals, please register more! ");
        }


    }

    public void SaveGoals(string fileName)
    {


        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"Points: {_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            Console.Write($"Your file {fileName} was created succesfully! ");

        }
    }

    public void LoadGoals(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string type = parts[0];
            string value = parts[1];
            string[] values = parts[1].Split(",");

            switch (type)
            {
                case "Points":
                    _score = int.Parse(value);
                    break;
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(values[0], values[1], values[2]);
                    bool isComplete = bool.Parse(values[3]);
                    simpleGoal.SetCompleted(isComplete);
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":

                    EternalGoal eternalGoal = new EternalGoal(values[0], values[1], values[2]);
                    _goals.Add(eternalGoal);
                    break;
                case "CheckListGoal":

                    int bonus = int.Parse(values[3]);
                    int target = int.Parse(values[4]);
                    int amountCompleted = int.Parse(values[5]);
                    CheckListGoal checkListGoal = new CheckListGoal(values[0], values[1], values[2], bonus, target);
                    checkListGoal.SetAmountCompleted(amountCompleted);
                    _goals.Add(checkListGoal);
                    break;
            }
        }
    }

    public void DisplayPointsMessage(int points)
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points!");
    }
    // 6. Reset Goals/Points
    // This new item will reset points and goals status. ( Exceeding Requirements)
    public void ResetGoals()
    {
        _score = 0;
        List<Goal> _goalsTemp = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if (goal.GetType() == typeof(SimpleGoal))
            {
                _goalsTemp.Add(new SimpleGoal(goal.GetName(), goal.GetDescription(), goal.GetPoints().ToString()));
            }
            else if (goal.GetType() == typeof(EternalGoal))
            {
                _goalsTemp.Add(new EternalGoal(goal.GetName(), goal.GetDescription(), goal.GetPoints().ToString()));
            }
            else if (goal.GetType() == typeof(CheckListGoal))
            {
                _goalsTemp.Add(new CheckListGoal(goal.GetName(), goal.GetDescription(), goal.GetPoints().ToString(), goal.GetBonus(), goal.GetTarget()));
            }
        }
        _goals = new List<Goal>();
        foreach (Goal goal in _goalsTemp)
        {
            _goals.Add(goal);
        }

        Console.WriteLine("Goal values were reset");
    }

}