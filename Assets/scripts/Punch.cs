using System.Collections;
using UnityEngine;
using Mirror;

public class Punch : NetworkBehaviour
{
    public Collider punchCollider;
    public int punchDamage = 10;
    public float punchDuration = 0.5f;

    bool isHit = false;

    void Update()
    {
        if (!isLocalPlayer) return;
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
        Debug.Log("punch");
        NetworkIdentity networkIdentity = other.GetComponentInParent<NetworkIdentity>();
        if (networkIdentity == null || networkIdentity.connectionToClient == null)
        {
            // Collider에 NetworkIdentity가 없거나, 네트워크에 연결되지 않았다면 충돌 처리를 하지 않습니다.
            return;
        }
        if (NetworkServer.active && networkIdentity.connectionToClient.connectionId == NetworkServer.localConnection.connectionId)
        {
            // 충돌한 객체가 로컬 플레이어면 데미지 처리를 하지 않습니다.
            return;
        }
        if (other.gameObject.tag == "Player" && !isHit)
        {
            AniController player = other.GetComponentInParent<AniController>();
            Debug.Log("opponent");
            if (player != null)
            {
                Debug.Log("not null");
                CmdDealDamage(player.gameObject);
                isHit = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isHit = false;
        }
    }

    [Command]
    void CmdDealDamage(GameObject player)
    {
        player.GetComponent<AniController>().TakeDamage(punchDamage);
    }
}
