public class Fraction
{
    // Private attributes
     private int _top;
     private int _bottom;

    // ---------- Constructors ----------

    // Constructor 1: Default constructor (No parameters)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter for top
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Two Parameters top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // ---------Getters and Setters----------
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // ------- Representation method -------

    // Returns a string representation of the fraction
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns double/decimal representation
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}

