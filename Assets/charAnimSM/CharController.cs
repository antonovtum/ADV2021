using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Animator animator;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            //forward
            animator.SetFloat("vertical", Mathf.Lerp(animator.GetFloat("vertical"), 1, speed * Time.deltaTime));
        } else if (Input.GetKey(KeyCode.K))
        {
            //backwards
            animator.SetFloat("vertical", Mathf.Lerp(animator.GetFloat("vertical"), -1, speed * Time.deltaTime));
        }
        else
        {
            //stop
            animator.SetFloat("vertical", Mathf.Lerp(animator.GetFloat("vertical"), 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.J))
        {
            //left
            animator.SetFloat("horizontal", Mathf.Lerp(animator.GetFloat("horizontal"), -1, speed * Time.deltaTime));
        } else if (Input.GetKey(KeyCode.L))
        {
            //right
            animator.SetFloat("horizontal", Mathf.Lerp(animator.GetFloat("horizontal"), 1, speed * Time.deltaTime));
        }
        else
        {
            //stop
            animator.SetFloat("horizontal", Mathf.Lerp(animator.GetFloat("horizontal"), 0, speed * Time.deltaTime));
        }
    }
}
