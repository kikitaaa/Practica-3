using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy1 : MonoBehaviour
{
    // Start is called before the first frame update
    private const string Tag = "Player";
    public Transform ObjectFollow = null;
    public float speed = 2;
    public AudioClip playerdieSound;
    [Range(0,2)]
    public float playerdieVolume;


    private void OnCollisionEnter2D(Collision2D other)//Metodo destroy
    {
        if (other.collider.GetComponent<Player>())
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("SampleScene");
            AudioManager.instance.PlayAudio(playerdieSound, playerdieVolume);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ObjectFollow = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();// Invocamos al player
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectFollow == null) //En caso de que no haya nada
            return;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(ObjectFollow.transform.position.x, transform.position.y), speed * Time.deltaTime);

    }
}