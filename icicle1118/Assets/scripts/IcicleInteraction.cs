using UnityEngine;
using TMPro; // ���ʹ�� TextMeshPro


public class IcicleInteraction : MonoBehaviour
{
    public Canvas textCanvas; // ָ�����洴���� Canvas
    public TextMesh infoText; // ָ�� Canvas �µ� TextMeshPro �ı����

    void Start()
    {
        // ȷ���ı����ʼʱ���ɼ�
        textCanvas.gameObject.SetActive(false);
    }

    // ���û�����򴥷�ĳ�� icicle prefab ʱ����
    public void OnIcicleClicked(Node icicleNode)
    {
        // ��ʾ�ı��򲢸�����Ϣ
        infoText.text = icicleNode.fangji;
        textCanvas.gameObject.SetActive(true);

        // ���ı�������ں��ʵ�λ�ã����� icicle ͼ���·�
        //textCanvas.transform.position = /* ����λ�� */;
    }

    // ��ѡ������һ�������������ı���
    public void HideInfoText()
    {
        textCanvas.gameObject.SetActive(false);
    }
}
