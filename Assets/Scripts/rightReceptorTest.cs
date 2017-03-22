using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightReceptorTest : MonoBehaviour
{

    private GameObject cellMembrane;
    public float speed;

    private void Start()
    {
        //leftReceptor = GameObject.FindGameObjectWithTag("ExternalReceptor");

        cellMembrane = GameObject.FindGameObjectWithTag("CellMembrane");

        Vector3 position = cellMembrane.transform.position;

        Debug.Log("Cell Membrane position: " + position.x + ", " + position.y + ", " + position.z);


    }

    public void Update()
    {
        if(Time.timeScale != 0)
        {
            transform.RotateAround(cellMembrane.transform.position, Vector3.forward, speed * Time.deltaTime);
        }        
    }
        
}
