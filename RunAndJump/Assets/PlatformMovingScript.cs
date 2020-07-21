using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovingScript : MonoBehaviour {

    public float speed;
    public Transform endPoint;
    Vector3 startPoint;
    Rigidbody2D rb;
    public bool Vertical = true;
    public bool ClassicDirection = true;

    float currentSpeed;

    void Start() {
        startPoint = transform.position;
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = speed;
    }

    void FixedUpdate() {
        if (this.ClassicDirection)
            this.VelocityClassicDirection();
        else {
            this.VelocityAnotherDirection();
        }
    }

    private void VelocityAnotherDirection() {
        if (this.Vertical) {
            if (transform.position.y < endPoint.position.y)
                currentSpeed = speed;

            if (transform.position.y > startPoint.y)
                currentSpeed = -speed;
            rb.velocity = new Vector3(0, currentSpeed, 0);
        } else {
            if (transform.position.x < endPoint.position.x)
                currentSpeed = -speed;

            if (transform.position.x > startPoint.x)
                currentSpeed = speed;
            rb.velocity = new Vector3(currentSpeed, 0, 0);
        }
    }

    private void VelocityClassicDirection() {
        if (this.Vertical) {
            if (transform.position.y > endPoint.position.y)
                currentSpeed = -speed;

            if (transform.position.y < startPoint.y)
                currentSpeed = speed;
            rb.velocity = new Vector3(0, currentSpeed, 0);
        } else {
            if (transform.position.x > endPoint.position.x)
                currentSpeed = -speed;

            if (transform.position.x < startPoint.x)
                currentSpeed = speed;
            rb.velocity = new Vector3(currentSpeed, 0, 0);
        }
    }
}