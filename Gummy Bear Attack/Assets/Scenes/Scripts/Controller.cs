using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 25f;
    void FixedUpdate()
    {
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
