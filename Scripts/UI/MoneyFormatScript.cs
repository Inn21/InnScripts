using UnityEngine;

public static class MoneyFormatScript
{
    public static string MoneyFormat(this ulong value)
    { 
        string result = "" + value;

        if (value >= Mathf.Pow(10, 3) && value <  Mathf.Pow(10, 6))
        {
            result = (value /  Mathf.Pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >=  Mathf.Pow(10, 6) && value <  Mathf.Pow(10, 9))
        {
            result = (value /  Mathf.Pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >=  Mathf.Pow(10, 9) && value <  Mathf.Pow(10, 12))
        {
            result = (value /  Mathf.Pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >=  Mathf.Pow(10, 12) && value <  Mathf.Pow(10, 15))
        {
            result = (value /  Mathf.Pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >=  Mathf.Pow(10, 15) && value <  Mathf.Pow(10, 18))
        {
            result = (value /  Mathf.Pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >=  Mathf.Pow(10, 18) && value <  Mathf.Pow(10, 21))
        {
            result = (value /  Mathf.Pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >=  Mathf.Pow(10, 21)) // && value <  Mathf.Pow(10, 24)
        {
            result = (value /  Mathf.Pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this int value)
    { 
        string result = "" + value;

        if (value >=  Mathf.Pow(10, 3) && value <  Mathf.Pow(10, 6))
        {
            result = (value /  Mathf.Pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >=  Mathf.Pow(10, 6) && value <  Mathf.Pow(10, 9))
        {
            result = (value /  Mathf.Pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >=  Mathf.Pow(10, 9) && value <  Mathf.Pow(10, 12))
        {
            result = (value /  Mathf.Pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >=  Mathf.Pow(10, 12) && value <  Mathf.Pow(10, 15))
        {
            result = (value /  Mathf.Pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >=  Mathf.Pow(10, 15) && value <  Mathf.Pow(10, 18))
        {
            result = (value /  Mathf.Pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >=  Mathf.Pow(10, 18) && value <  Mathf.Pow(10, 21))
        {
            result = (value /  Mathf.Pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >=  Mathf.Pow(10, 21)) // && value <  Mathf.Pow(10, 24)
        {
            result = (value /  Mathf.Pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this float value)
    { 
        string result = "" + value;

        if (value >=  Mathf.Pow(10, 3) && value <  Mathf.Pow(10, 6))
        {
            result = (value /  Mathf.Pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >=  Mathf.Pow(10, 6) && value <  Mathf.Pow(10, 9))
        {
            result = (value /  Mathf.Pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >=  Mathf.Pow(10, 9) && value <  Mathf.Pow(10, 12))
        {
            result = (value /  Mathf.Pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >=  Mathf.Pow(10, 12) && value <  Mathf.Pow(10, 15))
        {
            result = (value /  Mathf.Pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >=  Mathf.Pow(10, 15) && value <  Mathf.Pow(10, 18))
        {
            result = (value /  Mathf.Pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >=  Mathf.Pow(10, 18) && value <  Mathf.Pow(10, 21))
        {
            result = (value /  Mathf.Pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >=  Mathf.Pow(10, 21)) // && value <  Mathf.Pow(10, 24)
        {
            result = (value /  Mathf.Pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this uint value)  
    { 
        string result = "" + value;

        if (value >=  Mathf.Pow(10, 3) && value <  Mathf.Pow(10, 6))
        {
            result = (value /  Mathf.Pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >=  Mathf.Pow(10, 6) && value <  Mathf.Pow(10, 9))
        {
            result = (value /  Mathf.Pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >=  Mathf.Pow(10, 9) && value <  Mathf.Pow(10, 12))
        {
            result = (value /  Mathf.Pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >=  Mathf.Pow(10, 12) && value <  Mathf.Pow(10, 15))
        {
            result = (value /  Mathf.Pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >=  Mathf.Pow(10, 15) && value <  Mathf.Pow(10, 18))
        {
            result = (value /  Mathf.Pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >=  Mathf.Pow(10, 18) && value <  Mathf.Pow(10, 21))
        {
            result = (value /  Mathf.Pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >=  Mathf.Pow(10, 21)) // && value <  Mathf.Pow(10, 24)
        {
            result = (value /  Mathf.Pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
    public static string MoneyFormat(this long value)  
    { 
        string result = "" + value;

        if (value >=  Mathf.Pow(10, 3) && value <  Mathf.Pow(10, 6))
        {
            result = (value /  Mathf.Pow(10, 3)).ToString("0.0") + "K";
        }
        else if (value >=  Mathf.Pow(10, 6) && value <  Mathf.Pow(10, 9))
        {
            result = (value /  Mathf.Pow(10, 6)).ToString("0.0") + "M";
        }
        else if (value >=  Mathf.Pow(10, 9) && value <  Mathf.Pow(10, 12))
        {
            result = (value /  Mathf.Pow(10, 9)).ToString("0.0") + "B";
        }
        else if (value >=  Mathf.Pow(10, 12) && value <  Mathf.Pow(10, 15))
        {
            result = (value /  Mathf.Pow(10, 12)).ToString("0.0") + "T";
        }
        else if (value >=  Mathf.Pow(10, 15) && value <  Mathf.Pow(10, 18))
        {
            result = (value /  Mathf.Pow(10, 15)).ToString("0.0") + "q";
        }
        else if (value >=  Mathf.Pow(10, 18) && value <  Mathf.Pow(10, 21))
        {
            result = (value /  Mathf.Pow(10, 18)).ToString("0.0") + "Q";
        }
        else if (value >=  Mathf.Pow(10, 21)) // && value <  Mathf.Pow(10, 24)
        {
            result = (value /  Mathf.Pow(10, 21)).ToString("0.0") + "s";
        }
        return result;
    }
}
