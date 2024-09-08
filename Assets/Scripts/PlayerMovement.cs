using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int MaxSpeed = 9;
    bool alive = true;

    public float speed = 5;
    [SerializeField] Rigidbody rb;

    public float horizontalInitiator;
    [SerializeField] float horizontalMultiplier = 2;

    public float verticalInitiator;
    public float speedIncreasePerPoint = 0.1f;

    public float factor;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * verticalInitiator * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInitiator * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        accelerate();
        brake();
    }

    private void Update()
    {
        horizontalInitiator = Input.GetAxis("Horizontal");
        stationary();

        if (transform.position.y < -5)
        {
            Die();
        }

    }

    public void Die()
    {
        alive = false;
        // Restart the game
        Invoke("Restart", 1);
    }

    void Restart()
    {
        SceneManager.LoadScene("Restart");
    }
    private void accelerate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            verticalInitiator = verticalInitiator + factor;

            if (verticalInitiator >= MaxSpeed)
            {
                verticalInitiator = MaxSpeed;
            }
        }
        else
        {
            verticalInitiator -= factor * 3;

            if (verticalInitiator <= 0)
            {
                verticalInitiator = 0;
            }
        }
    }

    private void brake()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            verticalInitiator -= factor * 3;

            if (verticalInitiator <= 0)
            {
                verticalInitiator = 0;
            }

        }
    }

    private void stationary()
    {
        if(verticalInitiator == 0)
        {
            horizontalInitiator = 0;
        }
        else
        {
            horizontalInitiator = Input.GetAxis("Horizontal");
        }
    }

   
}