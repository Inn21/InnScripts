using Unity.Mathematics;

public static class MoneyFormatScript
{
    public static string MoneyFormat(this ulong value)
    { 
        string result = "" + value;

        if (value >= math.pow(10, 3) && value < math.pow(10, 6))
        {
            result = (value / math.pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >= math.pow(10, 6) && value < math.pow(10, 9))
        {
            result = (value / math.pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >= math.pow(10, 9) && value < math.pow(10, 12))
        {
            result = (value / math.pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >= math.pow(10, 12) && value < math.pow(10, 15))
        {
            result = (value / math.pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >= math.pow(10, 15) && value < math.pow(10, 18))
        {
            result = (value / math.pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >= math.pow(10, 18) && value < math.pow(10, 21))
        {
            result = (value / math.pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >= math.pow(10, 21)) // && value < math.pow(10, 24)
        {
            result = (value / math.pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this int value)
    { 
        string result = "" + value;

        if (value >= math.pow(10, 3) && value < math.pow(10, 6))
        {
            result = (value / math.pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >= math.pow(10, 6) && value < math.pow(10, 9))
        {
            result = (value / math.pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >= math.pow(10, 9) && value < math.pow(10, 12))
        {
            result = (value / math.pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >= math.pow(10, 12) && value < math.pow(10, 15))
        {
            result = (value / math.pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >= math.pow(10, 15) && value < math.pow(10, 18))
        {
            result = (value / math.pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >= math.pow(10, 18) && value < math.pow(10, 21))
        {
            result = (value / math.pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >= math.pow(10, 21)) // && value < math.pow(10, 24)
        {
            result = (value / math.pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this float value)
    { 
        string result = "" + value;

        if (value >= math.pow(10, 3) && value < math.pow(10, 6))
        {
            result = (value / math.pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >= math.pow(10, 6) && value < math.pow(10, 9))
        {
            result = (value / math.pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >= math.pow(10, 9) && value < math.pow(10, 12))
        {
            result = (value / math.pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >= math.pow(10, 12) && value < math.pow(10, 15))
        {
            result = (value / math.pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >= math.pow(10, 15) && value < math.pow(10, 18))
        {
            result = (value / math.pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >= math.pow(10, 18) && value < math.pow(10, 21))
        {
            result = (value / math.pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >= math.pow(10, 21)) // && value < math.pow(10, 24)
        {
            result = (value / math.pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this uint value)  
    { 
        string result = "" + value;

        if (value >= math.pow(10, 3) && value < math.pow(10, 6))
        {
            result = (value / math.pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >= math.pow(10, 6) && value < math.pow(10, 9))
        {
            result = (value / math.pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >= math.pow(10, 9) && value < math.pow(10, 12))
        {
            result = (value / math.pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >= math.pow(10, 12) && value < math.pow(10, 15))
        {
            result = (value / math.pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >= math.pow(10, 15) && value < math.pow(10, 18))
        {
            result = (value / math.pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >= math.pow(10, 18) && value < math.pow(10, 21))
        {
            result = (value / math.pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >= math.pow(10, 21)) // && value < math.pow(10, 24)
        {
            result = (value / math.pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this long value)  
    { 
        string result = "" + value;

        if (value >= math.pow(10, 3) && value < math.pow(10, 6))
        {
            result = (value / math.pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >= math.pow(10, 6) && value < math.pow(10, 9))
        {
            result = (value / math.pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >= math.pow(10, 9) && value < math.pow(10, 12))
        {
            result = (value / math.pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >= math.pow(10, 12) && value < math.pow(10, 15))
        {
            result = (value / math.pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >= math.pow(10, 15) && value < math.pow(10, 18))
        {
            result = (value / math.pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >= math.pow(10, 18) && value < math.pow(10, 21))
        {
            result = (value / math.pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >= math.pow(10, 21)) // && value < math.pow(10, 24)
        {
            result = (value / math.pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
}
