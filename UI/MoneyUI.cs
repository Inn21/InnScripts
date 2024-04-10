using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI:MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TMPTextBox;

    [SerializeField] Text TextBox;

    public void Awake()
    {
        Money.setTextUI(TextBox);
        Money.setTextUI(TMPTextBox);
    }
}
