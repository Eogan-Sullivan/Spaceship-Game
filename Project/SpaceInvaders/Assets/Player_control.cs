using UnityEngine;
using System.Collections;

public class Player_control : MonoBehaviour {
    
    //booleans called for movement
    bool turn = false,
    left = false, right = false, down = false,
    up = false, fly = false, desend = false;
    //speed in which the character moves and turns
    float speed = 3f,speedofturn = 50f ;
    public Rigidbody projectile;
    public float shotforce = 1000f;
    Transform playerpos;
 
    
    // Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {

        //if the left arrorw is pressed return true
        left = Input.GetKey(KeyCode.LeftArrow);
        //call move left method with left equal to true
        MoveLeft(left);
        right = Input.GetKey(KeyCode.RightArrow);
        MoveRight(right);
        down = Input.GetKey(KeyCode.DownArrow);
        MoveBack(down);
        up = Input.GetKey(KeyCode.UpArrow);
        MoveForward(up);
        turn = Input.GetKey(KeyCode.LeftControl);
        RotateChar(turn);
        fly = Input.GetKey(KeyCode.Space);
        FlyChar(fly);
        desend = Input.GetKey(KeyCode.V);
        DesendChar(desend);
        FireBullet();

     
	}

    private void FireBullet()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Rigidbody shot = Instantiate(projectile, transform.position, Quaternion.Euler(90, 0, 0)) as Rigidbody;
            shot.AddForce(transform.forward * shotforce);
        }
    }

    
    private void DesendChar(bool desend)
    {
        if (desend) transform.Translate(-Vector3.up * speed * Time.deltaTime);
    }

    private void FlyChar(bool fly)
    {
        if (fly) transform.Translate(Vector3.up * speed * Time.deltaTime);
    }


    private void MoveForward(bool p)
    {

    if (p) transform.Translate(Vector3.forward * speed * Time.deltaTime);
 
        
    }

    private void MoveBack(bool p)
    {
        if (p) transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void MoveRight(bool p)
    {
        if (p) transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    // while left is true move the character left
    private void MoveLeft(bool p)
    {
        if (p) transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void RotateChar(bool p)
    {
        if (p) transform.Rotate(Vector3.up * speedofturn * Time.deltaTime);
    }
}
