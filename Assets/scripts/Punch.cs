using System.Collections;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public Collider punchCollider;
    public int punchDamage = 10;
    public float punchDuration = 0.5f;

    bool isHit = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.R))
            StartCoroutine(DoPunch());

    }

    IEnumerator DoPunch()
    {
        punchCollider.enabled = true;
        yield return new WaitForSeconds(punchDuration);
        punchCollider.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Opponent" && !isHit)
        {
            Opponent opponent = other.GetComponent<Opponent>();
            if (opponent != null)
            {
                opponent.TakeDamage(punchDamage);
                isHit = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Opponent"))
        {
            isHit = false;

        }
    }
}
