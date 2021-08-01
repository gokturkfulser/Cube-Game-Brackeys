using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float yForce = 1000f;
    public float xForce = 500f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, yForce * Time.deltaTime);
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -0.5f)
        {
            FindObjectOfType<gameManager>().gameOver();
        }
    }
}
