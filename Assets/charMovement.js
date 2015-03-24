#pragma strict

public var speed;
function Start () {

}

function Update () {
transform.position = Vector3(
		Mathf.PingPong(Time.time*-30, 40),transform.position.y,transform.position.z);
}


