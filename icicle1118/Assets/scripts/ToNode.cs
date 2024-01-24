using System.Collections.Generic;
using System.Linq;
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;
using System.IO;
using System.Net.Http;
#if UNITY_WSA && !UNITY_EDITOR
using Windows.Storage; // UWP �����ռ�
using System.IO;
#endif
using System.Threading.Tasks;


public class ToNode : MonoBehaviour
{
    [System.Serializable]
    public class Node
    {
        public string name;
        public float value;
        public string name2;
        public string colour;
        public string fangji;
        public Node[] children;

        public float x { get; set; }
        public float y { get; set; }
        public float width { get; set; }
        public float height { get; set; }

        //public float Value { get; set; }
        public float Level { get; set; }

        // ���캯��

        
    }
    private Node rootNode;
    public GameObject iciclePrefab;

    private Dictionary<string, Color> colorMap = new Dictionary<string, Color>();

    public Node LoadJsonAsNode(string json)
    {
        return JsonUtility.FromJson<Node>(json);
    }
    public void SaveNodeToFile(Node node, string filePath)
    {
        string content = NodeToString(node);
        System.IO.File.WriteAllText(filePath, content);
    }

    private string NodeToString(Node node, int depth = 0)
    {
        string indent = new String(' ', depth * 4); // ÿ���������� 4 ���ո�
        string childIndent = new String(' ', (depth + 1) * 4);

        string nodeRepresentation = $"{indent}new Node\n{indent}{{\n";
        nodeRepresentation += $"{childIndent}name = \"{node.name}\",\n";
        nodeRepresentation += $"{childIndent}value = {node.value},\n";
        nodeRepresentation += $"{childIndent}name2 = \"{node.name2}\",\n";
        nodeRepresentation += $"{childIndent}colour = \"{node.colour}\",\n";
        nodeRepresentation += $"{childIndent}fangji = \"{node.fangji}\",\n";

        if (node.children != null && node.children.Length > 0)
        {
            nodeRepresentation += $"{childIndent}children = new Node[]\n{childIndent}{{\n";
            foreach (var child in node.children)
            {
                nodeRepresentation += NodeToString(child, depth + 2) + ",\n";
            }
            nodeRepresentation += $"{childIndent}}}\n";
        }
        nodeRepresentation += $"{indent}}}";

        return nodeRepresentation;
    }

    void Start()
    {

        LoadJson();
        // ���ļ��ж�ȡ JSON ����
        string jsonPath = "Assets/data/byherb.json"; // �滻Ϊʵ�ʵ��ļ�·��
        string jsonData = System.IO.File.ReadAllText(jsonPath);

        //// �� JSON �ַ�������Ϊ Node ����
        //Node rootNode = JsonUtility.FromJson<Node>(jsonData);
        string jsonString = jsonData; // ���ļ���������Դ��ȡ�� JSON �ַ���
Node rootNode = LoadJsonAsNode(jsonString);
        SaveNodeToFile(rootNode, "Assets/data/output.txt");
        //NodeLevel(rootNode, 0);
        //Computeroot(rootNode, 1, 1, 30, 10);
        ////PrintNodeLevel(rootNode, 0);
        //ComputeLayout2(rootNode, 1, 1, 30, 10);
        //DrawIcicleCube(rootNode, Quaternion.identity);
        //DrawIcicleCube(rootNode.children[0], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[0].children[0], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[0].children[0].children[0], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[0].children[0].children[1], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[0].children[1], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[1], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[2], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[3], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[3].children[0], Quaternion.identity);
        //DrawIcicleCube(rootNode.children[3].children[1], Quaternion.identity);
        //DrawGraph(rootNode, 0);

        // �ڸ��ڵ��ϵ��õݹ麯��


    }
    public async void LoadJson()
    {
        string jsonData = await ReadJsonFileAsync("byherb.json");
        if (!string.IsNullOrEmpty(jsonData))
        {
            rootNode = JsonUtility.FromJson<Node>(jsonData);
            // ���� rootNode
        }
    }

  
#if UNITY_WSA && !UNITY_EDITOR
    // �ⲿ�ִ���ֻ�ڱ���Ϊ UWP Ӧ��ʱִ��

   



