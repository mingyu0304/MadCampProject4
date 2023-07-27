using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public Opponent opponent;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
    {
        opponent.TakeDamage(10);
    }
    }
}
