using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    public Animator animator;
    public string boolParam;
    bool b = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trigger") {
            //activate close animation
            Debug.Log("Collision detected");
            b = !b;
            animator.SetBool(boolParam, b);
        }
    }
}
