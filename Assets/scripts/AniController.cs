using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniController : MonoBehaviour
{

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.Q) && !stateInfo.IsName("Hook"))
        {
            anim.SetBool("Hook", true);
        }
        if (Input.GetKeyDown(KeyCode.W) && !stateInfo.IsName("Uppercut"))
        {
            anim.SetBool("Uppercut", true);
        }
        if (Input.GetKeyDown(KeyCode.R) && !stateInfo.IsName("Jab"))
        {
            anim.SetBool("Jab", true);
        }
        if (Input.GetKeyDown(KeyCode.E) && !stateInfo.IsName("Straight"))
        {
            anim.SetBool("Straight", true);
        }
    }
}
