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
		{
			Vector3 position = transform.position;
			Vector3 viewVertValue = SceneView.GetAllSceneCameras()[0].WorldToViewportPoint(position + v);
			string vert = $"v: {v}";
			string worldVert = $" wv: {position + v}";
			string viewVert = $" vv: {viewVertValue}";
			Handles.Label(position + v, vert + worldVert + viewVert);
		}
	}
}
