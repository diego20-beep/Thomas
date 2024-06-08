using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject MoveObject;
    public Transform StartPoint;
    public Transform EndPoint;
    public float speed;
    public Vector2 direction;
    

    // Start is called before the first frame update
    void Start()
    {
        direction = EndPoint.position;
    }
    // Update is called once per frame
    void Update()
    {
       // MoveObject.transform.position = Vector2.Distance(MoveObject.transform.position, direction, speed * Time.deltaTime);
    }
}
