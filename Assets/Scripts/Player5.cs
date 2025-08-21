using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework.Constraints;

public class Player5 : MonoBehaviour
{

    [SerializeField] float speed;
    Rigidbody2D rb;

    [SerializeField] List<Enemy5> enemy = new List<Enemy5>();
    [SerializeField] int damageAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = enemy.Count - 1; i>=0; i--)
            {
                enemy[i].TakeDamage(1, i, this);
            }           
        }        
    }

    public void RemoveEnemy(int id)
    {
        enemy.RemoveAt(id);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 moveDirection = (Vector2.right * horizontal) + (Vector2.up * vertical);
        moveDirection *= speed * Time.deltaTime;

        rb.linearVelocity = moveDirection;
    }
}
