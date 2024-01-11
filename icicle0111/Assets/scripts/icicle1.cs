using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;
using static Unity.VisualScripting.Metadata;

public class icicle1 : MonoBehaviour
{
    [System.Serializable]
    public class Node
    {
        public string name;
        public float value;
        public Node[] children;
       
        public float x { get; set; }
        public float y { get; set; }
        public float width { get; set; }
        public float height { get; set; }

        //public float Value { get; set; }
        public float Level { get; set; }

        // 构造函数

        
    }

    public GameObject iciclePrefab;

    void Start()
    {
        // 从文件中读取 JSON 数据
        string jsonPath = "Assets/data/hhh.json"; // 替换为实际的文件路径
        string jsonData = System.IO.File.ReadAllText(jsonPath);

        // 将 JSON 字符串解析为 Node 对象
        Node rootNode = JsonUtility.FromJson<Node>(jsonData);
        NodeLevel(rootNode, 0);
        Computeroot(rootNode, 1, 1, 10, 10);
        //PrintNodeLevel(rootNode, 0);
        ComputeLayout2(rootNode, 1, 1, 10, 10);
        DrawIcicleCube(rootNode, Quaternion.identity);
        DrawIcicleCube(rootNode.children[0], Quaternion.identity);
        DrawIcicleCube(rootNode.children[0].children[0], Quaternion.identity);
        DrawIcicleCube(rootNode.children[0].children[0].children[0], Quaternion.identity);
        DrawIcicleCube(rootNode.children[0].children[0].children[1], Quaternion.identity);
        DrawIcicleCube(rootNode.children[0].children[1], Quaternion.identity);
        DrawIcicleCube(rootNode.children[1], Quaternion.identity);
        DrawIcicleCube(rootNode.children[2], Quaternion.identity);
        DrawIcicleCube(rootNode.children[3], Quaternion.identity);
        DrawIcicleCube(rootNode.children[3].children[0], Quaternion.identity);
        DrawIcicleCube(rootNode.children[3].children[1], Quaternion.identity);
        //DrawGraph(rootNode, 0);

        // 在根节点上调用递归函数


    }

