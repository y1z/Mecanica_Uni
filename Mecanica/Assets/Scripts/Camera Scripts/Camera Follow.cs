using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public bool _followObject;
    public GameObject _objectToFollow;
    public Vector3 _maximumDistanceFromObject;

    [SerializeField]
    [Range(0.0f, 1.0f)]
    float _lerpValue;

    void Start()
    {
        
    }


    private void LateUpdate()
    {
        if (_followObject)
        {
            Vector3 position = _objectToFollow.transform.position;
            Vector3 final_position = Vector3.Lerp(position, position + _maximumDistanceFromObject, _lerpValue);
            transform.position = final_position;
        }

    }
}
