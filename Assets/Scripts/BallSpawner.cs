using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject _spawnedObject;
    [SerializeField]
    private Transform _spawnLocationTransform;

    void Start() {
        Instantiate(_spawnedObject, _spawnLocationTransform.position, _spawnLocationTransform.rotation);
    }
}
