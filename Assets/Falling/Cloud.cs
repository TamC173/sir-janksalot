using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class Cloud : MonoBehaviour
{
	public GameObject neutralPrefab;
	public GameObject evilPrefab;
	public GameObject goodPrefab;

	public float speed = 3.0f;

	// Use this for initialization
	void Start () 
	{
	
	}

	// Update is called once per frame
	void Update () 
	{
		this.transform.Translate (Vector3.up * Time.deltaTime * speed);
	}
	
}
