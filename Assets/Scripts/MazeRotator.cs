using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MazeRotator : MonoBehaviour {
    [SerializeField]
    private Transform _mazeTransform;
    int value;

    public void StartRotateLeft() {
        value = -1;
        Debug.Log("left");
    }

    public void StopRotateLeft() {
        value = 0;
    }

    public void StartRotateRight() {
        value = 1;
    }

    public void StopRotateRight() {
        value = 0;
    }

    private void Start() {
        value = 0;
        value = 0;
    }

    void Update() {
        if (value == -1) {
            _mazeTransform.Rotate(0, 0, 60 * Time.deltaTime);
        }
        if (value == 1) {
            _mazeTransform.Rotate(0, 0, -60 * Time.deltaTime);
        }
    }


}
