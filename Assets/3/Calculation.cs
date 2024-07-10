using UnityEngine;

public class LinePlaneIntersection : MonoBehaviour
{
    // Точка на площині
    public Vector3 planePoint = new Vector3(0, 0, 0);
    
    // Нормальний вектор площини
    public Vector3 planeNormal = new Vector3(0, 1, 0);
    
    // Точка 1 на прямій
    public Vector3 linePoint1 = new Vector3(1, 1, 1);
    
    // Точка 2 на прямій
    public Vector3 linePoint2 = new Vector3(1, -1, 1);
    
    void Start()
    {
        Vector3 intersection;
        if (FindIntersection(out intersection))
        {
            Debug.Log("Точка перетину: " + intersection);
        }
        else
        {
            Debug.Log("Пряма та площина не перетинаються або пряма лежить у площині.");
        }
    }
    
    bool FindIntersection(out Vector3 intersection)
    {
        intersection = Vector3.zero;

        Vector3 lineDirection = linePoint2 - linePoint1;
        float dotProduct = Vector3.Dot(planeNormal, lineDirection);

        // Перевірка, чи пряма не паралельна площині
        if (Mathf.Abs(dotProduct) > Mathf.Epsilon)
        {
            Vector3 lineToPlane = planePoint - linePoint1;
            float t = Vector3.Dot(lineToPlane, planeNormal) / dotProduct;
            intersection = linePoint1 + t * lineDirection;
            return true;
        }

        return false;
    }
}