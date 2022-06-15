using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class PlacementScript : MonoBehaviour
{
    // Start is called before the first frame update

    public ARSessionOrigin origin;

    public List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public GameObject obj;

    GameObject instantiatedobj; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //detect user touch
        //project raycast
        //instantiate cube

        if(Input.GetMouseButton(0))
        {

            //Debug.Log("Yesit worked");
            bool collision = origin.GetComponent<ARRaycastManager>().Raycast(Input.mousePosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon);

            if(collision)
            {

                if(instantiatedobj != null)
                {
                    instantiatedobj = Instantiate(obj);
                }
                instantiatedobj.transform.position = hits[0].pose.position;
            }
        }
        
    }
}
