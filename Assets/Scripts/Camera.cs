using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float cameraspeed;
    public float positioncamera;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pos != null) {
            Vector3 Position = new Vector3(pos.position.x + positioncamera, -0.96f, -10f);
            transform.position = Vector3.Slerp(transform.position, Position, cameraspeed * Time.deltaTime);
        }
    }
}
