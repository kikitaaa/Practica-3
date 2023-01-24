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
            p.gameObject.transform.parent = transform.parent; //Al cambiar el padre modificara la posicion, escala y rotacion relativa del padre y mantendra estos parametros del espacio del mundo igual
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
