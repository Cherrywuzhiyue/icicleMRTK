using UnityEngine;
using TMPro; // 使用 TextMeshPro

public class ScatterPlotCreator : MonoBehaviour
{
    public GameObject spherePrefab; // 设置一个球体预制体
    public GameObject textPrefab; // TextMeshPro 文本预制体
    public GameObject tipPrefab; // 箭头预制体


    // 坐标轴设置
    public GameObject axisPrefab; // 轴线预制体
    public Vector3 xAxisLength = new Vector3(10, 0, 0); // X轴长度和方向
    public Vector3 yAxisLength = new Vector3(0, 10, 0); // Y轴长度和方向
    private GameObject scatterPlotParent;
    private float minX = 0f;
    private float maxX = 0f;
    private float minY = 0f;
    private float maxY = 0f;


    void Start()
    {
        scatterPlotParent = this.gameObject;
        CreateScatterPlot();
        DrawAxes();
    }

    void CreateScatterPlot()
    {
        TextAsset data = Resources.Load<TextAsset>("fangjidata0504");
        string[] lines = data.text.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string[] row = lines[i].Split(',');
            if (row.Length >= 4)
            {
                float x = float.Parse(row[0]);
                float y = -1*float.Parse(row[1]);
                UpdateMinMaxValues(x, y);
            }
        }
        for (int i = 1; i < lines.Length; i++)
        {
            string[] row = lines[i].Split(',');
            if (row.Length >= 4)
            {
                float x = float.Parse(row[0]);
                float y = -1*float.Parse(row[1]);
                string herb = row[2];
                //Color color = ParseColor(row[3]);
                float normalizedX = NormalizeValue(x, minX, maxX, 0, (xAxisLength.x-1));
                float normalizedY = NormalizeValue(y, minY, maxY, 0, (yAxisLength.y-1));

                GameObject sphere = Instantiate(spherePrefab, new Vector3(normalizedX+0.5f, normalizedY+0.5f, 0), Quaternion.identity);
                sphere.name = herb;
                sphere.transform.SetParent(scatterPlotParent.transform); // 设置 parent

                // 创建并设置文本标签
                GameObject textGO = Instantiate(textPrefab, sphere.transform.position + new Vector3(0.1f, 0, 0), Quaternion.identity);
                TextMesh textMesh = textGO.GetComponent<TextMesh>();

                if (textMesh != null)
                {
                    textMesh.text = herb;
                    textMesh.fontSize = 80; // 设置字体大小，您可以根据需要调整这个值

                    // 设置textGO的大小
                    float scale = 0.03f; // 假设您想将textGO缩小到原来的0.1倍
                    textGO.transform.localScale = new Vector3(scale, scale, scale);
                }
                else
                {
                    Debug.LogError("TextMesh component not found on textPrefab");
                }

                textGO.transform.SetParent(sphere.transform); // 将文本作为球体的子对象
            }
        }
    }
    private void UpdateMinMaxValues(float x, float y)
    {
        if (x < minX) minX = x;
        if (x > maxX) maxX = x;
        if (y < minY) minY = y;
        if (y > maxY) maxY = y;
    }

    private float NormalizeValue(float value, float min, float max, float newMin, float newMax)
    {
        return (value - min) / (max - min) * (newMax - newMin) + newMin;
    }
    void DrawAxes()
    {
        // 绘制 X 轴
        GameObject xAxis = Instantiate(axisPrefab, Vector3.zero, Quaternion.Euler(0, 0, 90));
        xAxis.transform.SetParent(scatterPlotParent.transform);
        xAxis.transform.localScale = new Vector3(0.05f, xAxisLength.x / 2, 0.05f); // 调整圆柱体直径和长度
        xAxis.transform.localPosition = new Vector3(xAxisLength.x / 2, 0, 0); // 调整圆柱体位置
        GameObject xAxisTip = Instantiate(tipPrefab, new Vector3(xAxisLength.x, 0, 0), Quaternion.Euler(0, 0, -90));
        xAxisTip.transform.SetParent(xAxis.transform);

        // 绘制 Y 轴
        GameObject yAxis = Instantiate(axisPrefab, Vector3.zero, Quaternion.identity);
        yAxis.transform.SetParent(scatterPlotParent.transform);
        yAxis.transform.localScale = new Vector3(0.05f, yAxisLength.y / 2, 0.05f);
        yAxis.transform.localPosition = new Vector3(0, yAxisLength.y / 2, 0);
        GameObject yAxisTip = Instantiate(tipPrefab, new Vector3(0, yAxisLength.y, 0), Quaternion.identity);
        yAxisTip.transform.SetParent(yAxis.transform);
    }

}
