using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShape : MonoBehaviour {

    //RequireComponent(typeof(MeshFilter));

	// Use this for initialization
	void Start ()
    {
        //CreateTriangle();
        CreateQuad();
        //CreatePentagon();
    }

    void CreateTriangle()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        // Vertices
        // locations of vertices
        var verts = new Vector3[3];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(1, 0, 0);
        verts[2] = new Vector3(0, 1, 0);
        mesh.vertices = verts;

        // Indices
        // determines which vertices make up an individual triangle
        var indices = new int[6];

        indices[0] = 0;
        indices[1] = 2;
        indices[2] = 1;

        mesh.triangles = indices;

        // Normals
        // describes how light bounces off the surface (at the vertex level)
        var norms = new Vector3[3];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;

        mesh.normals = norms;

        // UVs, STs
        // defines how textures are mapped onto the surface
        var UVs = new Vector2[3];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(1, 0);
        UVs[2] = new Vector2(0, 1);

        mesh.uv = UVs;

    }

    void CreateQuad()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        // Vertices
        // locations of vertices
        var verts = new Vector3[6];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(0, 1, 0);
        verts[2] = new Vector3(1, 0, 0);
        verts[3] = new Vector3(1, 1, 0);
        verts[4] = new Vector3(1, 0, 0);
        verts[5] = new Vector3(0, 1, 0);
        mesh.vertices = verts;

        // Indices
        // determines which vertices make up an individual triangle
        var indices = new int[6];

        indices[0] = 0;
        indices[1] = 5;
        indices[2] = 4;
        indices[3] = 3;
        indices[4] = 2;
        indices[5] = 1;

        mesh.triangles = indices;

        // Normals
        // describes how light bounces off the surface (at the vertex level)
        var norms = new Vector3[6];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;
        norms[3] = -Vector3.forward;
        norms[4] = -Vector3.forward;
        norms[5] = -Vector3.forward;
        mesh.normals = norms;

        // UVs, STs
        // defines how textures are mapped onto the surface
        var UVs = new Vector2[6];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(1, 0);
        UVs[2] = new Vector2(0, 1);
        UVs[3] = new Vector2(1, 1);
        UVs[4] = new Vector2(0, 1);
        UVs[5] = new Vector2(1, 0);
        mesh.uv = UVs;

    }

    void CreatePentagon()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        // Vertices
        // locations of vertices
        var verts = new Vector3[15];

        //Bottom Triangle
        verts[0] = new Vector3(0, 1.5f, 0);
        verts[1] = new Vector3(-1, 0, 0);
        verts[2] = new Vector3(1, 0, 0);

        verts[3] = new Vector3(0, 1.5f, 0);
        verts[4] = new Vector3(-1.5f, 2, 0);
        verts[5] = new Vector3(-1, 0, 0);
        

        verts[6] = new Vector3(0, 1.5f, 0);
        verts[7] = new Vector3(1, 0, 0);
        verts[8] = new Vector3(1.5f, 2, 0);

        verts[9] = new Vector3(0, 1.5f, 0);
        verts[10] = new Vector3(1.5f, 2, 0);
        verts[11] = new Vector3(0, 3, 0);

        verts[12] = new Vector3(0, 1.5f, 0);
        verts[13] = new Vector3(0, 3, 0);
        verts[14] = new Vector3(-1.5f, 2, 0);
        

        mesh.vertices = verts;

        // Indices
        // determines which vertices make up an individual triangle
        var indices = new int[18];

        indices[0] = 0;
        indices[1] = 14;
        indices[2] = 13;
        indices[3] = 12;
        indices[4] = 11;
        indices[5] = 10;
        indices[6] = 9;
        indices[7] = 8;
        indices[8] = 7;
        indices[9] = 6;
        indices[10] = 5;
        indices[11] = 4;
        indices[12] = 3;
        indices[13] = 2;
        indices[14] = 1;

        mesh.triangles = indices;

        // Normals
        // describes how light bounces off the surface (at the vertex level)
        var norms = new Vector3[15];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;

        mesh.normals = norms;

        // UVs, STs
        // defines how textures are mapped onto the surface
        var UVs = new Vector2[3];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(1, 0);
        UVs[2] = new Vector2(0, 1);

        //mesh.uv = UVs;
    }


   void Create3DCube()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        // Vertices
        // locations of vertices
        var verts = new Vector3[6];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(1, 0, 0);
        verts[2] = new Vector3(0, 1, 0);
        verts[3] = new Vector3(1, 1, 0);
        verts[4] = new Vector3(0, 1, 0);
        verts[5] = new Vector3(1, 0, 0);
        mesh.vertices = verts;

        // Indices
        // determines which vertices make up an individual triangle
        var indices = new int[6];

        indices[0] = 0;
        indices[1] = 5;
        indices[2] = 4;
        indices[3] = 3;
        indices[4] = 2;
        indices[5] = 1;

        mesh.triangles = indices;

        // Normals
        // describes how light bounces off the surface (at the vertex level)
        var norms = new Vector3[6];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;
        norms[3] = -Vector3.forward;
        norms[4] = -Vector3.forward;
        norms[5] = -Vector3.forward;
        mesh.normals = norms;

        // UVs, STs
        // defines how textures are mapped onto the surface
        var UVs = new Vector2[4];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(1, 0);
        UVs[2] = new Vector2(0, 1);
        UVs[3] = new Vector2(1, 1);
        // mesh.uv = UVs;

    }
}
