using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class menuScript : MonoBehaviour
{

    public Canvas startMenu;
    public Button startText;
    

	// Use this for initialization
	void Start ()
	{
	    startText = GetComponent<Button>();
	}

    public void StartLevel()
    {
        Application.LoadLevel("Main");
    }
}
