using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class VectorExercise : MonoBehaviour
{
    public Transform ObjA;

    public Transform p1;
    public Transform p2;

    public Transform p3;
    public Transform p4;

    public Transform Red;
    public float ObjASpeed = 0.1f; // Per second
    public float RedSpeed = 0.1f; // Per second
    public float ProjectileSpeed = 2.0f; // Per second

    private GameObject WhiteLine = null;
    private GameObject GreenLine = null;

    private GameObject Projectile = null;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(p1 != null);
        Debug.Assert(p2 != null);
        Debug.Assert(p3 != null);
        Debug.Assert(p4 != null);
        Debug.Assert(Red != null);
        Debug.Assert(ObjA != null);

        Projectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Projectile.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        Projectile.GetComponent<Renderer>().material.color = Color.blue;
        Projectile.SetActive(false);
        
        // The lines
        WhiteLine = new GameObject("WhiteLine");
        WhiteLine = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        WhiteLine.GetComponent<Renderer>().material.color = Color.white;
        WhiteLine.transform.localScale = new Vector3(0.01f, 0.5f, 0.01f);
        WhiteLine.SetActive(false);
        GreenLine = new GameObject("GreenLine");
        GreenLine = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GreenLine.GetComponent<Renderer>().material.color = Color.green;
        GreenLine.transform.localScale = new Vector3(0.01f, 0.5f, 0.01f);
        GreenLine.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        // 1. Continuously marching ObjA towards p2, if reach P2, start over at P1


        // 2. send the Projectile towards Red at speed ProjectileSpeed when space is pressed
        //    projectile should start at ObjA's position and disappear when it reaches Red
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Projectile.SetActive(true);
            // ... 
        }

        if (Projectile.activeSelf)
        {
            // ...
        }

        // 3. March Red along the direction defined by P3 towards P4, when Red is 
        //    farther than 10 units from p3, it should reset to p3 and repeat
        // ...
        
        

        // 4. Define a SetLine function to receive three parameters
        //       SetLine(Vector3 p1, Vector3 p2, transform CylinderTransform)
        //    and draws the cylinder from p1 to p2
        // Now draw the lines between p1 to p2, and p3 to p4
        SetLine(p1.localPosition, p2.localPosition, WhiteLine);
        SetLine(p3.localPosition, p4.localPosition, GreenLine);

    }
    
    // Implement this function: draws cylinder from p1 to p2
    void SetLine(Vector3 p1, Vector3 p2, GameObject line)
    {
        
    }
}