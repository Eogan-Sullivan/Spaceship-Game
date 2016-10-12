using UnityEngine;
using System.Collections;

public class Camera_Control : MonoBehaviour {
    float distanceBehindShip = 10;
    float distanceAboveShip = 5;
    float distancetoFocus = 200;
    GameObject player1;
	// Use this for initialization
	void Start () {
        player1 = GameObject.FindGameObjectWithTag("Player");
        if (!player1)
            print("ship not found"); 
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position,
                                    player1.transform.position
                                - distanceBehindShip * player1.transform.forward
                                    + distanceAboveShip * player1.transform.up,
                                    0.2f);
        Vector3 target = player1.transform.position
                            + distancetoFocus * player1.transform.forward;
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(
                                    target - transform.position,
                                    player1.transform.up),
            0.2f);


	
	}
}
