using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 3, 17, 29, 31, 47 };
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]);
				}
			}
	
	// Update is called once per frame
	void Update () {
		
	}
}