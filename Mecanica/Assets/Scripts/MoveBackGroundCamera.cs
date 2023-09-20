using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBackGroundCamera : MonoBehaviour
{
    [SerializeField]
    RawImage _Image;
    KeepTrackOfCamera _cameraRef;

    // Start is called before the first frame update
    void Start()
    {
        _cameraRef = FindObjectOfType<KeepTrackOfCamera>();

    }

    private void Update()
    {
        Vector3 displacement = _cameraRef.GetDisplacement();

        _Image.uvRect = new Rect(_Image.uvRect.position + new Vector2(displacement.x, displacement.y) * Time.deltaTime, _Image.uvRect.size);
    }

}
