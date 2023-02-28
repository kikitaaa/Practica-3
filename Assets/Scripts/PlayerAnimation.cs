using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    public string boolName = "iswalking";
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Hacemos la deadzone, si el player choca con la deadzone, muere y se reinicia la escena
        if (collision.gameObject.CompareTag("deadlava"))
        {
            animator.Play("Dead");


        }
    }
    void death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("SampleScene");
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) //Animacion del player al caminar
        {
            animator.SetBool(boolName, true);

        }
        else
        {
            animator.SetBool(boolName, false);

        }

        if (Input.GetKey(KeyCode.Space)) //Animacion del player al saltar
        {
            animator.Play("Jump");

        }
    }
}
