using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    private void Start() {
        Debug.Log("Running");
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }

    private void SpawnEnemy(){
        GameObject clone = Instantiate(enemy) as GameObject;
        clone.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
    }
}

