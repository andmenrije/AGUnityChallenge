using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour, IShape
{
    public Vector2[] shapeVector;
    public int[] triads;
    public Color shapeColor = Color.white;

    [SerializeField]
    private Material shapeMat;

    public void Draw()
    {


        Mesh mesh = new Mesh();

        Vector3[] vertices3 = new Vector3[shapeVector.Length];

        for(int i = 0; i < shapeVector.Length; ++i)
        {
            vertices3[i] = new Vector3(shapeVector[i].x, shapeVector[i].y);
        }

        mesh.vertices = vertices3;
        mesh.triangles = triads;
        shapeMat = GetComponent<MeshRenderer>().material;
        GetComponent<MeshFilter>().mesh = mesh;
    }

    public void SetColor(Color newColor)
    {
        shapeMat.color = newColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        Draw();
    }

    // Update is called once per frame
    void Update()
    {
        // TEST
        /*
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            SetColor(UnityEngine.Random.ColorHSV());
        }
        */
    }
}
