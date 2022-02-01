using UnityEngine;

public class AirSpecialBounce : MonoBehaviour, IAirSpecial
{
    [Range( 0, 1 )]
    public float SlowDownFactor = 1;

    public void ExecuteAirSpecial()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 bounceForce;
        bounceForce.x = rb.velocity.x - SlowDownFactor;
        bounceForce.y = -rb.velocity.y;

        rb.velocity = (Vector2.zero);
        rb.AddForce(bounceForce, ForceMode2D.Impulse);
    }
}
