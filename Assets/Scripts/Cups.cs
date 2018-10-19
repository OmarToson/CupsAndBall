using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cups : MonoBehaviour {

    public float downHeight = 1.19f;
    public float upHeight = 1.4f;

    public Vector3 targetPosition;

    public float speed = 5f;

    public GameObject ball;

    // Use this for initialization
    void Start () {
        // MoveUp();   //delete it because GameController control to it

        targetPosition = transform.position;   //عشان فى البداية تبدا من فوق الطربيزة مش من تحتها 
    }

    // Update is called once per frame
    void Update () {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime* speed);
	}

    public void MoveUp ()
    {
        targetPosition = new Vector3(
            transform.position.x,
            upHeight,
            transform.position.z
         );
    }

    public void MoveDown()
    {
        targetPosition = new Vector3(
            transform.position.x,
            downHeight,
            transform.position.z
         );
    }

}
