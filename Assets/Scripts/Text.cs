using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public TMPro.TMP_Text textt;

    void Update()
    {
        textt.text = "Score: " + GameManager.instance.GetPunt();
    }
}
