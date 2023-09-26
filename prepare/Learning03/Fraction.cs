// Fraction class has 
// The responsability of holding a fraction provided and display the decimal value.
public class Fraction
{

    private int _top;
    private int _bottom;



    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

     public Fraction(int top){
        _top = top;
        _bottom = 1;
    }

     public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    //  GetFractionString: returns the fraction in the form 3/4.
    public string GetFractionString(){

        return String.Format($"{_top}/{_bottom}");
    }
    //  GetDecimalValue : returns a double that is the result of dividing the top number by the bottom number.
    public double GetDecimalValue(){

        return ((double)_top)/((double)_bottom);
    }


}