using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RacketController : MonoBehaviour
{

    public float speed;
    public KeyCode up;
    public KeyCode down;
    public bool isPlayer = true;

    private Rigidbody rb;

    public Transform ball;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        // this.ball = GameObject.FindGameObjectWithTag("ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isPlayer)
        {
            MoveByPlayer();
        } else
        {
            MoveByComputer();
        }
        
    }

    private void MoveByPlayer()
    {
        bool pressedUp = Input.GetKey(this.up);
        bool pressedDown = Input.GetKey(this.down);

        if (pressedUp)
        {
            this.rb.velocity = Vector3.forward * speed;
        }

        if (pressedDown)
        {
            this.rb.velocity = Vector3.back * speed;
        }

        if (!pressedUp && !pressedDown)
        {
            this.rb.velocity = Vector3.zero;
        }
    }

    private void MoveByComputer()
    {
        Debug.Log(ball);
        if (this.ball.position.z > transform.position.z)
        {
            this.rb.velocity = Vector3.forward * speed;
        } else if (this.ball.position.z < transform.position.z)
        {
            this.rb.velocity = Vector3.back * speed;
        } else
        {
            this.rb.velocity = Vector3.zero;
        }
    }
}
