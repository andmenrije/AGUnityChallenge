using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Component is being called");
            RaycastHit rayHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayHit, 1000.0f))
            {
                Debug.Log("Raycast hit");
                if(rayHit.transform != null)
                {
                    Debug.Log(rayHit.transform.gameObject);
                }
            }
        }
    }
}
