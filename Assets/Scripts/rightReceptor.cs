using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightReceptor : MonoBehaviour
{

    private GameObject cellMembrane;
    private bool targetFound;
    private string rotationDirection;
    public float speed;

    private void Start()
    {     
        cellMembrane = GameObject.FindGameObjectWithTag("CellMembrane");
        Vector3 position = cellMembrane.transform.position;
        targetFound = false;
        rotationDirection = null;
       
        //Debug.Log("Cell Membrane position: " + position.x + ", " + position.y + ", " + position.z);
    }

    public void Update()
    {
        if(Time.timeScale != 0)
        {
            //If target Found
            if(findTarget() == true)
            {

                if(rotationDirection == "right")
                {
                    transform.RotateAround(cellMembrane.transform.position, Vector3.back, speed * Time.deltaTime);
                }

                else if(rotationDirection == "left")
                {
                    transform.RotateAround(cellMembrane.transform.position, Vector3.forward, speed * Time.deltaTime);                 
                }

                else
                {
                    rotationDirection = getRotationDirection();
                }
            }

            //Else target not found
            else
            {
                targetFound = findTarget();
            }
        }

                            
    }

    private bool findTarget()
    {
        if(GameObject.Find("Left_Receptor_Active(Clone)"))
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    private string getRotationDirection()
    {
        GameObject target = GameObject.Find("Left_Receptor_Active(Clone)");

        var currentRotation = transform.eulerAngles;
        var targetRotation = target.transform.eulerAngles;

        float direction = (((targetRotation.z - currentRotation.z) + 360f) % 360f) > 180.0f ? -1 : 1;       //Clockwise(right) = -1 , CounterClockWise(left) = 1

        if(direction == -1)
        {
            return ("right");
        }

        else
        {
            return ("left");
        }
    }

    public void destroyReceptor()
    {
        if(this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }






}
