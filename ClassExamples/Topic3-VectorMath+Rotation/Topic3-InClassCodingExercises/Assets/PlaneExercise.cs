using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlaneExercise : MonoBehaviour
{
    public Transform WhitePlane;
    public Transform RedQuad;
    // Note: by default RedQuad's normal is in the -forward direction

    public bool ShowWhite = true;
    public bool ShowRed = false;
    public Vector3 WhitePlaneNormal = new Vector3(0, 1, 0);
    public float WhitePlaneD = 0; // Ax + By + Cz + D = 0

    private GameObject RedQuadNormal = null;
    private GameObject RedQuadD = null;

    private const float kNormalSize = 4f;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(WhitePlane != null);
        Debug.Assert(RedQuad != null);

        RedQuadNormal = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        RedQuadNormal.GetComponent<Renderer>().material.color = Color.blue; 
        RedQuadNormal.transform.localScale = new Vector3(0.2f, kNormalSize, 0.2f);
        RedQuadNormal.SetActive(false);
        RedQuadD = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        RedQuadD.GetComponent<Renderer>().material.color = Color.black;
        RedQuadD.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        RedQuadD.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Assuming the equation is:
        //      n  dot  P =  D
        //      n  dot  P - D = 0
        // and not:
        //      n dot P + D = 0

        // 1. Display the whiteplane according to the normal and D
        WhitePlane.gameObject.SetActive(ShowWhite);
        if (ShowWhite)
        {
            // ...
            // Do you know how to draw a cylinder on the white plane to show its normal?
        }

        // 2. draw the normal of the red quad and its D 
        //    D: value sets the sphere radius (sphere should locate at Quad center)
        RedQuadD.SetActive(ShowRed);
        RedQuadNormal.SetActive(ShowRed);
        RedQuad.gameObject.SetActive(ShowRed);
        if (ShowRed)
        {
            // ...
        }

    }

        // Implement this function: draws cylinder from p1 to p2
    void SetLine(Vector3 p1, Vector3 p2, GameObject line)
    {
        line.SetActive(true);
        Vector3 v = p2 - p1;
        Vector3 vn = v.normalized;
        float length = v.magnitude;
        line.transform.position = p1 + length * 0.5f * vn; // or (p1 + p2) / 2;
        line.transform.up = vn;
        Vector3 scale = line.transform.localScale;
        line.transform.localScale = new Vector3(scale.x, length / 2f, scale.z);
    }
}