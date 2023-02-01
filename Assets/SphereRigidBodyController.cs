using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRigidBodyController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    private Rigidbody rb;
    private Vector3 input;
    private bool jumping;
    private float score;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            score++;
        }
    }

    private void Jump() 
    {
        if(jumping)
        {
            jumping = false;
            rb.AddForce(speed * Vector3.up, ForceMode.Impulse);
        }


    }

    private void FixedUpdate()
    {
        rb.velocity = (rb.velocity.y * Vector3.up) + (input * speed);
        Jump();

    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
        }
    }
}
