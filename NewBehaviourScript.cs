//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class NewBehaviourScript : MonoBehaviour
{

    private movement _input;
    private CharacterController _controller;
    [SerializeField] private float fraction;


    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<movement>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _controller.Move(new Vector3(x:(_input.moveVal.x * _input.moveSpeed)/fraction, y: 0f, z:(_input.moveVal.y * _input.moveSpeed)/fraction));

    }
  
}
