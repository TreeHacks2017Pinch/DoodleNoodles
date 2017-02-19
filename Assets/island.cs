using UnityEngine;
using System.Collections;

public class island : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            Debug.Log("Boom");
        }
        Debug.Log("Boom");
        // if (collision.relativeVelocity.magnitude > 2)
        //     audio.Play();

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("BLUBLU");
        if (other.gameObject.GetComponent<motionC>().metIsland(gameObject))
        {
            Debug.Log("Met Objective");
        }
    }
    // Update is called once per frame
    void Update () {
        
    }
}
