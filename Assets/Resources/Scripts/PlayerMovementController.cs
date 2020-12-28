using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float defaultMovementSpeed, extraAccelerationSpeed, breakingFactor, defaultTurnSpeed;


    private void FixedUpdate()
    {

        float movementSpeed = this.defaultMovementSpeed;


        // Boost
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            movementSpeed += this.extraAccelerationSpeed;
        }
        // Slow Down
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movementSpeed *= this.breakingFactor;
        }


        this.transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);


        // Turn Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.forward, this.defaultTurnSpeed * Time.deltaTime);
        }
        // Turn Right
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(-Vector3.forward, this.defaultTurnSpeed * Time.deltaTime);
        }

    }



}
