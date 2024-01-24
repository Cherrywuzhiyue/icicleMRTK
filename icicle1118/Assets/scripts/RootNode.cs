using UnityEngine;

public class RootNode : MonoBehaviour
{
    public static Node rootNode;

    void Awake()
    {
        rootNode = new Node
        {
            name = "�����",
            value = 1,
            name2 = "�����",
            colour = "WhiteSmoke",
            fangji = "����ɢ��ľ���������߰���ɢ�����������鲹Ѫ���������ɢ��������������Ƣ�����¹���ɽ���ҹ��衢һ����������˸ʲ���(������)��߱����׵������������������ζ�ػ�������衢�ػ����ӡ�������",
            children = new Node[]
{
        new Node
        {
            name = "�˲�",
            value = 4,
            name2 = "�˲�",
            colour = "Blue",
            fangji = "����ɢ��ľ���������߰���ɢ���������",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 2,
                    name2 = "�˲�",
                    colour = "WhiteSmoke",
                    fangji = "����ɢ��ľ�������",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 2,
                            name2 = "�˲�",
                            colour = "WhiteSmoke",
                            fangji = "����ɢ��ľ�������",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "��ζ��",
                                    value = 1,
                                    name2 = "��ζ��",
                                    colour = "WhiteSmoke",
                                    fangji = "����ɢ��",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "��",
                                            value = 1,
                                            name2 = "��",
                                            colour = "WhiteSmoke",
                                            fangji = "����ɢ��",
                                        },
                                    }
                                },
                                new Node
                                {
                                    name = "����",
                                    value = 1,
                                    name2 = "����",
                                    colour = "WhiteSmoke",
                                    fangji = "�ľ�������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "����",
                                            value = 1,
                                            name2 = "����",
                                            colour = "WhiteSmoke",
                                            fangji = "�ľ�������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�ʲ�",
                                                    value = 1,
                                                    name2 = "�ʲ�",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�ľ�������",
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = " ",
                    value = 1,
                    name2 = "�˲�",
                    colour = "WhiteSmoke",
                    fangji = "��������",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "��ػ�",
                            value = 1,
                            name2 = "��ػ�",
                            colour = "Blue",
                            fangji = "��������",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "����",
                                    value = 1,
                                    name2 = "����",
                                    colour = "WhiteSmoke",
                                    fangji = "��������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "����",
                                            value = 1,
                                            name2 = "����",
                                            colour = "WhiteSmoke",
                                            fangji = "��������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�˸ʲ�",
                                                    value = 1,
                                                    name2 = "�˸ʲ�",
                                                    colour = "WhiteSmoke",
                                                    fangji = "��������",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "����",
                                                            value = 1,
                                                            name2 = "����",
                                                            colour = "WhiteSmoke",
                                                            fangji = "��������",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "����",
                                                                    value = 1,
                                                                    name2 = "����",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "��������",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "����",
                                                                            value = 1,
                                                                            name2 = "����",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "��������",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "����",
                                                                                    value = 1,
                                                                                    name2 = "����",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "��������",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "��ܺ",
                                                                                            value = 1,
                                                                                            name2 = "��ܺ",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "��������",
                                                                                        },
                                                                                    }
                                                                                },
                                                                            }
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = "����",
                    value = 1,
                    name2 = "����",
                    colour = "Blue",
                    fangji = "���߰���ɢ��",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "����",
                            value = 1,
                            name2 = "����",
                            colour = "Blue",
                            fangji = "���߰���ɢ��",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "ɰ��",
                                    value = 1,
                                    name2 = "ɰ��",
                                    colour = "WhiteSmoke",
                                    fangji = "���߰���ɢ��",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "����",
                                            value = 1,
                                            name2 = "����",
                                            colour = "WhiteSmoke",
                                            fangji = "���߰���ɢ��",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�ʲ�",
                                                    value = 1,
                                                    name2 = "�ʲ�",
                                                    colour = "WhiteSmoke",
                                                    fangji = "���߰���ɢ��",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "�۹�",
                                                            value = 1,
                                                            name2 = "�۹�",
                                                            colour = "WhiteSmoke",
                                                            fangji = "���߰���ɢ��",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "ɽҩ",
                                                                    value = 1,
                                                                    name2 = "ɽҩ",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "���߰���ɢ��",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "����",
                                                                            value = 1,
                                                                            name2 = "����",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "���߰���ɢ��",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "޲����",
                                                                                    value = 1,
                                                                                    name2 = "޲����",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "���߰���ɢ��",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "�ױⶹ",
                                                                                            value = 1,
                                                                                            name2 = "�ױⶹ",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "���߰���ɢ��",
                                                                                        },
                                                                                    }
                                                                                },
                                                                            }
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
            }
        },
        new Node
        {
            name = "����",
            value = 4,
            name2 = "����",
            colour = "Blue",
            fangji = "�����������������ɢ����鲹Ѫ�����Ƣ����",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 3,
                    name2 = "����",
                    colour = "WhiteSmoke",
                    fangji = "�����������������ɢ����鲹Ѫ����",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "����",
                            value = 1,
                            name2 = "����",
                            colour = "WhiteSmoke",
                            fangji = "���鲹Ѫ����",
                        },
                        new Node
                        {
                            name = "����",
                            value = 2,
                            name2 = "����",
                            colour = "WhiteSmoke",
                            fangji = "�����������������ɢ��",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "����",
                                    value = 1,
                                    name2 = "����",
                                    colour = "WhiteSmoke",
                                    fangji = "������ɢ��",
                                },
                                new Node
                                {
                                    name = "����",
                                    value = 1,
                                    name2 = "����",
                                    colour = "WhiteSmoke",
                                    fangji = "������������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "����",
                                            value = 1,
                                            name2 = "����",
                                            colour = "WhiteSmoke",
                                            fangji = "������������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�˲�",
                                                    value = 1,
                                                    name2 = "�˲�",
                                                    colour = "WhiteSmoke",
                                                    fangji = "������������",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "��Ƥ",
                                                            value = 1,
                                                            name2 = "��Ƥ",
                                                            colour = "WhiteSmoke",
                                                            fangji = "������������",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "���",
                                                                    value = 1,
                                                                    name2 = "���",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "������������",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "�˸ʲ�",
                                                                            value = 1,
                                                                            name2 = "�˸ʲ�",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "������������",
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = "������",
                    value = 1,
                    name2 = "������",
                    colour = "Blue",
                    fangji = "��Ƣ����",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "����",
                            value = 1,
                            name2 = "����",
                            colour = "WhiteSmoke",
                            fangji = "��Ƣ����",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "����",
                                    value = 1,
                                    name2 = "����",
                                    colour = "WhiteSmoke",
                                    fangji = "��Ƣ����",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "�˸ʲ�",
                                            value = 1,
                                            name2 = "�˸ʲ�",
                                            colour = "WhiteSmoke",
                                            fangji = "��Ƣ����",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�˲�",
                                                    value = 1,
                                                    name2 = "�˲�",
                                                    colour = "WhiteSmoke",
                                                    fangji = "��Ƣ����",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "Զ־",
                                                            value = 1,
                                                            name2 = "Զ־",
                                                            colour = "WhiteSmoke",
                                                            fangji = "��Ƣ����",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "������",
                                                                    value = 1,
                                                                    name2 = "������",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "��Ƣ����",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "ľ��",
                                                                            value = 1,
                                                                            name2 = "ľ��",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "��Ƣ����",
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
            }
        },
        new Node
        {
            name = "����",
            value = 1,
            name2 = "����",
            colour = "Blue",
            fangji = "�������",
            children = new Node[]
            {
                new Node
                {
                    name = "ɽҩ",
                    value = 1,
                    name2 = "ɽҩ",
                    colour = "Blue",
                    fangji = "�������",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "����",
                            value = 1,
                            name2 = "����",
                            colour = "WhiteSmoke",
                            fangji = "�������",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "����̿",
                                    value = 1,
                                    name2 = "����̿",
                                    colour = "WhiteSmoke",
                                    fangji = "�������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "�ʲ�",
                                            value = 1,
                                            name2 = "�ʲ�",
                                            colour = "WhiteSmoke",
                                            fangji = "�������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�˲�",
                                                    value = 1,
                                                    name2 = "�˲�",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�������",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "��Ƥ",
                                                            value = 1,
                                                            name2 = "��Ƥ",
                                                            colour = "WhiteSmoke",
                                                            fangji = "�������",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "��ǰ��",
                                                                    value = 1,
                                                                    name2 = "��ǰ��",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "�������",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "���",
                                                                            value = 1,
                                                                            name2 = "���",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "�������",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "����",
                                                                                    value = 1,
                                                                                    name2 = "����",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "�������",
                                                                                },
                                                                            }
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
            }
        },
        new Node
        {
            name = "�ػ�",
            value = 3,
            name2 = "�ػ�",
            colour = "Blue",
            fangji = "�˸ʲ���(������)�һ����������",
            children = new Node[]
            {
                new Node
                {
                    name = "��",
                    value = 2,
                    name2 = "��",
                    colour = "WhiteSmoke",
                    fangji = "�˸ʲ���(������)�һ����",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "����",
                            value = 1,
                            name2 = "����",
                            colour = "WhiteSmoke",
                            fangji = "һ����",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "�����",
                                    value = 1,
                                    name2 = "�����",
                                    colour = "WhiteSmoke",
                                    fangji = "һ����",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "��ɳ��",
                                            value = 1,
                                            name2 = "��ɳ��",
                                            colour = "WhiteSmoke",
                                            fangji = "һ����",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�����",
                                                    value = 1,
                                                    name2 = "�����",
                                                    colour = "WhiteSmoke",
                                                    fangji = "һ����",
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                        new Node
                        {
                            name = "��֦",
                            value = 1,
                            name2 = "��֦",
                            colour = "WhiteSmoke",
                            fangji = "�˸ʲ���(������)��",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "����",
                                    value = 1,
                                    name2 = "����",
                                    colour = "WhiteSmoke",
                                    fangji = "�˸ʲ���(������)��",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "������",
                                            value = 1,
                                            name2 = "������",
                                            colour = "WhiteSmoke",
                                            fangji = "�˸ʲ���(������)��",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "�˸ʲ�",
                                                    value = 1,
                                                    name2 = "�˸ʲ�",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�˸ʲ���(������)��",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "����",
                                                            value = 1,
                                                            name2 = "����",
                                                            colour = "WhiteSmoke",
                                                            fangji = "�˸ʲ���(������)��",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "�˲�",
                                                                    value = 1,
                                                                    name2 = "�˲�",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "�˸ʲ���(������)��",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "����",
                                                                            value = 1,
                                                                            name2 = "����",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "�˸ʲ���(������)��",
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = "��к",
                    value = 1,
                    name2 = "��к",
                    colour = "WhiteSmoke",
                    fangji = "�������",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "��֦",
                            value = 1,
                            name2 = "��֦",
                            colour = "WhiteSmoke",
                            fangji = "�������",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "ĵ��Ƥ",
                                    value = 1,
                                    name2 = "ĵ��Ƥ",
                                    colour = "WhiteSmoke",
                                    fangji = "�������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "ɽҩ",
                                            value = 1,
                                            name2 = "ɽҩ",
                                            colour = "WhiteSmoke",
                                            fangji = "�������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "����",
                                                    value = 1,
                                                    name2 = "����",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�������",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "����",
                                                            value = 1,
                                                            name2 = "����",
                                                            colour = "WhiteSmoke",
                                                            fangji = "�������",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "ɽ����",
                                                                    value = 1,
                                                                    name2 = "ɽ����",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "�������",
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
            }
        },
        new Node
        {
            name = "������",
            value = 1,
            name2 = "������",
            colour = "Blue",
            fangji = "�߱����׵�",
            children = new Node[]
            {
                new Node
                {
                    name = "ţϥ",
                    value = 1,
                    name2 = "ţϥ",
                    colour = "WhiteSmoke",
                    fangji = "�߱����׵�",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "����",
                            value = 1,
                            name2 = "����",
                            colour = "WhiteSmoke",
                            fangji = "�߱����׵�",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "�����",
                                    value = 1,
                                    name2 = "�����",
                                    colour = "WhiteSmoke",
                                    fangji = "�߱����׵�",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "��˿��",
                                            value = 1,
                                            name2 = "��˿��",
                                            colour = "WhiteSmoke",
                                            fangji = "�߱����׵�",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "����",
                                                    value = 1,
                                                    name2 = "����",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�߱����׵�",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "����֬",
                                                            value = 1,
                                                            name2 = "����֬",
                                                            colour = "WhiteSmoke",
                                                            fangji = "�߱����׵�",
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
            }
        },
        new Node
        {
            name = "��ػ�",
            value = 5,
            name2 = "��ػ�",
            colour = "Blue",
            fangji = "��ζ�ػ�������衢��������������ػ����ӡ�",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 1,
                    name2 = "��ػ�",
                    colour = "WhiteSmoke",
                    fangji = "��������",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 1,
                            name2 = "��ػ�",
                            colour = "WhiteSmoke",
                            fangji = "��������",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = " ",
                                    value = 1,
                                    name2 = "��ػ�",
                                    colour = "WhiteSmoke",
                                    fangji = "��������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "����",
                                            value = 1,
                                            name2 = "����",
                                            colour = "WhiteSmoke",
                                            fangji = "��������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "����",
                                                    value = 1,
                                                    name2 = "����",
                                                    colour = "WhiteSmoke",
                                                    fangji = "��������",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "��ܺ",
                                                            value = 1,
                                                            name2 = "��ܺ",
                                                            colour = "WhiteSmoke",
                                                            fangji = "��������",
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = " ",
                    value = 2,
                    name2 = "��ػ�",
                    colour = "WhiteSmoke",
                    fangji = "��ζ�ػ��������",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 2,
                            name2 = "��ػ�",
                            colour = "WhiteSmoke",
                            fangji = "��ζ�ػ��������",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = " ",
                                    value = 2,
                                    name2 = "��ػ�",
                                    colour = "WhiteSmoke",
                                    fangji = "��ζ�ػ��������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "ɽҩ",
                                            value = 2,
                                            name2 = "ɽҩ",
                                            colour = "WhiteSmoke",
                                            fangji = "��ζ�ػ��������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "ɽ����",
                                                    value = 2,
                                                    name2 = "ɽ����",
                                                    colour = "WhiteSmoke",
                                                    fangji = "��ζ�ػ��������",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "ĵ��Ƥ",
                                                            value = 1,
                                                            name2 = "ĵ��Ƥ",
                                                            colour = "WhiteSmoke",
                                                            fangji = "��ζ�ػ����",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "��к",
                                                                    value = 1,
                                                                    name2 = "��к",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "��ζ�ػ����",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "����",
                                                                            value = 1,
                                                                            name2 = "����",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "��ζ�ػ����",
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                        new Node
                                                        {
                                                            name = "��׽�",
                                                            value = 1,
                                                            name2 = "��׽�",
                                                            colour = "WhiteSmoke",
                                                            fangji = "�����",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "ţϥ",
                                                                    value = 1,
                                                                    name2 = "ţϥ",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "�����",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "��˿��",
                                                                            value = 1,
                                                                            name2 = "��˿��",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "�����",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "�����",
                                                                                    value = 1,
                                                                                    name2 = "�����",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "�����",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "¹�ǽ�",
                                                                                            value = 1,
                                                                                            name2 = "¹�ǽ�",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "�����",
                                                                                        },
                                                                                    }
                                                                                },
                                                                            }
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = " ",
                    value = 1,
                    name2 = "��ػ�",
                    colour = "WhiteSmoke",
                    fangji = "�������",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 1,
                            name2 = "��ػ�",
                            colour = "WhiteSmoke",
                            fangji = "�������",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "���",
                                    value = 1,
                                    name2 = "���",
                                    colour = "Blue",
                                    fangji = "�������",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "�ư�",
                                            value = 1,
                                            name2 = "�ư�",
                                            colour = "WhiteSmoke",
                                            fangji = "�������",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "֪ĸ",
                                                    value = 1,
                                                    name2 = "֪ĸ",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�������",
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = "ɽ����",
                    value = 1,
                    name2 = "ɽ����",
                    colour = "Blue",
                    fangji = "�ػ����ӡ�",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "������",
                            value = 1,
                            name2 = "������",
                            colour = "Blue",
                            fangji = "�ػ����ӡ�",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "�����",
                                    value = 1,
                                    name2 = "�����",
                                    colour = "Blue",
                                    fangji = "�ػ����ӡ�",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "ʯ��",
                                            value = 1,
                                            name2 = "ʯ��",
                                            colour = "WhiteSmoke",
                                            fangji = "�ػ����ӡ�",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "��",
                                                    value = 1,
                                                    name2 = "��",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�ػ����ӡ�",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "���",
                                                            value = 1,
                                                            name2 = "���",
                                                            colour = "WhiteSmoke",
                                                            fangji = "�ػ����ӡ�",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "����",
                                                                    value = 1,
                                                                    name2 = "����",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "�ػ����ӡ�",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "����",
                                                                            value = 1,
                                                                            name2 = "����",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "�ػ����ӡ�",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "����",
                                                                                    value = 1,
                                                                                    name2 = "����",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "�ػ����ӡ�",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "��ζ��",
                                                                                            value = 1,
                                                                                            name2 = "��ζ��",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "�ػ����ӡ�",
                                                                                        },
                                                                                    }
                                                                                },
                                                                            }
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
            }
        },
        new Node
        {
            name = "¹�ǽ�",
            value = 2,
            name2 = "¹�ǽ�",
            colour = "Blue",
            fangji = "��¹���ɽ���ҹ���",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 1,
                    name2 = "¹�ǽ�",
                    colour = "WhiteSmoke",
                    fangji = "��¹���ɽ���",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "��׽�",
                            value = 1,
                            name2 = "��׽�",
                            colour = "Blue",
                            fangji = "��¹���ɽ���",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "�˲�",
                                    value = 1,
                                    name2 = "�˲�",
                                    colour = "WhiteSmoke",
                                    fangji = "��¹���ɽ���",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "�����",
                                            value = 1,
                                            name2 = "�����",
                                            colour = "WhiteSmoke",
                                            fangji = "��¹���ɽ���",
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = "���",
                    value = 1,
                    name2 = "���",
                    colour = "Blue",
                    fangji = "�ҹ���",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "����",
                            value = 1,
                            name2 = "����",
                            colour = "Blue",
                            fangji = "�ҹ���",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "����",
                                    value = 1,
                                    name2 = "����",
                                    colour = "WhiteSmoke",
                                    fangji = "�ҹ���",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "�����",
                                            value = 1,
                                            name2 = "�����",
                                            colour = "WhiteSmoke",
                                            fangji = "�ҹ���",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "��˿��",
                                                    value = 1,
                                                    name2 = "��˿��",
                                                    colour = "WhiteSmoke",
                                                    fangji = "�ҹ���",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "ɽҩ",
                                                            value = 1,
                                                            name2 = "ɽҩ",
                                                            colour = "WhiteSmoke",
                                                            fangji = "�ҹ���",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "����",
                                                                    value = 1,
                                                                    name2 = "����",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "�ҹ���",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "��ػ�",
                                                                            value = 1,
                                                                            name2 = "��ػ�",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "�ҹ���",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "ɽ����",
                                                                                    value = 1,
                                                                                    name2 = "ɽ����",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "�ҹ���",
                                                                                },
                                                                            }
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
            }
        },
}
        };
    }
}
