using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenTouch : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ball;

    GameObject obj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform != null)
                {
                    obj = GameObject.FindGameObjectWithTag("Cube");
                    if(hit.collider.name=="Cylinder");
                    Instantiate(ball, obj.transform.position , Quaternion.identity);
                }
            }
        }
        //StartCoroutine("Activate");
    }

    //IEnumerator Activate()
    //{
        
    //    yield return new WaitForSeconds(5);

    //    GameObject.FindGameObjectWithTag("Cube").GetComponentInChildren<Renderer>().enabled = false;

    //    yield return new WaitForSeconds(2);
    //    GameObject.FindGameObjectWithTag("Cube").GetComponent<Renderer>().enabled = false;

    //}
}
