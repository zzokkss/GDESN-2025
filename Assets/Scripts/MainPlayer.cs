using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPlayer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Death"))
        {
            SceneManager.LoadScene("ENDMENU");
        }
        
    }
}
