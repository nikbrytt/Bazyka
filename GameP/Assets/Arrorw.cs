using UnityEngine;

public class Arrorw : MonoBehaviour
{
    Rigidbody2D rb;
    bool hasHit;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasHit = true; 
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }
}