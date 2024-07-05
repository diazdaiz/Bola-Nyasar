using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour {
    [SerializeField]
    private GameObject _destroyedObject;

    private void Start() {
        Destroy(_destroyedObject);
    }
}
