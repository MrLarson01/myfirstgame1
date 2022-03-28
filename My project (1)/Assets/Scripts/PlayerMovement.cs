using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float downwardForce = 2000f;

    //FixedUpdate is used because it works better then just Update, it works better with physics

    void FixedUpdate()
    {     //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);



        if (Input.GetKey("d") )
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("s"))
        {

            rb.AddForce(0, 0, downwardForce * Time.deltaTime);

        }


       if (rb.position.y < -5f)

        {

            FindObjectOfType<GameManager>().EndGame();

        }

    }
}
