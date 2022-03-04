using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public int x;
    public int y;
    public int z;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        y = 10;
        z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (Time.deltaTime * x, Time.deltaTime * y, Time.deltaTime * z));
    }
}
//MEDIANTE EL USO DEL TRANSFORM.ROTATE, EL OBJETO GIRA EN EL EJE Y