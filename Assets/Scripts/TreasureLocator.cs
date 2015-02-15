using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class TreasureLocator : MonoBehaviour {
	public Transform Indicator;
	public Text Display;
	public Image Panel;
	public float DistanceThreshold = 0f;

	[Serializable]
	public class StoryUnit {
		public string message;
		public Transform destination;
	}

	public StoryUnit[] Story;
	public StoryUnit CurrentStory;

	private int _currentStoryIndex = -1;


	// Use this for initialization
	void Start () {
		NextStory();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.N))
			NextStory();

		if(CurrentStory.destination != null) {
			Indicator.LookAt(CurrentStory.destination.position);
			if(Vector3.Distance(CurrentStory.destination.position, Indicator.position) < DistanceThreshold)
				NextStory();
		} else {
			if(Input.GetKeyDown(KeyCode.Space)) {
				Panel.gameObject.SetActive(true);
				Display.text = "THE END";
			}
		}
	}

	void NextStory() {
		++_currentStoryIndex;
		if(_currentStoryIndex >= Story.Length) {
			return;
		}

		CurrentStory = Story[_currentStoryIndex];
		Display.text = CurrentStory.message;
	}
}
