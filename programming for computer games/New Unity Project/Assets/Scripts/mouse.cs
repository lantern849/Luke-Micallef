using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 13f) - 8.5f;
        Debug.Log(mousePosInUnits);

        Vector3 paddlePosition = new Vector3(7f, this.transform.position.x, 0f);


        paddlePosition.y = Mathf.Clamp(mousePosInUnits, -3.68f, 3.75f);

        this.transform.position = paddlePosition;
	}
}
