using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
			int[] array ={30,45,60,15,85};
		for (int i = array.Length - 1; i >= 0  ; i --){
				Debug.Log(array[i]) ;
			}
		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
