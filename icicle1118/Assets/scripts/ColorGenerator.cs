using UnityEngine;
using System.Collections.Generic;

public class ColorGenerator : MonoBehaviour
{
    // 存储节点名称与颜色的映射关系
    private Dictionary<string, Color> colorMap = new Dictionary<string, Color>();

    // 定义随机颜色生成函数
    public Color GenerateRandomColor(string nodeName)
    {
        // 如果已经为该节点生成过颜色，直接返回存储的颜色
        if (colorMap.ContainsKey(nodeName))
        {
            return colorMap[nodeName];
        }

        // 否则，生成一个新的随机颜色
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        // 创建并存储随机颜色
        Color randomColor = new Color(r, g, b);
        colorMap[nodeName] = randomColor;

        return randomColor;
    }
}
