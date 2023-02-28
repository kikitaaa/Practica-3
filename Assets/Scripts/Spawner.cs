using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float maxTime = 5;
    private float currentTime = 0;
    private List<string> nombres;

    private void Start()
    {
        // Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
        nombres = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= maxTime)
        {
            GameObject o = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            nombres.Add(o.name);

            foreach(string s in nombres)
            {
                Debug.Log(s);

            }
            

            currentTime = 0;
        }
    }
}
