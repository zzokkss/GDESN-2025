using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyScript : MonoBehaviour
{

    //Variables
    [SerializeField] int hp;

    //References
    [SerializeField] TextMeshProUGUI healthText;

    public void TakeDamage()
    {
        hp -= 1;
        healthText.text = "HP: " + hp.ToString();
        if (hp <= 0)
        {
            Debug.Log("get pwned");
            hp = 0;
        }
        if (hp <= -1)
        {
            hp = 0;
        }

    }
    public void HealEnemy()
    {
        hp += 5;
        healthText.text = "HP: " + hp.ToString();
    }

}
