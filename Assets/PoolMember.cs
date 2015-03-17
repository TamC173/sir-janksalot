using UnityEngine;
using System.Collections;

public class PoolMember : MonoBehaviour {

	public float life;
	float timeToDie;

	// Use this for initialization
	void OnEnable () 
	{
		timeToDie = life + Time.time;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.time > timeToDie)
		{
			gameObject.SetActive(false);
		}
	}
}
