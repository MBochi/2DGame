using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 30;
    public float bulletForce = 20f;
    public Rigidbody2D rb;    
    public Transform firePoint;  
        
    void Start() {
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D (Collider2D collider) {
        //Debug.Log(collider.name);
        Enemy enemy = collider.GetComponent<Enemy>();
        if(enemy != null){
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        Player player = collider.GetComponent<Player>();
        if(player != null){
            player.TakeDamage(damage);
            Destroy(gameObject);
        }  
    }
}
