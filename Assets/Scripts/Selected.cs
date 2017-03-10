using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selected : MonoBehaviour 
{
    Ray selectedTransform;
    RaycastHit hitInfo;
    bool hit;
    Selected_Navigation navAccess;
    Terrain currentLevel;

    public Text list;

    public List<GameObject> selectedUnits;

	// Use this for initialization
	void Start () 
    {
        selectedUnits = new List<GameObject>();
        hitInfo = new RaycastHit();
        navAccess = GetComponent<Selected_Navigation>();
        currentLevel = Terrain.activeTerrain;
	}

    public void AddToList(GameObject go)
    {
        //if (selectedUnits.Add()
        //{

        //}
    }
	
	// Update is called once per frame
	void Update () 
    {
        list.text = selectedUnits.Count.ToString();

        //if (Leap.)
        //if (Input.GetMouseButtonDown(0))
        //{
        //    selectedTransform = new Ray(Camera.main.transform.position, Input.mousePosition);
        //    RaycastHit hitInfo = new RaycastHit();
        //    float dist;

        //    hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    //hitInfo.point;
        //    if (hit)
        //    {
        //        if (hitInfo.transform.tag == "TestDummy")
        //        {
        //            Debug.Log("I have been selected!!!" + hitInfo.transform.tag);
        //            if (selectedUnits.Count == 0)
        //            {
        //                selectedUnits.Add(GameObject.FindGameObjectWithTag("TestDummy"));
        //            }
        //            else if (selectedUnits.Count > 0)
        //            {
        //                foreach (GameObject g in selectedUnits)
        //                {
        //                    if (g.tag == "TestDummy")
        //                    {
        //                        //do nothing here
        //                    }
        //                }
        //            }
        //        }
        //        else if (hitInfo.transform.tag == "Terrain")
        //        {
        //            Debug.Log("Something else has been selected!!! " + hitInfo.transform.tag);
        //            selectedUnits.Clear();
        //        }
        //    }

        //}

        //if (selectedUnits.Count >= 1)
        //{
        //    Debug.Log("WE have something in the list!");
        //    if (Input.GetMouseButton(1))
        //    {
        //        //Debug.Log("U R TRYIN TO MOV ME!!!");
        //        Ray moveToHere = Camera.main.ScreenPointToRay(Input.mousePosition);

        //        int mask = LayerMask.NameToLayer("Terrain");
        //        RaycastHit placeToMove;
        //        Physics.Raycast(moveToHere, out placeToMove, 1<<mask);
        //        //Debug.Log(moveToHere.direction + "is the direction of the ray from the cursor");

        //        Debug.Log(placeToMove.distance + " " + placeToMove.point);

        //        //navAccess.navTowardsSelected(moveToHere);
        //        foreach (GameObject g in selectedUnits)
        //        {
        //            //g.GetComponent<Selected_Navigation>().navTowardsSelected(moveToHere);
        //            g.GetComponent<Selected_Navigation>().navTowardsSelected(placeToMove.point);
        //        }
        //    }
        //}
		
	}
}
