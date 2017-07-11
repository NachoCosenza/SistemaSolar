using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tralacion : MonoBehaviour {

	public Transform pivot;
	public float velocidad ;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.RotateAround(pivot.position,Vector3.up,velocidad);



	}
}
