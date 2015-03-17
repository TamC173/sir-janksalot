using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 3.0f;
	public float score = 0f;

	private float startTime;
	private float restSeconds;
	private float roundedRestSeconds;
	private float displaySeconds;
	private float displayMinutes;

	int countDownSeconds = 0;

	void Awake()
	{
		startTime = Time.time;
	}

	public void OnGUI()
	{
		float guiTime = Time.time - startTime;
		restSeconds = countDownSeconds - (guiTime);

		roundedRestSeconds = Mathf.CeilToInt (restSeconds);
		displaySeconds = roundedRestSeconds % 60;
		displayMinutes = roundedRestSeconds / 60;

		string timerText = string.Format ("{0:00}:{1:00}", displayMinutes, displaySeconds);
		GUI.Label (new Rect(400,25,100,30), timerText);

		string text = "Score: " + score;
		GUI.color = Color.red;
		GUI.Label (new Rect (10, 30, 60, 20), text);
	}

	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "evilcloud")
		{
			score--;
			Destroy (collision.gameObject);
		}
		else if (collision.gameObject.tag == "goodcloud")
		{
			score++;
			Destroy (collision.gameObject);
		}

	} 

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () 
	{

		float x = Input.GetAxis ("Horizontal") * Time.smoothDeltaTime * speed;
		float y = Input.GetAxis ("Vertical") * Time.smoothDeltaTime * speed;
		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp (pos.x + x, -4, 4);
		//if(pos.x == 7)
		//{pos.x = -7;}
		pos.z = Mathf.Clamp (pos.z + y, -4, 4);
		transform.position = pos;

		transform.Translate (x, 0, y, Space.Self);
	
	}
}
