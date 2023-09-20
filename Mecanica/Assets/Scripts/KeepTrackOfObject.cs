using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTrackOfObject : MonoBehaviour
{

    [SerializeField]
    Vector3 _prevPos;
    [SerializeField]
    Vector3 _currentPos;
    // Start is called before the first frame update
    void Start()
    {
        _currentPos = transform.position;
        _currentPos = _prevPos;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        _prevPos = _currentPos;
        _currentPos = transform.position;
    }

    public Vector3 GetDisplacement()
    {
        return _currentPos - _prevPos;
    }
}
