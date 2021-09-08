using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;

    public float moveSpeed = 3;

    void Start() {
        player = GameObject.FindWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collInfo) {
        
        if (collInfo.gameObject.tag == "Player") {
            Destroy(gameObject);
        }
    }
}