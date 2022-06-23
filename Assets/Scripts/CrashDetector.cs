using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float crashDelay;
    [SerializeField] ParticleSystem deathEffect;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Ground") {
            Debug.Log("testing crash");
            deathEffect.Play();
            Invoke("ReloadScene", crashDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
