using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CreateWorld : MonoBehaviour
{
    Mesh mesh;



    Vector3[] vertices;
    int[] triangles;

    private int large = 30;
    private int mediuim = 20;
    private int small = 10;


    public int xSize = 20;
    public int zSize = 20;

    // Use this for initialization
    void Start()
    {

        if (enabled)
        {
            mesh = new Mesh();
            GetComponent<MeshFilter>().mesh = mesh;

            StartCoroutine(CreateChunck());
        }
       

    }


    // Update is called once per frame
    private void Update()
    {
        UpdateMesh();
    }



    IEnumerator CreateChunck()
    {

        vertices = new Vector3[(xSize + 1 + 1) * (zSize + 1 + 1)];


        for (int i = 0, z = 0; z <= zSize; z++)
        {

            for (int x = 0; x <= xSize; x++)
            {
                float y = Mathf.PerlinNoise(x * .3f, z * .3f) * 2f;
                vertices[i] = new Vector3(x, y, z);
                i++;

            }

        }

        triangles = new int[xSize * zSize * 6];


        int vert = 0;
        int tris = 0;

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {



                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 1;
                triangles[tris + 5] = vert + xSize + 2;
                //-----------------------------------//


                vert++;
                tris += 6;

                yield return new WaitForSeconds(.01f);
            }
        }
    }

    //IEnumerator CreateLand()
    //{
    //    for (int s = 0; s < mediuim; s++)
    //    {
    //        StartCoroutine(CreateChunck());
    //        s++;
    //        yield return new WaitForSeconds(.001f);
    //    }
    //}


    void UpdateMesh()
    {

        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }

    // Generates The most basic version of the world 
    private void GenerrateSurfce()
    {

    }

    // Generates The ores it the world 
    private void GenerrateOre()
    {

    }

    // Generates the extras
    private void GenerrateExtras()
    {

    }

}



