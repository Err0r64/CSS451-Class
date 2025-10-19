
using UnityEngine;

public class EX5_ReflectionExercise : MonoBehaviour
{
    public Transform WhitePlane;

    public Transform P1; // Point P1 of line
    public Transform P2; // Point P2 of line
    public Transform Pt; // Pt, line intersect with Plane
                         //      to show the reflection point on the plane


    public Transform AxisFrame = null;
    public bool ShowAxisFrame = true;

    public bool ShowAllLines = false;
    // 
    private GameObject PlaneNormalLine = null;  // normal of the plane
    
    private GameObject LineP1P2 = null; // shows the line from P1 to P2
    private GameObject ReflectionLine = null; // shows the reflection line
    private GameObject VectorM = null; // perpendicular vector from P1 to the normal vector
    private GameObject NormalAtPt = null; // draws the normal vector at Pt
    
        

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(WhitePlane != null);
        Debug.Assert(P1 != null);
        Debug.Assert(P2 != null);
        Debug.Assert(Pt != null);
        Debug.Assert(AxisFrame != null);

        PlaneNormalLine = Support.CreateLine("PlaneNormal", Color.red);
        PlaneNormalLine.SetActive(false);

        LineP1P2 = Support.CreateLine("LineP1P2", Color.white);
        ReflectionLine = Support.CreateLine("ReflectionLine", Color.green);

        VectorM = Support.CreateLine("VectorM", Color.yellow);
        VectorM.SetActive(ShowAllLines);
        NormalAtPt = Support.CreateLine("NormalAtPt", Color.red); 
        NormalAtPt.SetActive(ShowAllLines);
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

        // 1. Update the whiteplane normal
        Support.UpdatePlaneNormal(WhitePlane, n, PlaneNormalLine);
        Support.UpdateLine(P1.localPosition, P2.localPosition, LineP1P2);

        // Line form by P1 to P2
        // Intersection this line with WhitePlane: at Pt
        // Reflect the line at Pt across the plane normal
        //
        // One step at a time, when done with each step, 
        //       make sure answer is correct
        //       test thoroughly by moving P1, P2 and the plane around 
        // Next steps to do:
        //   1. Compute and show Pt, the intersection point of line and plane
        //   2. Compute the reflection direction, show as line (will show at origin)
        //   3. Compute reflection at Pt
        //   4. Reflect only if P2 is in front of the plane
        //   5. Set P2 color to Green if reflected, Red if not reflected
        //   
        // The lines: start drawing as soon as possible to show correct
        //            worry about user control of line visibility last
        


    }
}