using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyGenerate : MonoBehaviour {

	public GameObject myCube;

//	public Vector3 spawnSpot = new Vector3(0,2,0);
	public int minW, minH, maxW, maxH;//w along the x axis, h along the z-axis

	void Start() {
		
		InvokeRepeating ("Spawn", 2, 2);
	}

	void Update() {
		//int width = maxW - minW;
		//int height = maxH - minH;
		//System.Threading.Thread.Sleep(2000);

	}
	void Spawn(){
		System.Random rnd = new System.Random();
		float x_position = rnd.Next(minW, maxW);  // 1 <= month < 13
		float z_position = rnd.Next(minH, maxH);    // 1 <= dice < 7
		Debug.Log("the random position"+x_position+"  "+z_position);
		GameObject cubeSpawn = (GameObject)Instantiate(myCube, new Vector3(x_position,-1050,z_position), transform.rotation);
	}
}
