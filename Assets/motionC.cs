using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class motionC : MonoBehaviour {

    public float x;
    public float y;
    public float z;

    private Queue path;
    public float speed = 0.1f;
    private int counter = 1;
    private Vector3 target;
    private Boolean empty;

    private Vector3 currentP;
    private Vector3 nextP;

    private Boolean start = false;
    private Queue<GameObject> mIslands = new Queue<GameObject>();

    void Start() {
        path = new Queue();
        //target = transform.position;
        //empty = false;
        //currentP = transform.position;
        //nextP = transform.position;
        Animator animi = GetComponent<Animator>();
        mIslands.Enqueue(GameObject.Find("islandB"));
        mIslands.Enqueue(GameObject.Find("islandC"));
        mIslands.Enqueue(GameObject.Find("islandD"));
        mIslands.Enqueue(GameObject.Find("islandE"));
        mIslands.Enqueue(GameObject.Find("islandF"));
        mIslands.Enqueue(GameObject.Find("islandG"));

    }
    IEnumerator pause()
    {
        yield return new WaitForSeconds(100.0f);
    }
    public void StartAnimation()
    {
        if (start) return;
        Animator animi = GetComponent<Animator>();
        // Debug.Log(animi);

        animi.Play("Horse_Run");
        start = true;
        target = (Vector3)path.Dequeue();
    }
    public bool metIsland(GameObject g)
    {
        if (g.name == mIslands.Peek().name)
        {
            mIslands.Dequeue();
            return true;
        }
        return false;
    }
    public void addPath(Vector3 v3)
    {
        path.Enqueue(v3);
    }
    void onCollisionEnter (Collision collision)
    {
        Debug.Log("Guang");
        foreach (ContactPoint contact in collision.contacts) {
            Debug.Log("Duang");
        }
    }
	void Update(){
        if (!start) return;
        // Debug.Log(path.Count);
        if (Vector3.Distance(transform.position,target)>=0.01) {
                
            Vector3 pos = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
				GetComponent<Rigidbody>().MovePosition (pos);
                
              //  transform.rotation = Quaternion.LookRotation(target - pos);
        } else {
                    transform.rotation = Quaternion.LookRotation(target - transform.position);
                if (path.Count!=0) {
					target = (Vector3)path.Dequeue ();
					//Vector3 dir = nextP - currentP;
					currentP = target;
                }
			}


    }

}

