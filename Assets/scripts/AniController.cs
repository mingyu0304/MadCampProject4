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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("Hook");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Punching(1)");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("Punching");
        }
    }
}
