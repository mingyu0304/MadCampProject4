using UnityEngine;

public class SetUppercutFalse : MonoBehaviour
{
    public Animator anim;

    public void setUppercutFalse()
    {
        anim.SetBool("Uppercut", false);
    }

}
