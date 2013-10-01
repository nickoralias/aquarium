using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FishGod : MonoBehaviour {
	
	public Fish fishBlueprint;
	public Fish fishBlueprint2;
	public int fishCount = 100;
	
	public List<Fish> fishList = new List<Fish>();

	// Use this for initialization
	void Start () {
		int currentFishCounter = 0;
		while(currentFishCounter < fishCount) {
			//spawn a fish
			float random = Random.Range (0f, 10f);
			Vector3 fishPosition = new Vector3(Random.Range (-10f, 10f), Random.Range (-10f, 10f), Random.Range (-10f, 10f));

			if(random < 5f) 
			{
				Fish newFish = Instantiate(fishBlueprint, fishPosition, Quaternion.identity) as Fish;
				fishList.Add (newFish);		
			}
			else
			{
				Fish newFish = Instantiate(fishBlueprint2, fishPosition, Quaternion.identity) as Fish;
				fishList.Add (newFish);		
			}
			//increment fish counter
			currentFishCounter++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space)) {
			foreach (Fish currentFish in fishList) {
				currentFish.destination = Vector3.zero;
			}
		}
	}
}
