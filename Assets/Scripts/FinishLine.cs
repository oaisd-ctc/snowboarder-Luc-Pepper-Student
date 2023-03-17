using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float FinishTime = .5f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", FinishTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
