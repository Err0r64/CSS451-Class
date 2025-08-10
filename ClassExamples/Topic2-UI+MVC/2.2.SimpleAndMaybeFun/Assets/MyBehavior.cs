using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBehavior : MonoBehaviour
{
    private float mSpeed = 5f;
    private Vector3 mTarget = Vector3.zero;

    private const string kYellow = "Yellow";
    private const string kRed = "Red";
    private const string kBlack = "Black";
    private const string kGreen = "Green";
    private const string kBlue = "Blue";


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTarget(KeyCode.Y, kYellow);
        UpdateTarget(KeyCode.R, kRed);
        UpdateTarget(KeyCode.K, kBlack);
        UpdateTarget(KeyCode.B, kBlue);
        UpdateTarget(KeyCode.G, kGreen);
        
        // Debug.Log("Target=" + mTarget + "  Speed=" + mSpeed);
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, mTarget, mSpeed*Time.smoothDeltaTime);
    }

    private void UpdateTarget(KeyCode k, string n) {
        if (Input.GetKeyDown(k)) {
            GameObject g = GameObject.Find(n);
            if (g != null) {
                mTarget = g.transform.localPosition;
                GetComponent<Renderer>().material.color = g.GetComponent<Renderer>().material.color;
            }
        }
    }

    // Need to learn: 
    //      UI: 
    //          define Material, change color, and assign to an object
    //          RMB over MainCamera: align View
    //      Vector3.MoveTowards()
    //      Input.GetKeyDown()
    // Should take about 4 seconds to travel along the edge from one corner to another
}
