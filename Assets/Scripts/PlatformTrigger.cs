using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player p = collision.GetComponent<Player>();
        if (p)
        {
            p.gameObject.transform.parent = transform.parent;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player p = collision.GetComponent<Player>();
        if (p)
        {
            p.gameObject.transform.parent = null;
        }

    }
}
