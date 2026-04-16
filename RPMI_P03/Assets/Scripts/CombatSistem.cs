using System.Collections;
using UnityEngine;

public class CombatSistem : MonoBehaviour
{
    public CardStats playerCard;
    public CardStats enemyCard;

    public Transform playerPos;
    public Transform enemyPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CardLocate();

        if (playerCard.GetAttack() >= enemyCard.GetAttack())
        {
            StartCoroutine(AttackPlayer());
        }
        else
        {
            StartCoroutine(AttackEnemy());
        }
    }

    private void CardLocate()
    {
        playerCard.transform.parent = playerPos;
        playerCard.transform.localPosition = Vector3.zero;
        enemyCard.transform.parent = enemyPos;
        enemyCard.transform.localPosition = Vector3.zero;
    }

    private IEnumerator AttackPlayer()
    {
        yield return new WaitForSeconds(1);
        Destroy(enemyCard.gameObject);
    }

    private IEnumerator AttackEnemy()
    {
        yield return new WaitForSeconds(1);
        Destroy(playerCard.gameObject);
    }
}
