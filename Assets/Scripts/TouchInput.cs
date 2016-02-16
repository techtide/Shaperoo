using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour
{

    public float score;
    public Text text;
    public CameraScrolling cameraScrolling;

    void Start()
    {
        cameraScrolling = GetComponent<CameraScrolling>();
    }
	void Update () {
        if (score > 8f)
        {
            cameraScrolling.scrollSpeed = 0.07f;
        }
        if (score > 16f)
        {
            cameraScrolling.scrollSpeed = 0.10f;
        }
        if (score > 32f)
        {
            cameraScrolling.scrollSpeed = 0.13f;
        }
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            // RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
            if (hitInfo)
            {
                Debug.Log(hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "RightShape")
                {
                    score++;
                    Debug.Log(score);
                    hitInfo.transform.gameObject.SetActive(false);
                }else if(hitInfo.transform.gameObject.tag == "Untagged")
                {
                    score--;
                }
                // Here you can check hitInfo to see which collider has been hit, and act appropriately.
                
            }
        }
        text.text = score.ToString();
	  
    }
}
