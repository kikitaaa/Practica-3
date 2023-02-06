using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public AudioClip bellSound;
    [Range(0,1)]
    private int score = 0;
    private float time = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
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
    public void AddPunt(int value)
    {
        score += value;
    }
    public int Getpunt()
    {
        return score;
    }
    public float GetTime()
    {
        return time;
    }

}
