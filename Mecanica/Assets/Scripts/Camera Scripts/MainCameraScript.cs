using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public KeepTrackOfObject _keepTrackOfObject;
    // Start is called before the first frame update
    void Start()
    {
        _keepTrackOfObject = GetComponent<KeepTrackOfObject>();
    }

}
