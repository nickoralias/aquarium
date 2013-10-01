using UnityEngine;
using System.Collections;

public class HomeworkQuestions : MonoBehaviour {
	
	public Camera cam_ramp;
	public Camera cam_balloons;
	public Camera cam1, cam2, cam3, cam4, cam5;
	public ConstantForce force;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > 50f) {
			cam1.enabled = 	false;
			cam2.enabled = true;
			Debug.Log(Time.time);
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Ball")
		Destroy (other.gameObject);
		
		force.enabled = true;
	}
}
