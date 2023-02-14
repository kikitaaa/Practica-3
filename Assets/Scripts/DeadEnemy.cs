using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEnemy : MonoBehaviour
{
    [SerializeField] private float enemyPoints;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            GameManager.instance.AddPunt(enemyPoints);
            Destroy(gameObject.transform.parent.gameObject); //Destruye al enemigo
        }

    }
}