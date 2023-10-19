// Goal Manager class
// The responsability of processing functions for the main class

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
            Console.WriteLine(" 6. Quit");
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
                case 5:
                    RecordEvent();
                    break;

            }

        } while (option != 6);

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
                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);
                _goals.Add(checkListGoal);
                break;
        }

    }

    public void RecordEvent()
    {

        Console.WriteLine("");
        Console.WriteLine("The Goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            if (!goal.Iscomplete())
            {
                Console.WriteLine($"{i}. {goal.GetName()}");
                i++;
            }
        }
        Console.Write("Which goal did you accomplish ? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        int points = _goals[goalNumber].RecordEvent(); ;
        _score = _score + points;
        DisplayPointsMessage(points);


    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

    public void DisplayPointsMessage(int points)
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points!");
    }

}