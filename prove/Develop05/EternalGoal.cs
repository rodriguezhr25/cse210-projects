// Eternal goal class
// The responsability of holding data about eternal goals

public class EternalGoal:Goal
{   


    public EternalGoal(string name, string description, string points):base(name, description, points)
    {

    }

    public override int RecordEvent(){
        return GetPoints();
    }
    public override bool Iscomplete(){

        return false;

    }
    public override string GetStringRepresentation(){

        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";

    }

}