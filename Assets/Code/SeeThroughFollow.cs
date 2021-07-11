using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThroughFollow : MonoBehaviour
{

    public static int PosID = Shader.PropertyToID("_Position");
    public static int SizeID = Shader.PropertyToID("_Size");
   // public static int SphereFOID = Shader.PropertyToID("_SphereFallOff");
   // public static int OpacityID = Shader.PropertyToID("_Opacity");


    public Material WallMaterial;
    public Camera Camera;
    public LayerMask mask;

    Vector3 dir;
    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        dir = Camera.transform.position - transform.position;
        ray = new Ray(transform.position, dir.normalized);

        
        if(Physics.Raycast(ray, 5000, mask))
        {
            WallMaterial.SetFloat(SizeID, 1);
        }
        else 
        { 
            WallMaterial.SetFloat(SizeID, 0); 
        }
        


        var view = Camera.WorldToViewportPoint(transform.position);

        WallMaterial.SetVector(PosID, view);
    }
}
