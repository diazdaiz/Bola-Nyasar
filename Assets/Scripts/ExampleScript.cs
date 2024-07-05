using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour {
    [SerializeField]
    private GameObject _square;
    [SerializeField]
    private Transform _squareTransform;

    private void Awake() {
        Debug.Log("Awake");
    }

    private void OnEnable() {
        Debug.Log("On Enable");
    }

    void Start() {
        Debug.Log("Start");
        Debug.Log(_square.name);
        Debug.Log(_square.tag);
        Debug.Log(_square.layer);
        Debug.Log(_square.activeInHierarchy);

        _square.name = "Kotak";
        //menonaktifkan
        _square.SetActive(false);
        //mengaktifkan
        _square.SetActive(true);

        Debug.Log(_squareTransform.position);
        Debug.Log(_squareTransform.rotation);
        Debug.Log(_squareTransform.localScale);

        Vector3 newScale = new Vector3(2, 2, 2);
        _squareTransform.localScale = newScale;

        //cara 1
        //Vector3 newPosition = new Vector3(5, 0, 0);
        //_squareTransform.position = newPosition;
        //Quaternion newRotation = Quaternion.Euler(0, 0, 45);
        //_squareTransform.rotation = newRotation;

        //cara 2
        _squareTransform.Translate(5, 0, 0);
        _squareTransform.Rotate(0, 0, 45);
    }

    void Update() {
        Debug.Log("update");
    }

    private void LateUpdate() {
        Debug.Log("Late Update");
    }


    private void OnDisable() {
        Debug.Log("On Disable");
    }

    private void OnDestroy() {
        Debug.Log("On Destroy");
    }

    private void OnApplicationQuit() {
        Debug.Log("On Application Quit");
    }

}
