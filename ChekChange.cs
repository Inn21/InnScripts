using System;
using UnityEngine;

public class ChekChange : MonoBehaviour
{
    [SerializeField] MonoBehaviour CheckScript;

    [SerializeField] includedInteract StateChangeOn;
    [SerializeField] includedInteract StateChangeOff;
    bool state;
    void Awake()
    {
        try
        {
            CheckScript.TryGetComponent<ICheckState>(out var check );

            check.ChangeState += ChangeState;
        }
        catch
        {
            Console.Error.WriteLine("No Check reference!");
        }
    }        
    void ChangeState(bool new_state)
    {
        this.state = new_state;
        if (new_state == true)
        {
            StateChangeOn.Activate();
        }
        else
        {
            StateChangeOff.Activate();
        }
    }

}
[SerializeField]
interface ICheckState
{
    public event Action<bool> ChangeState;
}
