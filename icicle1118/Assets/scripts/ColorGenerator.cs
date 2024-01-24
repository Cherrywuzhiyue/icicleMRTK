using UnityEngine;
using System.Collections.Generic;

public class ColorGenerator : MonoBehaviour
{
    // �洢�ڵ���������ɫ��ӳ���ϵ
    private Dictionary<string, Color> colorMap = new Dictionary<string, Color>();

    // ���������ɫ���ɺ���
    public Color GenerateRandomColor(string nodeName)
    {
        // ����Ѿ�Ϊ�ýڵ����ɹ���ɫ��ֱ�ӷ��ش洢����ɫ
        if (colorMap.ContainsKey(nodeName))
        {
            return colorMap[nodeName];
        }

        // ��������һ���µ������ɫ
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        // �������洢�����ɫ
        Color randomColor = new Color(r, g, b);
        colorMap[nodeName] = randomColor;

        return randomColor;
    }
}
