using UnityEngine;
using System.Collections;

public class Uni : MonoBehaviour {
	// Use this for initialization

	public int a = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (a <= 250) {
			transform.Translate (1*Time.deltaTime, 0, 0);
			a++;
		} else if (a > 250 && a <= 500) {
			transform.Translate (-1*Time.deltaTime, 0, 0);
			a++;
		} else
			a = 0;
			
	}
		
}

