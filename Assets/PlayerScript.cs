using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
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
        }

    }
    public void HealEnemy()
    {
        hp += 5;
        healthText.text = "HP: " + hp.ToString();
    }
}
