using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 25f;
    public float xRange = 13f;
    public float zRange = 13f;
    Vector3 pos;
    Vector3 newPos;

    void Start () {
        
    }

    void FixedUpdate()
    {
        pos = transform.position;

        if (pos.x >= xRange) {
            newPos = new Vector3 ( -pos.x , pos.y , pos.z );
            transform.position = newPos;
        }
        if (pos.x <= -xRange) {
            newPos = new Vector3 ( -pos.x , pos.y , pos.z );
            transform.position = newPos;
        }
        if (pos.z >= zRange) {
            newPos = new Vector3 ( pos.x , pos.y , -pos.z );
            transform.position = newPos;
        }
        if (pos.z <= -zRange) {
            newPos = new Vector3 ( pos.x , pos.y , -pos.z );
            transform.position = newPos;
        }

        if (Input.GetKey("w")) {
            rb.AddForce( 0 , 0 , moveSpeed * Time.deltaTime , ForceMode.VelocityChange );
        }
        if (Input.GetKey("a")) {
            rb.AddForce( -moveSpeed * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange );
        }
        if (Input.GetKey("s")) {
            rb.AddForce( 0 , 0 , -moveSpeed * Time.deltaTime , ForceMode.VelocityChange );
        }
        if (Input.GetKey("d")) {
            rb.AddForce( moveSpeed * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange );
        }
    }
}
