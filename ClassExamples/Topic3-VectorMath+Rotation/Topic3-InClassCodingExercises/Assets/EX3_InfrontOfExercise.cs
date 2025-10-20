using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class EX3_InFrontExercise : MonoBehaviour
{
    public Transform WhitePlane;
    public Transform P; // Point to test against the plane

    public Transform AxisFrame = null;
    public bool ShowAxisFrame = true;
    
    // 
    private GameObject PlaneNormalLine = null;
        

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(WhitePlane != null);
        Debug.Assert(P != null);
        Debug.Assert(AxisFrame != null);

        PlaneNormalLine = Support.CreateLine("PlaneNormal", Color.red);
        PlaneNormalLine.SetActive(false);
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
        Vector3 n = WhitePlane.up;
        // variable names similar to math notation
        // for easy verification with equations on paper

        // Update the whiteplane normal
        Support.UpdatePlaneNormal(WhitePlane, n, PlaneNormalLine);

        // Determine if P is in front of or behind the plane
        // 
        // When in front: set color to Green by
        //     P.gameObject.GetComponent<Renderer>().material.color = Color.green;
        //
        // When behind: set color to Red by
        //     P.gameObject.GetComponent<Renderer>().material.color = Color.red;
        // 

        // When testing your code, ALWAYS move P around to see if the color changes correctly.
        // VERY IMPORTANT: move the plane so that the localPosition's x,y,z are not zero!

    }   
}