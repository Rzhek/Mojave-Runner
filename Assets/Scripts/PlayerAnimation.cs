using UnityEngine;

// ToDo: This script requires the use of three components:
// Animator, Player, and Rigidbody2D
// Use the RequireComponent attribute to make sure the GameObject this script is attached to has these components.
[RequireComponent( typeof(Animator), typeof(Player), typeof(Rigidbody2D) )]
public class PlayerAnimation : MonoBehaviour
{
    // ToDo: This script needs a reference variable for each component:
    public Animator animator; 
    public Player player; 
    public Rigidbody2D rb;

    public GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // ToDo: Get a reference to each component using GetComponent
        animator = gameObject.GetComponent<Animator>();
        player = gameObject.GetComponent<Player>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ToDo: Set the animator bool parameter "Falling" to the value of player.isFalling.
        animator.SetBool("Falling", player.isFalling);
        // ToDo: Set the animator float parameter "YVelocity" to the value of rigidbody2D.velocity.y
        animator.SetFloat("YVelocity", rb.velocity.y);
    }

    public void Smoke()
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }

}