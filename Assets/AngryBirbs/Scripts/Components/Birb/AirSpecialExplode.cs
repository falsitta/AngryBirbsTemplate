using UnityEngine;

public class AirSpecialExplode : MonoBehaviour, IAirSpecial
{
    [Range( 0, 5 )]
    public float BlastRadius = 2;

    public void ExecuteAirSpecial()
    {
        CircleCollider2D cc = GetComponent<CircleCollider2D>();
        cc.radius = BlastRadius;
    }
}
