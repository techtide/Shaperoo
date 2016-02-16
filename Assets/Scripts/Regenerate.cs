using System.Collections.Generic;
using UnityEngine;

public class Regenerate : MonoBehaviour
{
    public Renderer shapeRenderer;
    public GameObject shape;
    public Transform generationPoint;
    public float distanceBetween;
    public float platformWidth;
    public GameObject[] _myPrefabs;


    // Use this for initialization
    void Start () {
     platformWidth = shape.GetComponent<BoxCollider2D>().size.x;
	  shapeRenderer = shape.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	  //  shapeRenderer.material.color = Color.green;
   

        if (transform.position.y < generationPoint.position.y)
        {

       // shapeRenderer.material.color = Color(Random.Range(0.0, 1.0), Random.Range(0.0, 1.0), Random.Range(0.0, 1.0));
            transform.position = new Vector3(transform.position.x, transform.position.y+distanceBetween+platformWidth, shape.transform.position.z);
            GameObject clone = Instantiate(_myPrefabs[RandomNumber()]) as GameObject;
            Instantiate(clone, transform.position, Quaternion.identity);

        }

    }

    int RandomNumber()
    {
        System.Random rand = new System.Random();
        return rand.Next(0, _myPrefabs.Length);
    }
}
