#pragma strict

var minTime = 0.5;
var threshhold = 0.5;
var myLight : Light;

private var lastTime = 0;

function Update () 
{
	if((Time.time - lastTime) > minTime)
	if (Random.value > threshhold)
	GetComponent.<Light>().enabled = true;
	else
	GetComponent.<Light>().enabled = false;
	lastTime = Time.time;
}