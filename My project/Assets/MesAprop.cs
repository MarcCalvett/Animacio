using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class MesAprop : MonoBehaviour
{
    //EX1

    public struct GameobjectsInfo
    {
        public GameObject gObject;
        public float angleWithCamera;        
    }

    GameobjectsInfo[] cubes;
    int nearCubeInListPos = -1;

    //EX2
    [SerializeField]
    List<Vector3>points = new List<Vector3>();

    //EX3
    [SerializeField]
    GameObject cube, plane;
    [SerializeField]
    bool fall = false;
    Vector3 vi = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //EX1
        GameObject[] cubesScene = GameObject.FindGameObjectsWithTag("cube");
        cubes = new GameobjectsInfo[cubesScene.Length];

        for(int i = 0; i < cubesScene.Length; i++)
        {
            GameobjectsInfo newCube = new GameobjectsInfo();
            newCube.gObject = cubesScene[i];
            cubes[i] = newCube;
        }
        
        //EX2
        //points.Add(new Vector3(0, 3, 2));
        //points.Add(new Vector3(1, 4, 1));
        //points.Add(new Vector3(2, 6, 8));

        //EX3

    }

    // Update is called once per frame
    void Update()
    {
        //EX1
        for (int i = 0; i < cubes.Count(); i++)
        {                    
            Vector3 distanciaCubCamara = this.transform.position - cubes[i].gObject.transform.position;
            cubes[i].angleWithCamera = Vector3.Dot(transform.forward, distanciaCubCamara.normalized)/ (transform.forward.magnitude * distanciaCubCamara.magnitude);
                
            if(nearCubeInListPos < 0 || cubes[i].angleWithCamera < cubes[nearCubeInListPos].angleWithCamera)
            {
                nearCubeInListPos = i;
            }                
            
        }

        for (int i = 0; i < cubes.Count(); i++)
        {
            if(i ==  nearCubeInListPos)            
                cubes[i].gObject.GetComponent<Renderer>().material.color = Color.red;            
            else
                cubes[i].gObject.GetComponent<Renderer>().material.color = Color.white;
        }

        //EX3
        //if (fall && cube.transform.position.y >= 0)
        //{
        //    float h = cube.transform.position.y;

            //    vi += Time.deltaTime * Physics.gravity;

            //    h += Time.deltaTime * vi.y;
            //    Vector3 newTransform = new Vector3(cube.transform.position.x, h, cube.transform.position.z);
            //    cube.transform.position = newTransform;

        //}

    }

    private void OnDrawGizmos()
    {
        //EX2
        //Gizmos.DrawLine(points[0], points[1]);
        //Gizmos.DrawLine(points[0], points[2]);
        //Gizmos.DrawLine(points[1], points[2]);

        //Vector3 perpendicular = Vector3.Cross(points[1] - points[0], points[2] - points[0]);
        //perpendicular = perpendicular.normalized;

        //Gizmos.DrawLine(points[0], points[0] + perpendicular);
        
        Gizmos.DrawLine(transform.position, transform.position + transform.forward *100);
        
    }
}
