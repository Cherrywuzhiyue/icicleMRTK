using UnityEngine;

public class ChangeScaleAfterDelay : MonoBehaviour
{
    public Vector3 newScale = new Vector3(1.0f, 1.0f, 1.0f); // �����µ�����ֵ
    public float delay = 1.0f; // �ӳ�ʱ�䣬����Ϊ��λ

    void Start()
    {
        // ���ӳ�ʱ������ChangeScale����
        Invoke("ChangeScale", delay);
    }

    void ChangeScale()
    {
        // ���������scale
        transform.localScale = newScale;
    }
}
