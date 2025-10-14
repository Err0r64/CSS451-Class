using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaneExercise : MonoBehaviour
{
    public Transform WhitePlane;
    public Transform RedQuad;
        // Note: by default RedQuad's normal is in the -forward direction

    public Vector3 WhitePlaneNormal = new Vector3(0, 1, 0);
    public float WhitePlaneD = 0; // Ax + By + Cz + D = 0

    private GameObject RedQuadNormal = null;
    private GameObject RedQuadD = null;

    private const float kNormalSize = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(WhitePlane != null);
        Debug.Assert(RedQuad != null);

        RedQuadNormal = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        RedQuadNormal.GetComponent<Renderer>().material.color = Color.blue; 
        RedQuadNormal.transform.localScale = new Vector3(0.5f, kNormalSize, 0.5f);
        RedQuadNormal.SetActive(false);
        RedQuadD = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        RedQuadD.GetComponent<Renderer>().material.color = Color.black;
        RedQuadD.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        RedQuadD.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Display the whiteplane according to the normal and D
        

        // 2. draw the normal of the red quad and its D 
        //    D: value sets the sphere radius (sphere should locate at Quad center)
        // AI says:
        RedQuadD.SetActive(true);
        RedQuadNormal.SetActive(true);

    }
}