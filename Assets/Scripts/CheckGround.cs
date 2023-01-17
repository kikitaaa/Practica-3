using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{public LayerMask mascaraSuelo;
    public float rayDistance = 1.5f;
   
    public bool IsGrounded() 
    {
        RaycastHit2D resultado = Physics2D.Raycast(transform.position, 
            Vector2.down, rayDistance, mascaraSuelo.value);

        if (resultado)
        {
            Debug.Log(resultado.collider.gameObject.name);
            if (resultado.collider.gameObject.CompareTag("Ground"))
            {
                return true;
            }
        }

        return false;
    }


}
