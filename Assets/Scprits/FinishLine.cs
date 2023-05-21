using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay;
    [SerializeField] ParticleSystem finishEffect;
  

    private void Start()
    {
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);
            
        }
        

    }
  
    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
