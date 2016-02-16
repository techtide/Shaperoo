﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShapeManager : MonoBehaviour
{
    public Text ScoreText;
    public float score;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log("Touched it");
            }
        }
    }


}


