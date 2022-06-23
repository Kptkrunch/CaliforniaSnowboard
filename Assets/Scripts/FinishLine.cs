using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishDelay;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Player") {
            Debug.Log("testing Finish Line");
            Invoke("ReloadScene", finishDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }

}
