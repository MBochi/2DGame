using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float respawnTime = 1.0f;

    private void Start() {
        StartCoroutine(waitTimer());
    }

    void Shoot(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    
    IEnumerator waitTimer(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            Shoot();
        }
    }
}
