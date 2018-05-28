using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53;

	public void Magic(int mp){
		if (mp > 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class boss1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss lastboss = new Boss ();

		lastboss.Magic(3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
