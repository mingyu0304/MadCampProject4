using UnityEngine;
using System.Collections;
using Mirror;

public class AniController : NetworkBehaviour
{

    public Animator anim;
    public UnityEngine.UI.Text healthText;

    [SyncVar(hook = nameof(OnHealthChanged))]
    public int health = 100;
    [SyncVar] public float mp = 100;
    public float maxMp = 100;
    public float mpRecoveryRate = 5;
    public HPBar healthBar;
    public MPBar mpBar;
    private bool isInvincible = false;
    private float invincibleTime = 0.5f;


    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnHealthChanged(int oldHealth, int newHealth)
    {
        healthText.text = $"Health: {newHealth}";
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer) return;

        if (mp < maxMp)
        {
            mp += mpRecoveryRate * Time.deltaTime;
            if (mp > maxMp)
            {
                mp = maxMp;
            }
            mpBar.SetMP(mp);
        }

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
        healthBar.SetHealth(health);
        
    }
    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            health -= damage;
            mp -= damage;
            Debug.Log("Player health: " + health);
            Debug.Log("Player MP: " + mp);
            StartCoroutine(BecomeInvincible(invincibleTime));

            if (health <= 0)
            {
                Debug.Log("Player is defeated!");
            }
        }
    }
    IEnumerator BecomeInvincible(float time)
    {
        isInvincible = true;
        yield return new WaitForSeconds(time);
        isInvincible = false;
    }
}
