using UnityEngine;
using System.Collections;

public class destroytime : MonoBehaviour {
      
    float time = .9f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject,time);
	}
}
