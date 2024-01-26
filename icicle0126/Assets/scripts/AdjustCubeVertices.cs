using UnityEngine;

public class AdjustCubeVertices : MonoBehaviour
{
    void Start()
    {
        // 获取 Cube 的 MeshFilter 组件
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        if (meshFilter != null)
        {
            // 获取 Cube 的 Mesh
            Mesh mesh = meshFilter.mesh;

            // 获取 Cube 的顶点数组
            Vector3[] vertices = mesh.vertices;

            // 找到最大的 x 和 y 坐标
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            for (int i = 0; i < vertices.Length; i++)
            {
                maxX = Mathf.Max(maxX, vertices[i].x);
                maxY = Mathf.Max(maxY, vertices[i].y);
            }

            // 计算偏移量，将左上顶点调整到当前位置
            Vector3 offset = new Vector3(transform.position.x - maxX, transform.position.y - maxY, 0f);

            // 调整顶点位置
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] += offset;
            }

            // 将修改后的顶点数组应用回 Mesh
            mesh.vertices = vertices;

            // 更新 MeshCollider，如果存在的话
            MeshCollider meshCollider = GetComponent<MeshCollider>();
            if (meshCollider != null)
            {
                meshCollider.sharedMesh = null;
                meshCollider.sharedMesh = mesh;
            }
        }
    }
}
