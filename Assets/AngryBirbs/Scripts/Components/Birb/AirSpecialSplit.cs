using UnityEngine;

public class AirSpecialSplit : MonoBehaviour, IAirSpecial
{
    public float SplitAngleInDegrees = 10;

    public void ExecuteAirSpecial()
    {
        GameObject clone1 = Instantiate(this.gameObject);
        GameObject clone2 = Instantiate(this.gameObject);

        Rigidbody2D rb1 = clone1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = clone2.GetComponent<Rigidbody2D>();



        rb1.AddForce(transform.right, ForceMode2D.Impulse);
        rb2.AddForce(transform.right, ForceMode2D.Impulse);

    }
}
