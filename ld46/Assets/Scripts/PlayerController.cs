using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float xSpeed = 100.0f;
    public float ySpeed = 100.0f;
    public Rigidbody2D rb;
    private bool isJump;

    public AudioClip collect;
    public static AudioClip die;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown("left"))
        {
            rb.AddForce(Vector2.left * xSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown("right"))
        {
            rb.AddForce(Vector2.right * xSpeed, ForceMode2D.Impulse);
        }


        isJump = Input.GetKeyDown("up") || Input.GetButtonDown("Jump");
        if(isJump)
        {
            rb.AddForce(Vector2.up * ySpeed, ForceMode2D.Impulse);
        }
    }

}
