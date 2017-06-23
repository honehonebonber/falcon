using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrayTest : MonoBehaviour {

	public List<int> listtest = new List<int>();

	// Use this for initialization
	void Start () {
		listtest.Add  (1);
		listtest.Add (2);
		foreach (int n in listtest) {
			print (n);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
