using System.Collections;
using System.Collections.Generic;
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
        // 1. March objA between p1 and p2 at speed ObjASpeed
        // AI says: 
        ObjA.position = Vector3.Lerp(p1.localPosition, p2.localPosition, Mathf.PingPong(Time.time * ObjASpeed, 1));
        // now ignore the above and perform this with vectors we learned in class

        // 2. send the Projectile towards Red at speed ProjectileSpeed when space is pressed
        //    projectile should start at ObjA's position and disappear when it reaches Red
        // AI says:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // send projectile towards Red
        }
        if (Projectile.activeSelf)
        {
            // switch off when sufficiently close to Red
            //  Projectile.SetActive(false);

        }

        // 3. March Red between p3 and p4 at speed RedSpeed
        // AI says:
        Red.localPosition = Vector3.Lerp(p3.localPosition, p4.localPosition, Mathf.PingPong(Time.time * RedSpeed, 1));
        // now ignore the above and perform this with vectors we learned in class

        // 4. Draw the two lines between P1 and P2 and between p3 and p4
        SetTheLine(p1.localPosition, p2.localPosition, WhiteLine);
        SetTheLine(p3.localPosition, p4.localPosition, GreenLine);

    }
    
    // Implement this function: draws cylinder from p1 to p2
    void SetTheLine(Vector3 p1, Vector3 p2, GameObject line)
    {
    }   
}