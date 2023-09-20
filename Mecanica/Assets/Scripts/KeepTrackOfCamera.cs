using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTrackOfCamera : MonoBehaviour
{

    [SerializeField]
    Vector3 _PrevPos;
    [SerializeField]
    Vector3 _CurrentPos;
    // Start is called before the first frame update
    void Start()
    {
        _CurrentPos = transform.position;
        _CurrentPos = _PrevPos;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        _PrevPos = _CurrentPos;
        _CurrentPos = transform.position;
    }

    public Vector3 GetDisplacement()
    {
        return _CurrentPos - _PrevPos;
    }
}
