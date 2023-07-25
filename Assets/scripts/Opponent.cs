using UnityEngine;

public class Opponent : MonoBehaviour
{
    public int health = 100;
    public HPBar healthBar;
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Opponent health: " + health);
        healthBar.SetHealth(health);
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Opponent is defeated!");

        // 게임 오버시 기타 처리
        // Destroy(gameObject); // 예를 들어, 게임 오브젝트를 파괴하는 것이 가능합니다.
        // 하지만 이 경우, 단순히 오브젝트를 파괴하는 대신 다른 행동을 원할 수도 있습니다. 
        // 예를 들어, 게임이 끝났음을 알리는 UI를 보여주거나, 적의 '사망' 애니메이션을 재생시킬 수 있습니다.
    }
}
