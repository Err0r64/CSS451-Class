using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class EX4_ShadowOnPlane : MonoBehaviour
{
    public Transform WhitePlane;

    public Transform P; // Point to cast shadow to the plane
    public Transform ShadowPoint; // to show the shadow point on the plane
    

    public Transform AxisFrame = null;
    public bool ShowAxisFrame = true;

    public bool ShowAllLines = false;
    // 
    private GameObject PlaneNormalLine = null;
    
    private GameObject LineToP = null;
    private GameObject LinePtToP = null;
    
        

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(WhitePlane != null);
        Debug.Assert(P != null);
        Debug.Assert(ShadowPoint != null);
        Debug.Assert(AxisFrame != null);

        PlaneNormalLine = Support.CreateLine("PlaneNormal", Color.red);
        PlaneNormalLine.SetActive(false);

        LineToP = Support.CreateLine("LineToP", Color.green);
        LinePtToP = Support.CreateLine("LinePtToP", Color.blue);
        LinePtToP.SetActive(ShowAllLines);
        LineToP.SetActive(ShowAllLines);
    }

    // Update is called once per frame
    void Update()
    {
        AxisFrame.gameObject.SetActive(ShowAxisFrame);

        // Assuming the equation is:
        //      n  dot  P =  D
        //      n  dot  P - D = 0
        // and not:
        //      n dot P + D = 0

        // Update the whiteplane normal
        Vector3 n = WhitePlane.up;
        // make sure variable name is similar to equation
        // easier to double check for correctness

        Support.UpdatePlaneNormal(WhitePlane, n, PlaneNormalLine);

        // Project P onto WhitePlane along the plane normal direction
        // Show projected point using ShadowPoint 
        //
        // Begin by first getting the main answer (proper projection)
        // and then worry about the condition (in front of plane) later
        //
        //  1. Compute the projection on an infinite plane
        //        in front of or behind is ignored for now
        //        use the lines to help with debugging
        //   2. When answer is correct, then add the condition (in front of plane)
        //   3. Set the color of P accordingly: green if in front, red if behind

        //  change color
        //      P.gameObject.GetComponent<Renderer>().material.color = Color.green;
   
    }
}