using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    KillCounter killCounter;

    private void Start() {
        killCounter = GameObject.Find("KillCounter").GetComponent<KillCounter>();
    }
    public void TakeDamage(int damage){
        health -= damage;
        if(health <= 0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
        killCounter.AddKill();
    }
}
