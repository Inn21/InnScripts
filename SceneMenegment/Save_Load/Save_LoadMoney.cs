using UnityEngine;

public class Save_LoadMoney : Save_LoadBase
{
    void Start()
    {
        Money.AfterBuy += Save;
    }

    public override void Load()
    {
        Money.SetCount(Save_Load.LoadULong(Key));
    }

    public override void Save()
    {
        Save_Load.Save(Money.Count, Key);
    }

    
}