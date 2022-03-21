using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            Invoke("ReloadScene", reloadDelay);
        }
    }

    private void ReloadScene(){
        SceneManager.LoadScene(0); // Loads scene of index 0 (in our case, Scene1)
    }
}
