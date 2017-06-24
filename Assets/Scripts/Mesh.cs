using UnityEngine;
using System.Collections;

[RequireComponent (typeof(MeshRenderer))]
[RequireComponent (typeof(MeshFilter))]
public class Mesh : MonoBehaviour
{
	private void Start ()
	{
		UnityEngine.Mesh mesh = new UnityEngine.Mesh ();
		mesh.vertices = new Vector3[] {
//			new Vector3 (0, 0, 0),
//			new Vector3 (4, 0, 0),
//			new Vector3 (0, 0, 0.7f),
//			new Vector3 (4, 0, 0.7f),
			new Vector3 (0, 0, 0),
			new Vector3 (4, 0, 0),
			new Vector3 (-3, 0, 15f),
			new Vector3 (1, 0, 15f),
		};
		mesh.triangles = new int[] {
			1, 2, 3,0, 2, 1
		};

		var filter = GetComponent<MeshFilter> ();
		filter.sharedMesh = mesh;
	}
	void FixedUpdate()
	{
		transform.position += new Vector3(0, 0, 120 / -3 / 5 * 1.5f * Time.deltaTime * 3);
	}
}