    void DrawIcicleGraph(Node node, Vector3 position, Quaternion rotation, int level = 1)
    {
        // 实例化 iciclePrefab
        GameObject icicle = Instantiate(iciclePrefab, position, rotation, transform);

        // 设置 icicle 的属性（颜色、尺寸等）
        // 这里需要根据实际的数据结构进行调整

        // 添加一个空的子 GameObject 用于标注节点名称
        GameObject textLabel = new GameObject("TextLabel");
        textLabel.transform.parent = icicle.transform;
        textLabel.transform.localPosition = Vector3.zero;
        //textLabel.transform.localSacle = new Vector3(0.5f,0.5f,0.5f);

        // 添加 TextMesh 到子 GameObject 上
        TextMesh textMesh = textLabel.AddComponent<TextMesh>();
        textMesh.text = node.name; // 使用节点的名称
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 10;

        // 获取当前节点的子节点数组
        Node[] children = node.children;


        int num = CountNodes(node);

        //float icicleWidth = Mathf.Clamp(1.0f - num * 0.1f, 0.1f, 1.0f);
        //float icicleWidth = num;
        float icicleWidth = CountLeafNodes(node) * 1.0f;

        // 设置 iciclePrefab 的宽度
        icicle.transform.localScale = new Vector3(icicleWidth, 1.0f, 1.0f);


        // 计算子节点之间的间隔
        float childSpacing = 1.0f / icicleWidth;
        //Debug.Log(node.name+num+level+ childSpacing);
        //Debug.Log(CountLeafNodes(node));

        float posx = 0;
        // 遍历子节点并递归调用
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


            // 计算子节点的新位置
            // Vector3 childPosition = new Vector3(i * icicleWidth, 0, 0)+ new Vector3(position.x, level, position.z) - new Vector3(icicle.transform.localScale.x/4, 0, 0);


            // 递归调用
            DrawIcicleGraph(children[i], childPosition, Quaternion.identity, level + 1);
        }
    }

    int CountNodes(Node node)
    {
        int count = 1; // 当前节点
        if (node.children != null)
        {
            foreach (var child in node.children)
            {
                count += CountNodes(child); // 递归计算子节点的数量
            }
        }
        return count;
    }



    float CountLeafNodes(Node node)
    {
        float count = 0; // 初始值为 0

        if (node.children == null || node.children.Count() == 0)
        {
            // 当前节点是叶子节点
            count = 1;
        }
        else
        {
            foreach (var child in node.children)
            {
                count += CountLeafNodes(child); // 递归计算子节点的叶子节点数量
            }
        }

        return count;
    }
    public static void ComputeLayout(Node root, float x, float y, float width, float height)
    {
        if (root == null || root.children == null)
        {
            // 叶子节点或空节点
            return;
        }

        float ratio = width / height;

        // 计算节点值总和
        float sum = 0;
        foreach (var child in root.children)
        {
            sum += child.value;
        }
        Debug.Log(sum);
        float yOffset = height;

        //foreach (var child in root.children)
        for(int i=0;i< root.children.Length;i++)
        {
            //Node child=root.children[i];
            Debug.Log(i + "i");
            Debug.Log(root.children.Length+ "root.children.Length");
            PrintNode(root.children[i], 0);
            // 计算子节点的相对大小
            float relativeSize = root.children[i].value / sum;

            // 计算子节点的宽度和高度
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
            Debug.Log(sum2);    
            float relativeSize = root.children[i].value / sum2;

            // 计算子节点的宽度和高度
            //width = root.width;
            float childWidth = width * relativeSize;
            float childHeight = 1;
            root.children[i].width = childWidth;
            root.children[i].height = childHeight;
            root.children[i].y = childHeight * root.children[i].Level+y;
            root.children[i].x = x;
            Debug.Log(root.children[i].Level + "i" + i);
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
                Debug.Log(newwidth);
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
        // 创建缩进字符串，表示层级
        string indent = new string(' ', level * 2);

        // 打印节点信息
        Debug.Log($"{indent}Node Name: {node.name}, Level: {level}, Position: ({node.x}, {node.y}), Size: ({node.width}, {node.height}), Value: {node.value}");
        node.Level = level;
        Debug.Log($"{indent}Node Name: {node.name}, Level:{node.Level}");
        // 递归打印每个子节点
        if (node.children != null)
        {
            foreach (Node child in node.children)
            {
                
                PrintNodeLevel(child, level + 1); // 子节点的层级比当前层级多1
                
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
        // 递归打印每个子节点
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

        // 创建缩进字符串，表示层级
        string indent = new string(' ', level * 2);

        // 打印节点信息
        Debug.Log($"{indent}Node Name: {node.name}, Level: {level}, Position: ({node.x}, {node.y}), Size: ({node.width}, {node.height}), Value: {node.value}");
        // 递归打印每个子节点
        if (node.children != null)
        {
            foreach (Node child in node.children)
            {

                PrintNode(child, level + 1); // 子节点的层级比当前层级多1

            }
        }
    }

    void DrawIcicleCube(Node node, Quaternion rotation,int level=1)
    {
        // 实例化 iciclePrefab
        Vector3 position = new Vector3(node.x + node.width / 2, node.y + node.height / 2, 0);
        GameObject icicle = Instantiate(iciclePrefab, position, rotation, transform);
        icicle.transform.localScale = new Vector3(node.width, node.height, 1);


        // 设置 icicle 的属性（颜色、尺寸等）
        // 这里需要根据实际的数据结构进行调整

        // 添加一个空的子 GameObject 用于标注节点名称
        GameObject textLabel = new GameObject("TextLabel");
        textLabel.transform.parent = icicle.transform;
        textLabel.transform.localPosition = Vector3.zero;
        //textLabel.transform.localSacle = new Vector3(0.5f,0.5f,0.5f);

        // 添加 TextMesh 到子 GameObject 上
        TextMesh textMesh = textLabel.AddComponent<TextMesh>();
        textMesh.text = node.name; // 使用节点的名称
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 10;

        }

    void DrawGraph(Node node, int level)
    {
        if (node == null)
        {
            return;
        }
        DrawIcicleCube(node, Quaternion.identity, 0);
        if (node.children != null)
        {
            foreach (Node child in node.children)
            {

                DrawGraph(node, level + 1);

            }
        }
    }


}
    



    




