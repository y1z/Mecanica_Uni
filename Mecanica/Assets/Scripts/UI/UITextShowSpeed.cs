using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class UITextShowSpeed : MonoBehaviour
{

    KeepTrackOfObject _objectRef;
    [SerializeField]
    GameObject _go;
    [SerializeField]
    Text _text;

    void Start()
    {
        Assert.IsNotNull(_go, "Attach a game object to the script please");
        _objectRef = _go.AddComponent<KeepTrackOfObject>();
    }

    private void FixedUpdate()
    {
        Vector3 displacement = _objectRef.GetDisplacement();
        _text.text = "Speed = " + displacement;
    }
}
