using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotMechanics : MonoBehaviour
{
    public LineRenderer sling;
    public Transform[] pivots;

    public Camera cam;


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            pivots[1].position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));
        }
        if (Input.GetMouseButtonUp(0))
        {
            pivots[1].position = ((pivots[0].position - pivots[2].position)/2 + this.transform.position);
        }
        sling.SetPositions(new Vector3[3] { pivots[0].position, pivots[1].position, pivots[2].position });
    }
}
