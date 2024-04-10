using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField]Image imageScript;

    [SerializeField] List<Sprite> images = new List<Sprite>();
    public void SetSprite(int index) 
    {
        if (index < 0 || index >= images.Count) return;
        imageScript.sprite = images[index];
    }
}
