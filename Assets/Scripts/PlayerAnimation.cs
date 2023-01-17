using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    public string boolName = "iswalking";
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool(boolName, true);

        }
        else
        {
            animator.SetBool(boolName, false);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.Play("Jump");

        }
    }
}
