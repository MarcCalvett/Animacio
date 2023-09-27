using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat6 : MonoBehaviour
{
    [SerializeField]
    GameObject cube1;
    [SerializeField]
    GameObject cube2;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 axisF = Vector3.Cross(cube2.transform.forward, cube1.transform.forward);
        float angleF = Mathf.Acos(Vector3.Dot(cube1.transform.forward, cube2.transform.forward)) * Mathf.Rad2Deg;

        cube2.transform.Rotate(axisF, angleF, Space.World);

        Vector3 axisX = Vector3.Cross(cube2.transform.right, cube1.transform.right);
        float angleX = Mathf.Acos(Vector3.Dot(cube1.transform.right, cube2.transform.right)) * Mathf.Rad2Deg;

        cube2.transform.Rotate(axisX, angleX, Space.World);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
