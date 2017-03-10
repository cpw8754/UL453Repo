using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour 
{
    float currentMouseX;
    float currentMouseY;

    float distToTerrainBase;

    public float speed = .25f;
    public float boundary = 50;

	// Use this for initialization
	void Start () 
    {
        Vector3.Distance(this.transform.position, (new Vector3(this.transform.position.x, 0.0f, this.transform.position.z)));
	}
	
	// Update is called once per frame
	void Update () 
    {
        currentMouseX = Input.mousePosition.x;
        currentMouseY = Input.mousePosition.y;

        if (currentMouseX > Screen.width - boundary)
        {
            Vector3 destination = new Vector3(this.transform.position.x + (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
            transform.position = destination;
            //this.transform.position = new Vector3(this.transform.position.x + 5, this.transform.position.y, this.transform.position.z);
            //Vector3.Lerp(this.transform.position, destination,0.25f);
        }

        if (currentMouseX < boundary)
        {
            Vector3 destination = new Vector3(this.transform.position.x - (speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
            transform.position = destination;
            //this.transform.position = new Vector3(this.transform.position.x + 5, this.transform.position.y, this.transform.position.z);
            //Vector3.Lerp(this.transform.position, destination, 0.25f);
        }

        if (currentMouseY > Screen.height - boundary)
        {
            Vector3 destination = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));
            transform.position = destination;
            //this.transform.position = new Vector3(this.transform.position.x + 5, this.transform.position.y, this.transform.position.z);
            //Vector3.Lerp(this.transform.position, destination, 0.25f);
        }

        if (currentMouseY < boundary)
        {
            Vector3 destination = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - (speed * Time.deltaTime));
            transform.position = destination;
            //this.transform.position = new Vector3(this.transform.position.x + 5, this.transform.position.y, this.transform.position.z);
            //Vector3.Lerp(this.transform.position, destination, 0.25f);
        }
	}
}