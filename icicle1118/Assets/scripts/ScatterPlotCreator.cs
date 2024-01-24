using UnityEngine;
using TMPro; // ʹ�� TextMeshPro

public class ScatterPlotCreator : MonoBehaviour
{
    public GameObject spherePrefab; // ����һ������Ԥ����
    public GameObject textPrefab; // TextMeshPro �ı�Ԥ����
    public GameObject tipPrefab; // ��ͷԤ����


    // ����������
    public GameObject axisPrefab; // ����Ԥ����
    public Vector3 xAxisLength = new Vector3(10, 0, 0); // X�᳤�Ⱥͷ���
    public Vector3 yAxisLength = new Vector3(0, 10, 0); // Y�᳤�Ⱥͷ���
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
                sphere.transform.SetParent(scatterPlotParent.transform); // ���� parent

                // �����������ı���ǩ
                GameObject textGO = Instantiate(textPrefab, sphere.transform.position + new Vector3(0.1f, 0, 0), Quaternion.identity);
                TextMesh textMesh = textGO.GetComponent<TextMesh>();

                if (textMesh != null)
                {
                    textMesh.text = herb;
                    textMesh.fontSize = 80; // ���������С�������Ը�����Ҫ�������ֵ

                    // ����textGO�Ĵ�С
                    float scale = 0.03f; // �������뽫textGO��С��ԭ����0.1��
                    textGO.transform.localScale = new Vector3(scale, scale, scale);
                }
                else
                {
                    Debug.LogError("TextMesh component not found on textPrefab");
                }

                textGO.transform.SetParent(sphere.transform); // ���ı���Ϊ������Ӷ���
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
        // ���� X ��
        GameObject xAxis = Instantiate(axisPrefab, Vector3.zero, Quaternion.Euler(0, 0, 90));
        xAxis.transform.SetParent(scatterPlotParent.transform);
        xAxis.transform.localScale = new Vector3(0.05f, xAxisLength.x / 2, 0.05f); // ����Բ����ֱ���ͳ���
        xAxis.transform.localPosition = new Vector3(xAxisLength.x / 2, 0, 0); // ����Բ����λ��
        GameObject xAxisTip = Instantiate(tipPrefab, new Vector3(xAxisLength.x, 0, 0), Quaternion.Euler(0, 0, -90));
        xAxisTip.transform.SetParent(xAxis.transform);

        // ���� Y ��
        GameObject yAxis = Instantiate(axisPrefab, Vector3.zero, Quaternion.identity);
        yAxis.transform.SetParent(scatterPlotParent.transform);
        yAxis.transform.localScale = new Vector3(0.05f, yAxisLength.y / 2, 0.05f);
        yAxis.transform.localPosition = new Vector3(0, yAxisLength.y / 2, 0);
        GameObject yAxisTip = Instantiate(tipPrefab, new Vector3(0, yAxisLength.y, 0), Quaternion.identity);
        yAxisTip.transform.SetParent(yAxis.transform);
    }

}
