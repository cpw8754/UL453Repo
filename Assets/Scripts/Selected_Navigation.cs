using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Leap.Unity.Interaction;

public class Selected_Navigation : MonoBehaviour 
{
    private int c;
    [SerializeField]
    private bool isSelected;
    [SerializeField]
    GameObject selectionManager;

    public Text message;
    NavMeshAgent nav;

	// Use this for initialization
	void Start () 
    {
        isSelected = false;
        nav = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<HandModel>())
        {
            
            message.text = "Entered the trigger!!!";
        }

        if (other.transform.parent && !isSelected)
        {
            isSelected = true;
            selectionManager.GetComponent<Selected>().selectedUnits.Add(this.gameObject);
            message.text = this.name + " has been added!!!";
        }
        
    }

    void OnTriggerStay(Collider other)
    {
        //message.text = other.name + " " + other.tag + " " + c;

        //Debug.Log("HEY IM HERE!!!");

        //if (other.transform.parent)
        //{
        //    c++;
        //    message.text = other.name + " " + other.tag + " " + c;
        //}

        //if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
        //{
        //    message.text = other.name + " " + other.tag + " " + c;
        //}

        //if (other.transform.parent && other.transform.parent.parent &&
        //    other.transform.parent.parent.GetComponent<HandModel>())
        //if (other.transform.tag == "LHand" || other.transform.tag == "RHand")
        //{
        //    Debug.Log("MADE INTO THE TRIGGER EVENT!!!!");
        //    message.text = "Inside the trigger stay!!!";
        //}

        //if (other.transform.parent )
        //Debug.Log("MADE INTO THE TRIGGER EVENT!!!!");
        //message.text = other.transform.parent.GetType().ToString();

        //if (other.gameObject.tag == "LHand" || other.gameObject.tag == "RHand")
        //{
        //    Debug.Log("SHOULD BE PRINTING NOW!!!");
        //    message.text = "Inside the trigger stay!!!";
        //}
    }

    void OnTriggerExit(Collider other)
    {
        //if(other.transform.GetComponent<HandModel>() /*&& other.transform.parent.parent &&
        //    other.transform.parent.parent.GetComponent<HandModel>()*/)
        if (other.transform.tag == "LHand" || other.transform.tag == "RHand")
        {
            message.text = "Just left the Trigger!!!";
        }
    }

    public void navTowardsSelected(Vector3 position)
    {
        Ray toObject = new Ray(Camera.main.transform.position, this.transform.position);
        //Physics.Raycast();
        //Debug.Log(new Vector3(ray.origin.x, 0, ray.origin.y));
        //nav.SetDestination(new Vector3(ray.origin.x + (ray.direction.x * Camera.main.transform.position.y), 0, ray.origin.z + (ray.direction.z * Camera.main.transform.position.y)));
        Debug.Log(position);
        nav.SetDestination(position);

    }
}
