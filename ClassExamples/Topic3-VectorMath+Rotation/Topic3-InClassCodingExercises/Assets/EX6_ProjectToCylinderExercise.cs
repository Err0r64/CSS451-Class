using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class EX6_ProjectToCylinderExercise : MonoBehaviour
{
    public Transform P; // Point to project to the cylinder

    public Transform Pt; // to show the projected point on the cylinder
    public Transform TheCylinder;
    public float CylinderRadius = 1.0f;
    public Transform CP1; // Cylinder Point 1 (top)
    public Transform CP2; // Cylinder Point 2 (bottom)

    private GameObject ProjectionLine = null;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(P != null);
        Debug.Assert(Pt != null);
        Debug.Assert(TheCylinder != null);

        
        // The lines
        ProjectionLine = new GameObject("ProjectionLine");
        ProjectionLine = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        ProjectionLine.GetComponent<Renderer>().material.color = Color.white;
        ProjectionLine.transform.localScale = new Vector3(0.1f, 0.5f, 0.1f);
        ProjectionLine.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Set TheCylinder's scale according to CylinderRadius
        //    Note: TheCylinder's original radius is 0.5 (default Unity cylinder)
        TheCylinder.localScale = new Vector3(2.0f*CylinderRadius, TheCylinder.localScale.y, 2.0f*CylinderRadius);

        Vector3 vn = TheCylinder.up;  // Cylinder direction is v, vn says it is normalized
        float h = 2.0f * TheCylinder.localScale.y; // half height of the cylinder

        // 2. P1 and P2 of the cylinder: 
        //      remember Cylinder is centered at its localPosition
        //      and its object space height is 2.0
        CP1.transform.localPosition = TheCylinder.localPosition - 0.5f * h * vn;
        CP2.transform.localPosition = TheCylinder.localPosition + 0.5f * h * vn;

        // Now, project P to the cylinder surface
        //    if projected point is outside the height range, color it red, else blue
        // Pt is the projected point on the cylinder surface
    
    }
}