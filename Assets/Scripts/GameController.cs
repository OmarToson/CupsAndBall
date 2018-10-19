using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ball;
    public Cups[] cups;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ShuffleRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator ShuffleRoutine() //دالة لانتظار بضع ثوانى
    {
        yield return new WaitForSeconds(1f);  //يستنى ثانية بعدين الكابس تطلع 
        
        foreach (Cups cup in cups)  //عشان تتعمل على ال 3 كابس
        {
            cup.MoveUp();
        }

        yield return new WaitForSeconds(0.5f);

        Cups targetCup = cups[Random.Range(0,cups.Length)];  //for taking random cup 

        targetCup.ball = ball;

        ball.transform.position = new Vector3(  //make ball go to the random cup in x,z and the same y
            targetCup.transform.position.x,
            ball.transform.position.y,
            targetCup.transform.position.z
        );

        yield return new WaitForSeconds(1f);

        foreach (Cups cup in cups)   //تنزل الكابس
        {
            cup.MoveDown();
        }
    }
}