    private async Task<string> ReadJsonFileAsync(string fileName)
    {
   
        try
        {
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///Assets/StreamingAssets/{fileName}"));
            using (StreamReader reader = new StreamReader(await file.OpenStreamForReadAsync()))
            {
                return await reader.ReadToEndAsync();
            }
        }
        catch (FileNotFoundException ex)
        {
            Debug.LogError($"File not found: {fileName}, Exception: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Debug.LogError($"Exception while reading the file: {ex.Message}");
            return null;
        }
    }
#else
    // �� UWP ƽ̨�ı�ѡʵ�֣������� Unity �༭���У�
    private async Task<string> ReadJsonFileAsync(string fileName)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);
        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath);
        }
        else
        {
            Debug.LogError("File not found: " + filePath);
            return null;
        }
    }
#endif

    void DrawIcicleGraph(Node node, Vector3 position, Quaternion rotation, int level = 1)
    {
        // ʵ���� iciclePrefab
        GameObject icicle = Instantiate(iciclePrefab, position, rotation, transform);

        // ���� icicle �����ԣ���ɫ���ߴ�ȣ�
        // ������Ҫ����ʵ�ʵ����ݽṹ���е���

        // ���һ���յ��� GameObject ���ڱ�ע�ڵ�����
        GameObject textLabel = new GameObject("TextLabel");
        textLabel.transform.parent = icicle.transform;
        textLabel.transform.localPosition = Vector3.zero;
        //textLabel.transform.localSacle = new Vector3(0.5f,0.5f,0.5f);

        // ��� TextMesh ���� GameObject ��
        TextMesh textMesh = textLabel.AddComponent<TextMesh>();
        textMesh.text = node.name; // ʹ�ýڵ������
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 10;

        // ��ȡ��ǰ�ڵ���ӽڵ�����
        Node[] children = node.children;


        int num = CountNodes(node);

        //float icicleWidth = Mathf.Clamp(1.0f - num * 0.1f, 0.1f, 1.0f);
        //float icicleWidth = num;
        float icicleWidth = CountLeafNodes(node) * 1.0f;

        // ���� iciclePrefab �Ŀ��
        icicle.transform.localScale = new Vector3(icicleWidth, 1.0f, 1.0f);


        // �����ӽڵ�֮��ļ��
        float childSpacing = 1.0f / icicleWidth;
        //Debug.Log(node.name+num+level+ childSpacing);
        //Debug.Log(CountLeafNodes(node));

        float posx = 0;
        // �����ӽڵ㲢�ݹ����
        for (int i = 0; i < children.Length; i++)
        {
            //Debug.Log(CountLeafNodes(children[i])+","+i);
            if (i != 0)
            {
                //Debug.Log(CountNodes(children[0]) + " ," + CountNodes(children[1]) + "," + posx);
                if (CountLeafNodes(children[i - 1]) != CountLeafNodes(children[i]))
                {
                    posx = (CountLeafNodes(children[i - 1]) - CountLeafNodes(children[i])) / 2;
                    //Debug.Log(CountLeafNodes(children[i - 1])+" ," +CountLeafNodes(children[i])+","+ posx);
                }
                else
                {
                    posx = position.x + CountLeafNodes(children[i]) / 2;
                }
            }
            //Debug.Log("POSX"+posx);



            Vector3 childPosition = new Vector3(posx, 0, 0) + new Vector3(0, level, position.z);


            // �����ӽڵ����λ��
            // Vector3 childPosition = new Vector3(i * icicleWidth, 0, 0)+ new Vector3(position.x, level, position.z) - new Vector3(icicle.transform.localScale.x/4, 0, 0);


            // �ݹ����
            DrawIcicleGraph(children[i], childPosition, Quaternion.identity, level + 1);
        }
    }

    int CountNodes(Node node)
    {
        int count = 1; // ��ǰ�ڵ�
        if (node.children != null)
        {
            foreach (var child in node.children)
            {
                count += CountNodes(child); // �ݹ�����ӽڵ������
            }
        }
        return count;
    }



    float CountLeafNodes(Node node)
    {
        float count = 0; // ��ʼֵΪ 0

        if (node.children == null || node.children.Count() == 0)
        {
            // ��ǰ�ڵ���Ҷ�ӽڵ�
            count = 1;
        }
        else
        {
            foreach (var child in node.children)
            {
                count += CountLeafNodes(child); // �ݹ�����ӽڵ��Ҷ�ӽڵ�����
            }
        }

        return count;
    }
    public static void ComputeLayout(Node root, float x, float y, float width, float height)
    {
        if (root == null || root.children == null)
        {
            // Ҷ�ӽڵ��սڵ�
            return;
        }

        float ratio = width / height;

        // ����ڵ�ֵ�ܺ�
        float sum = 0;
        foreach (var child in root.children)
        {
            sum += child.value;
        }
        //Debug.Log(sum);
        float yOffset = height;

        //foreach (var child in root.children)
        for(int i=0;i< root.children.Length;i++)
        {
            //Node child=root.children[i];
            //Debug.Log(i + "i");
            //Debug.Log(root.children.Length+ "root.children.Length");
            //PrintNode(root.children[i], 0);
            // �����ӽڵ����Դ�С
            float relativeSize = root.children[i].value / sum;

            // �����ӽڵ�Ŀ�Ⱥ͸߶�
            float childWidth = width * relativeSize;
            float childHeight = 1;
            root.children[i].width = childWidth;
            root.children[i].height = childHeight;
            root.children[i].y = childHeight * root.children[i].Level;
            root.children[i].x = x;

            //if (i>0 && root.children[i].Level!= root.children[i - 1].Level)
            //{
            //    child.x = x;
            //}

            //if (i > 0 && root.children[i].Level == root.children[i - 1].Level)
            //{
            //    child.x = root.children[i - 1].x+ childWidth;
            //}

            //child.x = x;
            //child.y = yOffset;
            x+= childWidth; 
            ComputeLayout(root.children[i+1], x, y, childWidth, childHeight);
            
            //yOffset += childHeight;

        }
    }

    public static void Computeroot(Node node, float x, float y, float width, float height)
    {
        float sum = 0;
        foreach (var child in node.children)
        {
            sum += child.value;
        }
        node.x = x; node.y = y; node.width = width; node.height = 1;
    }


        public static void ComputeLayout2(Node root, float x, float y, float width, float height)
    {
        if (root == null || root.children == null)
        {

            return;
        }
        
        //PrintNode(root, 0);

        //Debug.Log(sum);


        for (int i = 0; i < root.children.Length; i++)
        {
            float sum2 = 0;
            foreach (var child in root.children)
            {
                sum2 += child.value;
            }
            //Debug.Log(sum2);    
            float relativeSize = root.children[i].value / sum2;

            // �����ӽڵ�Ŀ�Ⱥ͸߶�
            //width = root.width;
            float childWidth = width * relativeSize;
            float childHeight = 1;
            root.children[i].width = childWidth;
            root.children[i].height = childHeight;
            root.children[i].y = childHeight * root.children[i].Level+y;
            root.children[i].x = x;
            //Debug.Log(root.children[i].Level + "i" + i);
            if (i != 0)
            {
                root.children[i].x = root.children[i - 1].x + root.children[i-1].width;
            }
            float newwidth = 0;
            if (root != null && root.children[0].children != null)
            {
               
                foreach (var child in root.children[0].children)
                {
                    newwidth += child.value;
                }
                //Debug.Log(newwidth);
            }
            ComputeLayout2(root.children[i], root.children[i].x, y, childWidth, height);
        }

        

            PrintNode(root, 0);
    }

        void PrintNodeLevel(Node node, int level)
    {
        if (node == null)
        {
            return;
        }
        // ���������ַ�������ʾ�㼶
        string indent = new string(' ', level * 2);

        // ��ӡ�ڵ���Ϣ
        Debug.Log($"{indent}Node Name: {node.name}, Level: {level}, Position: ({node.x}, {node.y}), Size: ({node.width}, {node.height}), Value: {node.value}");
        node.Level = level;
        Debug.Log($"{indent}Node Name: {node.name}, Level:{node.Level}");
        // �ݹ��ӡÿ���ӽڵ�
        if (node.children != null)
        {
            foreach (Node child in node.children)
            {
                
                PrintNodeLevel(child, level + 1); // �ӽڵ�Ĳ㼶�ȵ�ǰ�㼶��1
                
            }
        }
    }
    public static void NodeLevel(Node node, int level)
    {
        if (node == null)
        {
            return;
        }

        node.Level = level;
        // �ݹ��ӡÿ���ӽڵ�
        if (node.children != null)
        {
            foreach (Node child in node.children)
            {
               NodeLevel(child, level + 1);
            }
        }

    }


    public static void PrintNode(Node node, int level)
    {
        if (node == null)
        {
            return;
        }

        // ���������ַ�������ʾ�㼶
        string indent = new string(' ', level * 2);

        // ��ӡ�ڵ���Ϣ
        Debug.Log($"{indent}Node Name: {node.name}, Level: {level}, Position: ({node.x}, {node.y}), Size: ({node.width}, {node.height}), Value: {node.value}");
        // �ݹ��ӡÿ���ӽڵ�
        if (node.children != null)
        {
            foreach (Node child in node.children)
            {

                PrintNode(child, level + 1); // �ӽڵ�Ĳ㼶�ȵ�ǰ�㼶��1

            }
        }
    }

    void DrawIcicleCube(Node node, Quaternion rotation,int level=1)
    {
        // ʵ���� iciclePrefab
        Vector3 position = new Vector3(node.x + node.width / 2, node.y + node.height / 2, 0);
        GameObject icicle = Instantiate(iciclePrefab, position, rotation, transform);
        icicle.name = node.name2;
        icicle.transform.localScale = new Vector3(node.width, node.height, 1);
        //Renderer cubeRenderer = icicle.GetComponent<Renderer>();
        //cubeRenderer.material.color = Color.red;
        //string nodeName = node.name2;    
        //Color nodeColor =GenerateRandomColor(nodeName);
        //cubeRenderer.material.color = nodeColor;

        // ���һ���յ��� GameObject ���ڱ�ע�ڵ�����
        GameObject textLabel = new GameObject("TextLabel");
        textLabel.transform.parent = icicle.transform;
        textLabel.transform.localPosition = Vector3.zero;
        Vector3 newtextScale = textLabel.transform.localScale/10f;
        textLabel.transform.localScale = newtextScale;

        // ��� TextMesh ���� GameObject ��
        TextMesh textMesh = textLabel.AddComponent<TextMesh>();
        textMesh.text = node.name; // ʹ�ýڵ������
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 50;
        string nodecolour = node.colour;
        //Debug.Log(nodecolour);
        if (nodecolour == "Blue")
        {
            textMesh.color = Color.blue;
        }


        //// ���������ɫ�����������ڵ�����
        //ColorGenerator colorGenerator = GetComponent<ColorGenerator>();
        //Color nodeColor = colorGenerator.GenerateRandomColor(nodeName);

        //// ����ɫӦ�õ� Cube �Ĳ���
        //Renderer cubeRenderer = icicle.GetComponent<Renderer>();
        //cubeRenderer.material.color = nodeColor;

    }

    void DrawGraph(Node node, int level)
    {
        if (node == null)
        {
            return;
        }
        DrawIcicleCube(node, Quaternion.identity);
        if (node.children != null)
        {
            foreach (Node child in node.children)
            {
                //DrawIcicleCube(child, Quaternion.identity);
                DrawGraph(child, level + 1);

            }
        }
    }


}
    



    




