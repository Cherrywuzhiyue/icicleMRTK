using UnityEngine;

public class AdjustCubeVertices : MonoBehaviour
{
    void Start()
    {
        // ��ȡ Cube �� MeshFilter ���
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        if (meshFilter != null)
        {
            // ��ȡ Cube �� Mesh
            Mesh mesh = meshFilter.mesh;

            // ��ȡ Cube �Ķ�������
            Vector3[] vertices = mesh.vertices;

            // �ҵ����� x �� y ����
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            for (int i = 0; i < vertices.Length; i++)
            {
                maxX = Mathf.Max(maxX, vertices[i].x);
                maxY = Mathf.Max(maxY, vertices[i].y);
            }

            // ����ƫ�����������϶����������ǰλ��
            Vector3 offset = new Vector3(transform.position.x - maxX, transform.position.y - maxY, 0f);

            // ��������λ��
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] += offset;
            }

            // ���޸ĺ�Ķ�������Ӧ�û� Mesh
            mesh.vertices = vertices;

            // ���� MeshCollider��������ڵĻ�
            MeshCollider meshCollider = GetComponent<MeshCollider>();
            if (meshCollider != null)
            {
                meshCollider.sharedMesh = null;
                meshCollider.sharedMesh = mesh;
            }
        }
    }
}
