using UnityEngine;

public class ActivateCube : MonoBehaviour
{
    public GameObject cube; // �����ڱ༭����ָ��Cube����

    void Start()
    {
        // ����Ƿ���ָ��cube����
        if (cube != null)
        {
            cube.SetActive(true); // ��Cube��������Ϊactive
        }
        else
        {
            Debug.LogError("Cube����δָ����");
        }
    }
}
