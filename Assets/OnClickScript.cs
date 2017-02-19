using UnityEngine;
using System.Collections;

public class OnClickScript : MonoBehaviour {
    [SerializeField]
    public GameObject DrawingScript;

    // Use this for initialization
    void Start () {
	
	}

	public void OnClick() 
    {
        Debug.Log("OnClicked");
        DrawingScript.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
