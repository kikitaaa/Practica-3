using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform Followplayer = null;
    public float speed;

    private void OnCollisionEnter2D( Collision2D other)
    {
        if(other.collider.GetComponent<Player>())
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("SampleScene");

        }
        
    }
    void Start()
    {
        Followplayer = GameObject.CompareTag("Player").GetComponet<Transform>();

    }

    void Update()
    {
        if(Followplayer == null)
        {
            return;
        transform.position = Vector2.MoveTowards(transform.position,new Vector2 (Followplayer.transform.position.x,transform.position.y),speed * Time.deltaTime);

        }
        

    }
}
