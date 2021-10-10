
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carDriveScript : MonoBehaviour
{

    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float steerSpeed = 150f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 35f;
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        if (moveAmount != 0)
        {
            transform.Rotate(0, 0, -steerAmount);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost")
        {
            moveSpeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
}
