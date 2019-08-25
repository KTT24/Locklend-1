using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed;

    // Update is called once per frame
    private void Update()
    {


        if (Input.GetKeyDown("w"))
        {

            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;

        }

    }

     
}
