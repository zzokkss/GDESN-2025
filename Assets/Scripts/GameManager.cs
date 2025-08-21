using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    int score;
    int money;
    int apples;

    //References
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI applesText;

    public void AddScore()
    {
        score += 1;
        Debug.Log("score:" + score);
        if(score >= 10)
        {
            Debug.Log("Yay");
        }
    }
    public void AddMoney()
    {
        money += 1;
        moneyText.text = "Money: " + money.ToString();
    }
    public void BuyApple()
    {
        if (money >= 5)
        {
            Debug.Log("Bought Apple");
            apples += 1;
            money -= 5;
            applesText.text = "Apples: " + apples.ToString();
            moneyText.text = "Money: " + money.ToString();
        }
        else
        {
            Debug.Log("Too poor");
        }
    }

}
