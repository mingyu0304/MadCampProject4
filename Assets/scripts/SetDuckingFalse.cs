using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDuckingFalse : MonoBehaviour
{
    public Animator anim;
    public void setDuckingFalse()
    {
        anim.SetBool("Ducking", false);
    }
}
