using UnityEngine;

public class SetHookFalse : MonoBehaviour
{
    public Animator anim;

    public void setHookFalse()
    {
        anim.SetBool("Hook", false);
    }

}
