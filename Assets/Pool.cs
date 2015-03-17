using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pool : MonoBehaviour 
{	
	public GameObject[] objects;
	public int[] number;
	
	public List<GameObject>[]pool;
	
	void Start()
	{
		instantiate ();
	}
	
	//Instantiate the clouds
	void instantiate()
	{
		GameObject temp;
		pool = new List<GameObject>[objects.Length];
		
		for(int count = 0; count < objects.Length; count++)
		{
			pool[count] = new List<GameObject>();
			for(int num = 0; num < number[count]; num++)
			{
				temp = (GameObject)Instantiate(objects[count]);
				temp.transform.parent = this.transform;
				pool[count].Add (temp);
			}
		}
	}
	
	public GameObject activate(int id)
	{
		for(int count = 0; count < pool[id].Count; count++)
		{
			if(!pool[id][count].activeSelf)
			{
				pool[id][count].SetActive(true);
				return pool[id][count];
			}
		}
		return null;
	}

	public void deActivate(GameObject deActivateObject)
	{
		deActivateObject.SetActive (false);
	}
}