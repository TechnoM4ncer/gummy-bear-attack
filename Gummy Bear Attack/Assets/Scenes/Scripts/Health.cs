using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float hitPoints;

    // Start is called before the first frame update
    void Start()
    {
         hitPoints = 100f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter (Collision collInfo) {
        if (collInfo.gameObject.tag == "Enemy") {
            hitPoints -= 30;
        }
    }
}
