using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb2D;
    public float speed = 10f;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        rb2D.position = new Vector2(rb2D.position.x, 0.0f);
        rb2D.velocity = Vector2.zero;
    }
}
