using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity;
    public float jumpSpeed;
    public float rayDistance = 1.5f;
    public CheckGround check;
    public AudioClip jumpingSound;
    [Range(0, 1)]
    public float jumpingVolume;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Agregamos el componente desde el codigo, no necesariamente desde el inspector.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //Mover el jugador hacia la izquierda.
        {
            rb.velocity = new Vector3(-10, rb.velocity.y, 0);
        }
        else if (Input.GetKey(KeyCode.D)) //Mover el jugador hacia la derecha.
        {
            rb.velocity = new Vector3(10, rb.velocity.y, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && check.IsGrounded()) //Una vez pulsada la tecla space el jugador salta.
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            AudioManager.instance.PlayAudio(jumpingSound, jumpingVolume);
        }
    }

    void OnDrawGizmosSelected()  //Dibujamos un gizmo 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }
} 



