using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float ballSpeed = 200.0f;

    private Rigidbody2D rb2D;

    // Its connected to Script Points
    //public bool pointToPlayer = false;
    //public bool pointToComputer = false;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetTheBallPosition();
        AddStartingForce();
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerField")
        {
            pointToComputer = true;
        }
        else if (collision.tag == "ComputerField")
        {
            pointToPlayer = true;
        }
    }
    */
    public void AddStartingForce()
    {
        Vector2 direction;

        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        direction = new Vector2(x, y);

        rb2D.AddForce(direction * ballSpeed);
    }

    public void AddForce(Vector2 force)
    {
        rb2D.AddForce(force);
    }
    public void ResetTheBallPosition()
    {
        rb2D.position = Vector2.zero;
        rb2D.velocity = Vector2.zero;
    }
}
