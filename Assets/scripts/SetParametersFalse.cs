using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParametersFalse : MonoBehaviour
{
    public Animator anim;
    public void setParametersFalse()
    {
        anim.SetBool("Hook", false);
        anim.SetBool("Jab", false);
        anim.SetBool("Uppercut", false);
        anim.SetBool("BodyBlow", false);
        anim.SetBool("Straight", false);
        anim.SetBool("Weabing", false);
        anim.SetBool("Ducking", false);
        anim.SetBool("Sway", false);
    }
}
