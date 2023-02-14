using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float score = 0;
    public float time = 0;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }
    public void AddPunt(float value)
    {
        score += value;
    }
    public float GetPunt()
    {
        return score;
    }

    public float GetTime()
    {
        return time;
    }

}
