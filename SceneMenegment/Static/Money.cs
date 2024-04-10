using TMPro;
using UnityEngine.UI;
using UnityEngine;
using System;


public static class Money
{
    static public ulong Count { get; private set; }

    public static event Action AfterBuy = delegate { };
    public static void SetCount(ulong count)
    {
        Count = count;
        ResetText();
    }

    static TextMeshProUGUI TMPTextBox;
    static Text TextBox;

    static public void setTextUI(TextMeshProUGUI textMeshPro)
    {
        TMPTextBox = textMeshPro;
    }
    static public void setTextUI(Text text)
    {
        TextBox = text;
    }
    static public void ResetText()
    {
        if (TMPTextBox != null)
            TMPTextBox.text = Count.MoneyFormat();
        if (TextBox != null)
            TextBox.text = Count.MoneyFormat();
    }

    public static bool CanBuy(int cost)
    {
        return (uint)cost <= Count;
    }
    public static bool Buy(int value)
    {
        if (Count >= (ulong)Mathf.Abs(value))
        {
            Count -= (ulong)Mathf.Abs(value);
            AfterBuy.Invoke();
            ResetText();
            return true;
        }
        else return false;
    }    
    public static void Add(int value)
    {
        Count = (ulong)Mathf.Clamp(Count + (ulong)Mathf.Abs(value), 0, ulong.MaxValue);
        ResetText();
    }
}
