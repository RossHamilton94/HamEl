using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    public float speed = 12.0f;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        RotateByMovement();
    }

    void RotateByMovement()
    {
        float hSpeed = rb.velocity.x;
        float vSpeed = rb.velocity.y;

        if (hSpeed < 0.005f)
        {
            hSpeed = 0.0f;
        }

        if (vSpeed < 0.005f)
        {
            vSpeed = 0.0f;
        }

        float angleOfTravel = Mathf.Atan(hSpeed / vSpeed);
        angleOfTravel = angleOfTravel * Mathf.Rad2Deg;

        //transform.rotation = new Vector3(0.0f, angleOfTravel, 0.0f)

        transform.localEulerAngles = new Vector3(0.0f, angleOfTravel, 0.0f);
    }
}
