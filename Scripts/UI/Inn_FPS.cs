using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Text = UnityEngine.UI.Text;

public class Inn_FPS : MonoBehaviour
{
    [SerializeField] Gradient Bad_GoodColor;
    [SerializeField] float Bad_Fps = 0;
    [SerializeField] float Good_Fps;
    float FPS;

    float color;

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }
    float deltaTime = 0.0f;
    void Update()
    {
            deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

            FPS = 1.0f / deltaTime;        

            color = (FPS - Bad_Fps) / (Good_Fps - Bad_Fps);

            text.color = Bad_GoodColor.Evaluate(math.lerp(0, 1, color));

            text.text = "" + (int)FPS;
               
    }
}
