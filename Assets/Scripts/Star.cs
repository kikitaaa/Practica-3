using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int time = 0;
    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyStar();
    }

    void DestroyStar()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= time)
        {
            Destroy(gameObject);
        }
    }
}
