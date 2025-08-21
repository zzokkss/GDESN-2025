using UnityEngine;

public class Enemy5 : MonoBehaviour
{
    [SerializeField] int hp;

    public void TakeDamage(int damageAmount, int id, Player5 player)
    {
        hp -= damageAmount;
        if (hp <= 0)
        {
            player.RemoveEnemy(id);
            Destroy(gameObject);
        }        
    }
}
