using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class DebugVertices : MonoBehaviour {
	private Mesh _mesh;
	private Vector3[] _vertices;

	void OnDrawGizmos()
	{
		if (_vertices == null)
		{
			_mesh = GetComponent<MeshFilter>().sharedMesh;
			_vertices = _mesh.vertices;
		}
		foreach (Vector3 v in _vertices)
            Handles.Label(transform.position + v, $"v: {v}");
	}
}
