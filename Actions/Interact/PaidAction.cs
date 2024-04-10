using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PaidAction : InnScripts.Actions.NoRepActivator
{
    [field: SerializeField] public ulong cost{get; private set;}

    

    
    [Header("Increase")]
    [SerializeField] IncreaseType increaseType;
    [SerializeField] float increaseValue;

    [Header("UIText")]
    [SerializeField] TextMeshProUGUI costTMPText;
    [SerializeField] Text costText;
    enum IncreaseType
    {
        None,
        Add,
        Multyply
    }

    private void Start()
    {
        ChangeText();
    }

    public void SetCost(ulong value)
    {
        cost = value;
    }

    public void ChangeText()
    {
        if(costTMPText != null)
            costTMPText.text = cost.MoneyFormat()+"$";

        if (costText != null)
            costText.text = cost.MoneyFormat() + "$";
    }
    
    public override void Activate()
    {
        if (Money.Buy((int)cost))
        {            
            switch (increaseType) 
            {
            case IncreaseType.Add:
                    cost += (ulong)increaseValue;
                    break;
            case IncreaseType.Multyply:
                    cost = (ulong)(cost * increaseValue);
                    break;            
            }
            ChangeText();
            base.Activate();
        }
    }

}
