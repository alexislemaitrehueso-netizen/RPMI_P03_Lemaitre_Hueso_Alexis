using UnityEngine;

public class CardStats : MonoBehaviour
{
    [SerializeField, Tooltip("Ataque de la Carta"), Range(1,9)]
    private int attack;
    [SerializeField, Tooltip("Defensa de la Carta"), Range(1, 9)]
    private int defense;
    [SerializeField, Tooltip("Vida de la Carta"), Range(1, 9)]
    private int live;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
