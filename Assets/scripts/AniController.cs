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

        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetBool("Hook", true);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Uppercut", true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("Jab", true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("Straight", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("Ducking", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Sway", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("Weabing", true);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            anim.SetBool("BodyBlow", true);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("HeadGaurd", !anim.GetBool("HeadGaurd"));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Punch");
        Opponent opponent = other.GetComponent<Opponent>();
        if (opponent != null)
        {
            opponent.TakeDamage(10);
        }
    }

}
