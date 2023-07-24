using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStraightFalse : MonoBehaviour
{
    public Animator anim;
    public void setStraightFalse()
    {
        anim.SetBool("Straight", false);
    }
}
