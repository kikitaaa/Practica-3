using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : MonoBehaviour
{
    public TMPro.TMP_Text textTime;

    void Update()
    {
        textTime.text = "Time:" + GameManager.instance.GetTime().ToString("0.00"); //Para que se actualize el texto.

    }
}
