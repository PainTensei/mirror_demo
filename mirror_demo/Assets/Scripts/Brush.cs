using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    private Vector3 mousePos;
    private bool isDrawing;
    public TrailRenderer trailRendererRed;
    public TrailRenderer trailRendererBlue;
    public TrailRenderer trailRendererGreen;
    private string color = "red";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
        mousePos.z = transform.position.z;

        transform.position = mousePos;

        if (!isDrawing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isDrawing = true;
                if (color == "red")
                {
                    trailRendererRed.emitting = true;
                } else if (color == "blue")
                {
                    trailRendererBlue.emitting = true;
                } else if (color == "green")
                {
                    trailRendererGreen.emitting = true;
                }
            }
        }

        if (isDrawing)
        {
            if (Input.GetMouseButtonUp(0))
            {
                isDrawing = false;
                trailRendererRed.emitting = false;
                trailRendererBlue.emitting = false;
                trailRendererGreen.emitting = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            color = "red";
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            color = "blue";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            color = "green";
        }
    }
}
