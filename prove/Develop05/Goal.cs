// Goal class
// The responsability of holding data about goals

public abstract class Goal
{

    private string _shortName;
    private string _description;
    private string _points;
   
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }

    public string GetName(){
        return _shortName;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetPoints(){
        return int.Parse(_points);
    }

    public abstract int RecordEvent();
    public abstract bool Iscomplete();
   
    public abstract string GetStringRepresentation();

     public virtual string GetDetailsString(){
        return $"[ ] {_shortName} ({_description})";
     }

     public virtual int GetBonus(){
        return 0;
     }
    public virtual int GetTarget(){
        return 0;
     }

}