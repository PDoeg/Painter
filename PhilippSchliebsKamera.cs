using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class kamera : MonoBehaviour {

	public int maxScore = 20;
	public static float memory = 0;
	private VignetteAndChromaticAberration script;

	// Use this for initialization
	void Start () {
		script = GetComponent <VignetteAndChromaticAberration> ();
	}
	
	// Update is called once per frame
	void Update () {
		script.chromaticAberration = Mathf.Lerp (0, 100, (float)Score.score / (float)maxScore);
		memory = Mathf.Lerp (0, 100, (float)Score.score / (float)maxScore);
	}
	
	void DoSomething()
	{
		Debug.Log("i am doing something");
	}
}
