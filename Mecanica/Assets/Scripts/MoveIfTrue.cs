using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIfTrue : MonoBehaviour
{

    public bool _doesMove = true;
    public Vector3 _directionOfMovement = Vector3.left;
    public float _speed = 1.0f;


    private void FixedUpdate()
    {
        if (_doesMove)
        {
            transform.position += _directionOfMovement * _speed;
        }

    }
}
