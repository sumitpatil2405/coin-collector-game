using UnityEngine;
using System.Collections;

public class Scenecontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(1);
        }
        if (Input.GetKeyDown("e"))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown("s"))
        {
            Application.LoadLevel(1);
        }
    }
}
