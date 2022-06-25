using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 100;
    public Text healthText;

    private void Start() {
        healthText = GameObject.Find("HealthCounter").GetComponent<Text>();
    }
    public void TakeDamage(int damage){
        health -= damage;
        healthText.text = health.ToString();
        if(health <= 0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);    
    }
}
