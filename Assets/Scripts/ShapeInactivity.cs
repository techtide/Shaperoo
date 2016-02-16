using UnityEngine;
using System.Collections;

public class ShapeInactivity : MonoBehaviour
{

    public GameObject shapeDestructionPoint;

    // Use this for initialization
    void Start()
    {
        shapeDestructionPoint = GameObject.Find("ShapeDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < shapeDestructionPoint.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
