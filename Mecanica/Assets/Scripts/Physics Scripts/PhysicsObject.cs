
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Used for overriding the default physcis of a object 
 */
public class PhysicsObject : MonoBehaviour
{

    private void Start()
    {
        _gameObject = this.gameObject;
    }


    private void FixedUpdate()
    {
        Vector3 position = _gameObject.transform.position;
        position = position + _force;
        _gameObject.transform.position = position;
    }

    [SerializeField]
    public float _mass;

    [SerializeField]  
    public Vector3 _force;

    GameObject _gameObject;

}
