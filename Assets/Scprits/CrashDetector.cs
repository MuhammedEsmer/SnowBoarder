using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay;
    [SerializeField] ParticleSystem bloodEffect;
    [SerializeField] AudioClip crashSFX;
    bool hascrashed = false; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hascrashed)
        {
            hascrashed = true;
            bloodEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
            FindObjectOfType<PlayerController>().DisableControls();
        }       
    }
    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
