using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
    {

    public Rigidbody2D rb;
    public float jumpHeight = 10f;
    public bool isFalling = true;
    public Animator animator;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();

    }

    void Update()
    {
        if (!isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
            }
        } else if (Input.GetKeyDown(KeyCode.S)) {
            rb.AddForce(-transform.up * jumpHeight * 2, ForceMode2D.Impulse);
            Invoke("StartRun", .4f);

        }
    } 
    
    private void StartRun() {
        if (!isFalling) {
            animator.Play("TurtleRun");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
    }

}
