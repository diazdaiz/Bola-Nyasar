using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _spawnedObject;

    void Start()
    {
        Instantiate(_spawnedObject);

        Vector3 spawnPosition = new Vector3(2, 2, 0);
        Quaternion spawnRotation = Quaternion.Euler(0, 0, 45);
        Instantiate(_spawnedObject, spawnPosition, spawnRotation);

        Debug.Log("test");
    }

    void Update()
    {

    }
}
