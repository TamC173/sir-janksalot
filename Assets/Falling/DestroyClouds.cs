using UnityEngine;
using System.Collections;

public class DestroyClouds : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "evilcloud" || 
		   collider.gameObject.tag == "neutral"   || 
		   collider.gameObject.tag == "goodcloud")
		Destroy (collider.gameObject);
	} 



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
