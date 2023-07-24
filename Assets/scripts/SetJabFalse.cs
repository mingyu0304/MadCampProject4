using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetJabFalse : MonoBehaviour
{
    public Animator anim;
    public void setJabFalse()
    {
        anim.SetBool("Jab", false);
    }
}
