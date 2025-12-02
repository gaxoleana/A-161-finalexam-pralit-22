using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float jumpForce = 10f;
    private bool isInvulnerable = false;

    [SerializeField] public float MoveSpeed { get; private set; }
    [SerializeField] public bool IsInvulnerable { get; private set; }


    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {

    }

    public void SetInvulnerability(bool isEnable)
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void Move()
    {
        
    }

    public void Jump()
    {

    }
}
