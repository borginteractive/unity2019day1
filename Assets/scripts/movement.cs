using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using DG.Tweening;


public class movement : MonoBehaviour
{

    public GameObject mySphere;
    [HideInInspector] public float speed = 300;
    Timer t;
    float delayTimer = 2f;

    float posX;
    float posY;
    float posZ;
    float targetX = 10f;
    Vector3 startPosition;
    Vector3 endPosition;
    public float lerpValue;

    void Start()
    {
      //  gameObject.AddComponent<Rigidbody>();

        startPosition = transform.position;
        endPosition = new Vector3(10, 1,1);

        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        //   InvokeRepeating("coroutineDemo", 2f, 0.1f);
        //  StartCoroutine("coroutineDemo");

        FindGameObject();
        MoveDoTween();
        }
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        //if (Timer()) 
        //   MoveBasicTweening();

   
    }

    void FindGameObject()
    {

        GameObject.Find("Sphere").GetComponent<Rigidbody>().useGravity = false ;
    }
    void moveLerp()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, lerpValue);
        transform.localScale = Vector3.Lerp(startPosition, endPosition, lerpValue);
        lerpValue += 0.01f;
    }
    void MoveDoTween()
    {
   
        transform.DOMoveX(10, 1.5f).SetEase(Ease.OutBounce);
    }
    void MoveBasicTweening()
    {
        posX += (targetX - posX) * 0.1f;
        transform.position = new Vector3(posX, posY, posZ);
    }
    void MoveBasic()
    {
        if (transform.position.x <= 10)
            transform.position = new Vector3(transform.position.x + 0.01f * Time.deltaTime * speed, transform.position.y, transform.position.z);
    }
    bool Timer()
    {
        delayTimer -= Time.deltaTime;
        if (delayTimer <= 0)
            return true;
        return false;


    }
    IEnumerator coroutineDemo()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            print("Hello World");
            yield return new WaitForSeconds(2f);
            print("Goodbye World");
        }
       
    }
}
