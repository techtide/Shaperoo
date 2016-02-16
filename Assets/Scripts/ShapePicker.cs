using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShapePicker : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;

    void Awake()
    {
        Prefab1.tag = "Untagged";
        Prefab2.tag = "Untagged";
        Prefab3.tag = "Untagged";
    }

    void Start()
    {
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
       
        int prefabIndex = UnityEngine.Random.Range(0,4);
        if (prefabList[prefabIndex].name == "Prefab3")
        {
            prefabList[prefabIndex].transform.localScale = new Vector3(1f, 1f, 1f);
         
        } 
        else
        {
            prefabList[prefabIndex].transform.localScale = new Vector3(4f, 4f, 4f);
        }
        prefabList[prefabIndex].tag = "RightShape";

    
        Instantiate(prefabList[prefabIndex]);


    }
}
