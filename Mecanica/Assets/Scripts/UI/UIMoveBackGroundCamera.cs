using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMoveBackGroundCamera : MonoBehaviour
{
    [SerializeField]
    RawImage _image;
    [SerializeField]
    MainCameraScript _cameraRef;

    // Start is called before the first frame update
    void Start()
    {
        _cameraRef = FindObjectOfType<MainCameraScript>();

    }

    private void Update()
    {
        Vector3 displacement = _cameraRef._keepTrackOfObject.GetDisplacement();

        _image.uvRect = new Rect(_image.uvRect.position + new Vector2(displacement.x, displacement.y) * Time.deltaTime, _image.uvRect.size);
    }

}
