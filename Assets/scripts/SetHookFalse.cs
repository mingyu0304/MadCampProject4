using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHookFalse : MonoBehaviour
{
    public Animator anim;
    public void setHookFalse()
    {
        anim.SetBool("Hook", false);
    }
}
