using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    public Animator animator;
    public string boolParam;
    public float timeClosed;
    bool b = true;

    public AudioClip swaneeUp;
    public AudioClip swaneeDown;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent(typeof(AudioSource)) as AudioSource;
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
            if (b)
            {
                //previously was opened, time to close
                b = false;
                animator.SetBool(boolParam, b);

                //play closing clip
                audioSource.clip = swaneeDown;
                audioSource.pitch = 1.9f;
                audioSource.Play();
                //start timer to open again
                StartCoroutine(openTimeOut());

            }
        }
    }

    IEnumerator openTimeOut()
    {
        Debug.Log("started coroutine");
        yield return new WaitForSeconds(timeClosed);
        b = true;
        animator.SetBool(boolParam, b);
        //play opening clip
        audioSource.clip = swaneeUp;
        audioSource.pitch = 1;
        audioSource.Play();
        Debug.Log("ended coroutine");
    }
}
