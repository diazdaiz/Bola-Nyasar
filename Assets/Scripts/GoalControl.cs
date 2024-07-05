using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalControl : MonoBehaviour {
    void Start() {

    }

    void Update() {

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("You win!");
        if (collision.attachedRigidbody) {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Trigger Exit");
    }

}
