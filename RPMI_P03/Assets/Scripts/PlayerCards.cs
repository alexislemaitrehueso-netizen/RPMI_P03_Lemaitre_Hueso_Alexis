using Unity.Multiplayer.Center.Common;
using UnityEngine;

public class PlayerCards : MonoBehaviour
{
    public AudioSource cogerAS;
    public AudioSource soltarAS;

    public GameObject combatSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sortingLayerName = "Selected Cards";
        GetComponent<BoxCollider2D>().enabled = false;

        cogerAS.pitch = Random.Range(0.95f, 1.05f);
        cogerAS.Play();

    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sortingLayerName = "Default";
        GetComponent<BoxCollider2D>().enabled = true;

        soltarAS.pitch = Random.Range(0.95f, 1.05f);
        soltarAS.Play();
       
        
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        transform.position = newPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (!collision.gameObject.GetComponent<EnemyCards>().inCombat)
            {
                GameObject cm = Instantiate(combatSystem, transform.position, Quaternion.identity);
                cm.GetComponent<CombatSistem>().playerCard = GetComponent<CardStats>();
                cm.GetComponent<CombatSistem>().enemyCard = collision.gameObject.GetComponent<CardStats>();
            }
        }
    }
}
