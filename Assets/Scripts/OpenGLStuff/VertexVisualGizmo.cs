using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexVisualGizmo : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;
        Vector3[] vertices = mesh.vertices;

        foreach (var vert in mesh.vertices)
        {
            Gizmos.DrawWireSphere(transform.TransformPoint(vert), 0.1f);
        }
        //vertices.Gizmos.DrawWireSphere(transform.TransformPoint(vertices), 0.2f);
    }
    
}
