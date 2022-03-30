using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            crashEffect.Play(); // Particle effect
            
            Invoke("ReloadScene", reloadDelay);
        }
    }

    private void ReloadScene(){
        SceneManager.LoadScene(0); // Loads scene of index 0 (in our case, Scene1)
    }
}
