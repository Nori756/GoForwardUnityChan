using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocksound : MonoBehaviour {

    private AudioSource audioSource;
   
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
    
	}
    private void OnCollisionEnter2D(Collision2D collision)
    { if(collision.gameObject.tag =="blockTag")
        {
            audioSource.PlayOneShot(audioSource.clip);
                
   
        }
    }
}
