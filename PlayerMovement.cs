using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;

    public float ForwardSpeed = 2000f;
    public float MovementSpeed = 500f;
    public float jumpHeight = 100f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(MovementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-MovementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(0, jumpHeight * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
