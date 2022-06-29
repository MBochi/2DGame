using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Vector2 moveDirection;
    public PlayerMovement target;

    // Update is called once per frame
    void Update(){
    }

    private void FixedUpdate() {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * movementSpeed;
        float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg -90f;
        rb.rotation = angle + 90f;
    }
}
