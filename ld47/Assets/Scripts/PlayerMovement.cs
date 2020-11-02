using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 1f;
    public float maxSpeed = 50f;
    public float xMin = -10f;
    public float xMax = 10f;
    public int wrappedRight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Wrap();
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (rb.velocity.x < maxSpeed)
            {
                rb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Impulse);
            }
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("FIRE!");
        }
    }

    private void Wrap()
    {
        if(transform.position.x > xMax)
        {
            transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
            wrappedRight++;
        }

        if (transform.position.x < xMin)
        {
            Camera.main.transform.position = new Vector3(-36, 10, -20);
            Console.WriteLine($"Player was trolled {wrappedRight} times!");
        }

    }
}
