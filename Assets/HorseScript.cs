using UnityEngine;
using System.Collections;

public class HorseScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void StartAnimation()
    {
        GameObject Horse = GetComponent<GameObject>();
        Animator Animator = Horse.GetComponent<Animator>();
        Animator.Play("Horse_run");
    }
}
