using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 /**
  * Overrides the default physics of Unity
  */
public class PhysicsEngine : MonoBehaviour
{
    [SerializeField]
    List<Vector3> _listOfForces;
    private List<PhysicsObject> _ListOfObjects;

    [SerializeField]
    Vector3 _inspectorVector;


    void Start()
    {
        _ListOfObjects = new List<PhysicsObject>();
        var temp = FindObjectsOfType<PhysicsObject>();
        _ListOfObjects.AddRange(temp);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddForceToObjects();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            print(_ListOfObjects[0]._force);
        }
        
    }

    public void AddForceToObjects()
    {
        Vector3 forceSumation = GetSumationOfForces();
        foreach(var physicsObject in _ListOfObjects)
        {
            physicsObject._force += forceSumation;

        }

    }

    public void AddPhysicsObjectData(PhysicsObject physicsObject)
    {
        _ListOfObjects.Add(physicsObject);
    }

    public void AddNewForceToList(Vector3 force)
    {
        _listOfForces.Add(force);
    }


    [ContextMenu("Add New Force To List Vector")]
    void AddNewForceToListInspector()
    {
        AddNewForceToList(_inspectorVector);
    }

    Vector3 GetSumationOfForces()
    {
        Vector3 result = Vector3.zero;
        foreach(Vector3 vec in _listOfForces){
            result += vec;
        }
        return result;
    }

}
