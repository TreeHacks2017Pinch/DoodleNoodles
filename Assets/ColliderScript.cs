using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour {
    Vector3 target;
    public float speed = 0.1f;
    // Use this for initialization
    void Start () {
        target = new Vector3(Random.Range(-0.5f, 1.0f), transform.position.y, Random.Range(-1.0f, 1.0f));
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Horse")
        {
            Debug.Log("DIEDIEDIE");
        }

    }
    // Update is called once per frame
    void Update () {
        if (Vector3.Distance(transform.position, target) >= 0.01)
        {

            Vector3 pos = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

            //  transform.rotation = Quaternion.LookRotation(target - pos);
        }
        else
        {
            target = new Vector3(Random.Range(-0.5f, 1.0f), transform.position.y, Random.Range(-1.0f, 1.0f));
        }
    }
}
