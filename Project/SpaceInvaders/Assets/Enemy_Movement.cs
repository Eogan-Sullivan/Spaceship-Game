using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    // Use this for initializ
    float acceleration = 5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
      
    }
}
