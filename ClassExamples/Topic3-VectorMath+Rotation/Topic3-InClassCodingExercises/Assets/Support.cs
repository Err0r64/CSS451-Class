using UnityEngine;

public class Support
{
    const float kNormalSize = 4f;
    const float kLineWidth = 0.3f;

    // Create a line (cylinder) with given name and color
    public static GameObject CreateLine(string name, Color color)
    {
        GameObject line = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        line.name = name;
        line.GetComponent<Renderer>().material.color = color;
        line.transform.localScale = new Vector3(kLineWidth, 1f, kLineWidth); // height will be adjusted later
        return line;
    }

    // Update a line (cylinder) to represent the line segment from p1 to p2
    public static void UpdateLine(Vector3 p1, Vector3 p2, GameObject line)
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

    // Draws normal vector at the plane center 
    // Assume the plane is Unity's default plane (size 10x10, normal +Y)
    public static void UpdatePlaneNormal(Transform plane, Vector3 normal, GameObject line)
    {
        Vector3 planeCenter = plane.localPosition;
        UpdateLine(planeCenter, planeCenter + kNormalSize * normal.normalized, line);
    }
}
