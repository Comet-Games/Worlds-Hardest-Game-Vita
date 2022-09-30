using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;

public class Enemy: MonoBehaviour {  
	public Transform[] target;  
	public float speed;  
	private int current;  
	// Use this for initialization    
	void Start() {
		transform.position = target [0].position;
	}  
	// Update is called once per frame    
	void Update() {  
		if (transform.position != target [current].position) 
		{  
			Vector3 pos = Vector3.MoveTowards (transform.position, target [current].position, speed * Time.deltaTime);  
			GetComponent < Rigidbody2D > ().MovePosition (pos);
		} 
		else 
		{
			current = (current + 1) % target.Length;  
		}
	}
} 
