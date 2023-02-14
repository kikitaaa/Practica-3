using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public AudioClip coinSound;
    [Range(0, 1)]
    public float coinVolume;
    [SerializeField] private float coinPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //El player destruye los objetos extras.
        {
            GameManager.instance.AddPunt(coinPoints);
            Destroy(this.gameObject);
            AudioManager.instance.PlayAudio(coinSound, coinVolume);

        }

    }
    
}