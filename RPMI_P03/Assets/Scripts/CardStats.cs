using UnityEngine;

public class CardStats : MonoBehaviour
{
    [SerializeField, Tooltip("Ataque de la Carta"), Range(1,9)]
    private int attack;
    [SerializeField, Tooltip("Defensa de la Carta"), Range(1, 9)]
    private int defense;
    [SerializeField, Tooltip("Vida de la Carta"), Range(1, 9)]
    private int live;

    public int GetAttack()
    {
        return attack;
    }

    public int GetDefense() 
    { 
        return defense;
    }

    public int GetLive() 
    {
        return live;
    }
}
