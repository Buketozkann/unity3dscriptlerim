//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class movement : MonoBehaviour
{

    private Rigidbody capsule;
    public Vector2 moveVal;
    public float moveSpeed = 10;


    private void Awake()
    {
        capsule = GetComponent<Rigidbody>();

    }

    public void Movement(InputAction.CallbackContext value)
    {
        if(value.performed == true)
        {
            //Debug.Log("Performed");
            moveVal = value.ReadValue<Vector2>();
            //Debug.Log(moveVal.x + " " + moveVal.y);
            //capsule.AddForce(new Vector3(x: moveVal.x * moveSpeed, y: 0f, z: moveVal.y * moveSpeed), ForceMode.Impulse);
        }

        if(value.canceled)
        {
            moveVal = value.ReadValue<Vector2>(); 
        }


    }


}
