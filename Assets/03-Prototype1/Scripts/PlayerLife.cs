using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    [SerializeField] AudioSource deathSound;

    bool dead = false;

    void Update ()
    {
        if (transform.position.y < -1f && !dead)
        {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true; 
        GetComponent<PlayerMovement>().enabled = false;
        Die();
        }
    }




    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            Die();

        }
    }

    void Die ()
    {
        
        Invoke(nameof(ReloadLevel), 1.3f);
        dead = true; 
        deathSound.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

}


