using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 1f;
    public float xRange = 15f;
    public float zRange = 15f;
    public float fireElapsed = 0f;
    public float fireDelay = 5f;
    Vector3 pos;
    Vector3 newPos;
    Vector3 aim;
    public GameObject projectile;

    void FixedUpdate()
    {

        PlayerMovement();

        BorderTeleport();

        fireElapsed += Time.deltaTime;

        if (Input.GetKey("space") && fireElapsed >= fireDelay) {
            fireElapsed = 0f;
            Fire();
        }
    }

    void PlayerMovement() {
         float moveHorizontal = Input.GetAxisRaw ("Horizontal");
         float moveVertical = Input.GetAxisRaw ("Vertical");

         Vector3 movement = new Vector3(moveHorizontal, 0.0f , moveVertical);

         if (movement != Vector3.zero) {
         aim = movement;
         }

         if (movement != Vector3.zero) {
             transform.rotation = Quaternion.LookRotation(movement);
         }

         transform.Translate (movement * moveSpeed * Time.deltaTime, Space.World);

    }

    void BorderTeleport() {
        pos = transform.position;

        if (pos.x >= xRange) {
            newPos = new Vector3 ( -pos.x + .1f , pos.y , pos.z );
            transform.position = newPos;
        }

        if (pos.x <= -xRange) {
            newPos = new Vector3 ( -pos.x - .1f , pos.y , pos.z );
            transform.position = newPos;
        }

        if (pos.z >= zRange) {
            newPos = new Vector3 ( pos.x , pos.y , -pos.z + .1f );
            transform.position = newPos;
        }

        if (pos.z <= -zRange) {
            newPos = new Vector3 ( pos.x , pos.y , -pos.z - .1f );
            transform.position = newPos;
        }
    }

    void Fire() {
        GameObject bullet = Instantiate(projectile, transform.position + aim.normalized , Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(new Vector3(0 , 0 , 50 )));
    }
}