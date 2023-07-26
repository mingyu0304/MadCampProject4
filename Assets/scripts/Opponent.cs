using System.Collections;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    public int health = 100;
    public float mp = 100;
    public float maxMp = 100;
    public float mpRecoveryRate = 5;
    public HPBar healthBar;
    public MPBar mpBar;
    private bool isInvincible = false;
    private float invincibleTime = 0.3f;

    public Material mat;

    private void Update()
    {
        // MP 회복
        if (mp < maxMp)
        {
            mp += mpRecoveryRate * Time.deltaTime; // deltaTime을 사용하여 프레임-초 단위로 변환
            if (mp > maxMp)
            {
                mp = maxMp;
            }
            mpBar.SetMP(mp);
        }
    }
    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            health -= damage;
            mp -= damage;
            Debug.Log("Opponent health: " + health);
            Debug.Log("Opponent MP: " + mp);
            healthBar.SetHealth(health);
            mpBar.SetMP(mp);
            StartCoroutine(ChangeColor());
            if (health <= 0)
            {
                Debug.Log("Opponent is defeated!");
            }
            StartCoroutine(BecomeInvincible(invincibleTime));
        }
    }

    IEnumerator BecomeInvincible(float time)
    {
        isInvincible = true;
        yield return new WaitForSeconds(time);
        isInvincible = false;
    }
    IEnumerator ChangeColor()
    {
        mat.color = Color.red;
        yield return new WaitForSeconds(0.3f);
        mat.color = new Color(19 / 255f, 68 / 255f, 87 / 255f);
    }


}
