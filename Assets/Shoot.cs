using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour 
{
	public Pool pool;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown (KeyCode.C))
		{
			pool.activate(0);
		}
	}
}
