using UnityEngine;

public class RootNode : MonoBehaviour
{
    public static Node rootNode;

    void Awake()
    {
        rootNode = new Node
        {
            name = "≤π“Êº¡",
            value = 1,
            name2 = "≤π“Êº¡",
            colour = "WhiteSmoke",
            fangji = "…˙¬ˆ…¢°Ô°¢Àƒæ˝◊”Ã¿°Ô°¢≤Œ‹ﬂ∞◊ ı…¢°Ô°¢∞À’‰Ã¿°Ô°¢µ±πÈ≤π—™Ã¿°Ô°¢”Ò∆¡∑Á…¢°Ô°¢≤π÷–“Ê∆¯Ã¿°Ô°¢πÈ∆¢Ã¿°Ô°¢πÍ¬π∂˛œ…Ω∫°Ô°¢”“πÈÕË°¢“ªπ·ºÂ°Ô°¢…ˆ∆¯ÕË°Ô°¢÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô°¢∆ﬂ±¶√¿˜◊µ§°¢¥Û≤π“ıÕË°Ô°¢ÀƒŒÔÃ¿°Ô°¢¡˘Œ∂µÿª∆ÕË°Ô°¢◊ÛπÈÕË°¢µÿª∆“˚◊”°Ô°¢ÕÍ¥¯Ã¿°Ô",
            children = new Node[]
{
        new Node
        {
            name = "»À≤Œ",
            value = 4,
            name2 = "»À≤Œ",
            colour = "Blue",
            fangji = "…˙¬ˆ…¢°Ô°¢Àƒæ˝◊”Ã¿°Ô°¢≤Œ‹ﬂ∞◊ ı…¢°Ô°¢∞À’‰Ã¿°Ô",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 2,
                    name2 = "»À≤Œ",
                    colour = "WhiteSmoke",
                    fangji = "…˙¬ˆ…¢°Ô°¢Àƒæ˝◊”Ã¿°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 2,
                            name2 = "»À≤Œ",
                            colour = "WhiteSmoke",
                            fangji = "…˙¬ˆ…¢°Ô°¢Àƒæ˝◊”Ã¿°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "ŒÂŒ∂◊”",
                                    value = 1,
                                    name2 = "ŒÂŒ∂◊”",
                                    colour = "WhiteSmoke",
                                    fangji = "…˙¬ˆ…¢°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "¬Û∂¨",
                                            value = 1,
                                            name2 = "¬Û∂¨",
                                            colour = "WhiteSmoke",
                                            fangji = "…˙¬ˆ…¢°Ô",
                                        },
                                    }
                                },
                                new Node
                                {
                                    name = "∞◊ ı",
                                    value = 1,
                                    name2 = "∞◊ ı",
                                    colour = "WhiteSmoke",
                                    fangji = "Àƒæ˝◊”Ã¿°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "‹Ú‹ﬂ",
                                            value = 1,
                                            name2 = "‹Ú‹ﬂ",
                                            colour = "WhiteSmoke",
                                            fangji = "Àƒæ˝◊”Ã¿°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "∏ ≤›",
                                                    value = 1,
                                                    name2 = "∏ ≤›",
                                                    colour = "WhiteSmoke",
                                                    fangji = "Àƒæ˝◊”Ã¿°Ô",
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
                    name2 = "»À≤Œ",
                    colour = "WhiteSmoke",
                    fangji = "∞À’‰Ã¿°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " Ïµÿª∆",
                            value = 1,
                            name2 = " Ïµÿª∆",
                            colour = "Blue",
                            fangji = "∞À’‰Ã¿°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "∞◊ ı",
                                    value = 1,
                                    name2 = "∞◊ ı",
                                    colour = "WhiteSmoke",
                                    fangji = "∞À’‰Ã¿°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "‹Ú‹ﬂ",
                                            value = 1,
                                            name2 = "‹Ú‹ﬂ",
                                            colour = "WhiteSmoke",
                                            fangji = "∞À’‰Ã¿°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "÷À∏ ≤›",
                                                    value = 1,
                                                    name2 = "÷À∏ ≤›",
                                                    colour = "WhiteSmoke",
                                                    fangji = "∞À’‰Ã¿°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "…˙Ω™",
                                                            value = 1,
                                                            name2 = "…˙Ω™",
                                                            colour = "WhiteSmoke",
                                                            fangji = "∞À’‰Ã¿°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "µ±πÈ",
                                                                    value = 1,
                                                                    name2 = "µ±πÈ",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "∞À’‰Ã¿°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "¥Û‘Ê",
                                                                            value = 1,
                                                                            name2 = "¥Û‘Ê",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "∞À’‰Ã¿°Ô",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "∞◊…÷",
                                                                                    value = 1,
                                                                                    name2 = "∞◊…÷",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "∞À’‰Ã¿°Ô",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "¥®‹∫",
                                                                                            value = 1,
                                                                                            name2 = "¥®‹∫",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "∞À’‰Ã¿°Ô",
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
                    name = "‹Ú‹ﬂ",
                    value = 1,
                    name2 = "‹Ú‹ﬂ",
                    colour = "Blue",
                    fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "∞◊ ı",
                            value = 1,
                            name2 = "∞◊ ı",
                            colour = "Blue",
                            fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "…∞» ",
                                    value = 1,
                                    name2 = "…∞» ",
                                    colour = "WhiteSmoke",
                                    fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "¡´◊”",
                                            value = 1,
                                            name2 = "¡´◊”",
                                            colour = "WhiteSmoke",
                                            fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "∏ ≤›",
                                                    value = 1,
                                                    name2 = "∏ ≤›",
                                                    colour = "WhiteSmoke",
                                                    fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "Ω€π£",
                                                            value = 1,
                                                            name2 = "Ω€π£",
                                                            colour = "WhiteSmoke",
                                                            fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "…Ω“©",
                                                                    value = 1,
                                                                    name2 = "…Ω“©",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "¥Û‘Ê",
                                                                            value = 1,
                                                                            name2 = "¥Û‘Ê",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "ﬁ≤‹”» ",
                                                                                    value = 1,
                                                                                    name2 = "ﬁ≤‹”» ",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "∞◊±‚∂π",
                                                                                            value = 1,
                                                                                            name2 = "∞◊±‚∂π",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "≤Œ‹ﬂ∞◊ ı…¢°Ô",
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
            name = "ª∆‹Œ",
            value = 4,
            name2 = "ª∆‹Œ",
            colour = "Blue",
            fangji = "≤π÷–“Ê∆¯Ã¿°Ô°¢”Ò∆¡∑Á…¢°Ô°¢µ±πÈ≤π—™Ã¿°Ô°¢πÈ∆¢Ã¿°Ô",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 3,
                    name2 = "ª∆‹Œ",
                    colour = "WhiteSmoke",
                    fangji = "≤π÷–“Ê∆¯Ã¿°Ô°¢”Ò∆¡∑Á…¢°Ô°¢µ±πÈ≤π—™Ã¿°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "µ±πÈ",
                            value = 1,
                            name2 = "µ±πÈ",
                            colour = "WhiteSmoke",
                            fangji = "µ±πÈ≤π—™Ã¿°Ô",
                        },
                        new Node
                        {
                            name = "∞◊ ı",
                            value = 2,
                            name2 = "∞◊ ı",
                            colour = "WhiteSmoke",
                            fangji = "≤π÷–“Ê∆¯Ã¿°Ô°¢”Ò∆¡∑Á…¢°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "∑¿∑Á",
                                    value = 1,
                                    name2 = "∑¿∑Á",
                                    colour = "WhiteSmoke",
                                    fangji = "”Ò∆¡∑Á…¢°Ô",
                                },
                                new Node
                                {
                                    name = "µ±πÈ",
                                    value = 1,
                                    name2 = "µ±πÈ",
                                    colour = "WhiteSmoke",
                                    fangji = "≤π÷–“Ê∆¯Ã¿°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "…˝¬È",
                                            value = 1,
                                            name2 = "…˝¬È",
                                            colour = "WhiteSmoke",
                                            fangji = "≤π÷–“Ê∆¯Ã¿°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "»À≤Œ",
                                                    value = 1,
                                                    name2 = "»À≤Œ",
                                                    colour = "WhiteSmoke",
                                                    fangji = "≤π÷–“Ê∆¯Ã¿°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "≥¬∆§",
                                                            value = 1,
                                                            name2 = "≥¬∆§",
                                                            colour = "WhiteSmoke",
                                                            fangji = "≤π÷–“Ê∆¯Ã¿°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "≤Ò∫˙",
                                                                    value = 1,
                                                                    name2 = "≤Ò∫˙",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "≤π÷–“Ê∆¯Ã¿°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "÷À∏ ≤›",
                                                                            value = 1,
                                                                            name2 = "÷À∏ ≤›",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "≤π÷–“Ê∆¯Ã¿°Ô",
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
                    name = "¡˙—€»‚",
                    value = 1,
                    name2 = "¡˙—€»‚",
                    colour = "Blue",
                    fangji = "πÈ∆¢Ã¿°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "∞◊ ı",
                            value = 1,
                            name2 = "∞◊ ı",
                            colour = "WhiteSmoke",
                            fangji = "πÈ∆¢Ã¿°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "µ±πÈ",
                                    value = 1,
                                    name2 = "µ±πÈ",
                                    colour = "WhiteSmoke",
                                    fangji = "πÈ∆¢Ã¿°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "÷À∏ ≤›",
                                            value = 1,
                                            name2 = "÷À∏ ≤›",
                                            colour = "WhiteSmoke",
                                            fangji = "πÈ∆¢Ã¿°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "»À≤Œ",
                                                    value = 1,
                                                    name2 = "»À≤Œ",
                                                    colour = "WhiteSmoke",
                                                    fangji = "πÈ∆¢Ã¿°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "‘∂÷æ",
                                                            value = 1,
                                                            name2 = "‘∂÷æ",
                                                            colour = "WhiteSmoke",
                                                            fangji = "πÈ∆¢Ã¿°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "À·‘Ê» ",
                                                                    value = 1,
                                                                    name2 = "À·‘Ê» ",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "πÈ∆¢Ã¿°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "ƒæœ„",
                                                                            value = 1,
                                                                            name2 = "ƒæœ„",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "πÈ∆¢Ã¿°Ô",
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
            name = "∞◊ ı",
            value = 1,
            name2 = "∞◊ ı",
            colour = "Blue",
            fangji = "ÕÍ¥¯Ã¿°Ô",
            children = new Node[]
            {
                new Node
                {
                    name = "…Ω“©",
                    value = 1,
                    name2 = "…Ω“©",
                    colour = "Blue",
                    fangji = "ÕÍ¥¯Ã¿°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "≤‘ ı",
                            value = 1,
                            name2 = "≤‘ ı",
                            colour = "WhiteSmoke",
                            fangji = "ÕÍ¥¯Ã¿°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "æ£ΩÊÃø",
                                    value = 1,
                                    name2 = "æ£ΩÊÃø",
                                    colour = "WhiteSmoke",
                                    fangji = "ÕÍ¥¯Ã¿°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "∏ ≤›",
                                            value = 1,
                                            name2 = "∏ ≤›",
                                            colour = "WhiteSmoke",
                                            fangji = "ÕÍ¥¯Ã¿°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "»À≤Œ",
                                                    value = 1,
                                                    name2 = "»À≤Œ",
                                                    colour = "WhiteSmoke",
                                                    fangji = "ÕÍ¥¯Ã¿°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "≥¬∆§",
                                                            value = 1,
                                                            name2 = "≥¬∆§",
                                                            colour = "WhiteSmoke",
                                                            fangji = "ÕÍ¥¯Ã¿°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "≥µ«∞◊”",
                                                                    value = 1,
                                                                    name2 = "≥µ«∞◊”",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "ÕÍ¥¯Ã¿°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "≤Ò∫˙",
                                                                            value = 1,
                                                                            name2 = "≤Ò∫˙",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "ÕÍ¥¯Ã¿°Ô",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "∞◊…÷",
                                                                                    value = 1,
                                                                                    name2 = "∞◊…÷",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "ÕÍ¥¯Ã¿°Ô",
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
            name = "µÿª∆",
            value = 3,
            name2 = "µÿª∆",
            colour = "Blue",
            fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô°¢“ªπ·ºÂ°Ô°¢…ˆ∆¯ÕË°Ô",
            children = new Node[]
            {
                new Node
                {
                    name = "¬Û∂¨",
                    value = 2,
                    name2 = "¬Û∂¨",
                    colour = "WhiteSmoke",
                    fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô°¢“ªπ·ºÂ°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "µ±πÈ",
                            value = 1,
                            name2 = "µ±πÈ",
                            colour = "WhiteSmoke",
                            fangji = "“ªπ·ºÂ°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "Ë€ËΩ◊”",
                                    value = 1,
                                    name2 = "Ë€ËΩ◊”",
                                    colour = "WhiteSmoke",
                                    fangji = "“ªπ·ºÂ°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "±±…≥≤Œ",
                                            value = 1,
                                            name2 = "±±…≥≤Œ",
                                            colour = "WhiteSmoke",
                                            fangji = "“ªπ·ºÂ°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "¥®È¨◊”",
                                                    value = 1,
                                                    name2 = "¥®È¨◊”",
                                                    colour = "WhiteSmoke",
                                                    fangji = "“ªπ·ºÂ°Ô",
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                        new Node
                        {
                            name = "π÷¶",
                            value = 1,
                            name2 = "π÷¶",
                            colour = "WhiteSmoke",
                            fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "∞¢Ω∫",
                                    value = 1,
                                    name2 = "∞¢Ω∫",
                                    colour = "WhiteSmoke",
                                    fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "ª¬È» ",
                                            value = 1,
                                            name2 = "ª¬È» ",
                                            colour = "WhiteSmoke",
                                            fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "÷À∏ ≤›",
                                                    value = 1,
                                                    name2 = "÷À∏ ≤›",
                                                    colour = "WhiteSmoke",
                                                    fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "¥Û‘Ê",
                                                            value = 1,
                                                            name2 = "¥Û‘Ê",
                                                            colour = "WhiteSmoke",
                                                            fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "»À≤Œ",
                                                                    value = 1,
                                                                    name2 = "»À≤Œ",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "…˙Ω™",
                                                                            value = 1,
                                                                            name2 = "…˙Ω™",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "÷À∏ ≤›Ã¿(∏¥¬ˆÃ¿)°Ô",
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
                    name = "‘Û–∫",
                    value = 1,
                    name2 = "‘Û–∫",
                    colour = "WhiteSmoke",
                    fangji = "…ˆ∆¯ÕË°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "π÷¶",
                            value = 1,
                            name2 = "π÷¶",
                            colour = "WhiteSmoke",
                            fangji = "…ˆ∆¯ÕË°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "ƒµµ§∆§",
                                    value = 1,
                                    name2 = "ƒµµ§∆§",
                                    colour = "WhiteSmoke",
                                    fangji = "…ˆ∆¯ÕË°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "…Ω“©",
                                            value = 1,
                                            name2 = "…Ω“©",
                                            colour = "WhiteSmoke",
                                            fangji = "…ˆ∆¯ÕË°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "‹Ú‹ﬂ",
                                                    value = 1,
                                                    name2 = "‹Ú‹ﬂ",
                                                    colour = "WhiteSmoke",
                                                    fangji = "…ˆ∆¯ÕË°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "∏Ω◊”",
                                                            value = 1,
                                                            name2 = "∏Ω◊”",
                                                            colour = "WhiteSmoke",
                                                            fangji = "…ˆ∆¯ÕË°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "…Ω‹Ô›«",
                                                                    value = 1,
                                                                    name2 = "…Ω‹Ô›«",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "…ˆ∆¯ÕË°Ô",
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
            name = "∫Œ ◊Œ⁄",
            value = 1,
            name2 = "∫Œ ◊Œ⁄",
            colour = "Blue",
            fangji = "∆ﬂ±¶√¿˜◊µ§",
            children = new Node[]
            {
                new Node
                {
                    name = "≈£œ•",
                    value = 1,
                    name2 = "≈£œ•",
                    colour = "WhiteSmoke",
                    fangji = "∆ﬂ±¶√¿˜◊µ§",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "µ±πÈ",
                            value = 1,
                            name2 = "µ±πÈ",
                            colour = "WhiteSmoke",
                            fangji = "∆ﬂ±¶√¿˜◊µ§",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "Ë€ËΩ◊”",
                                    value = 1,
                                    name2 = "Ë€ËΩ◊”",
                                    colour = "WhiteSmoke",
                                    fangji = "∆ﬂ±¶√¿˜◊µ§",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "›ÀÀø◊”",
                                            value = 1,
                                            name2 = "›ÀÀø◊”",
                                            colour = "WhiteSmoke",
                                            fangji = "∆ﬂ±¶√¿˜◊µ§",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "‹Ú‹ﬂ",
                                                    value = 1,
                                                    name2 = "‹Ú‹ﬂ",
                                                    colour = "WhiteSmoke",
                                                    fangji = "∆ﬂ±¶√¿˜◊µ§",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "≤ππ«÷¨",
                                                            value = 1,
                                                            name2 = "≤ππ«÷¨",
                                                            colour = "WhiteSmoke",
                                                            fangji = "∆ﬂ±¶√¿˜◊µ§",
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
            name = " Ïµÿª∆",
            value = 5,
            name2 = " Ïµÿª∆",
            colour = "Blue",
            fangji = "¡˘Œ∂µÿª∆ÕË°Ô°¢◊ÛπÈÕË°¢ÀƒŒÔÃ¿°Ô°¢¥Û≤π“ıÕË°Ô°¢µÿª∆“˚◊”°Ô",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 1,
                    name2 = " Ïµÿª∆",
                    colour = "WhiteSmoke",
                    fangji = "ÀƒŒÔÃ¿°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 1,
                            name2 = " Ïµÿª∆",
                            colour = "WhiteSmoke",
                            fangji = "ÀƒŒÔÃ¿°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = " ",
                                    value = 1,
                                    name2 = " Ïµÿª∆",
                                    colour = "WhiteSmoke",
                                    fangji = "ÀƒŒÔÃ¿°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "µ±πÈ",
                                            value = 1,
                                            name2 = "µ±πÈ",
                                            colour = "WhiteSmoke",
                                            fangji = "ÀƒŒÔÃ¿°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "∞◊…÷",
                                                    value = 1,
                                                    name2 = "∞◊…÷",
                                                    colour = "WhiteSmoke",
                                                    fangji = "ÀƒŒÔÃ¿°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "¥®‹∫",
                                                            value = 1,
                                                            name2 = "¥®‹∫",
                                                            colour = "WhiteSmoke",
                                                            fangji = "ÀƒŒÔÃ¿°Ô",
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
                    name2 = " Ïµÿª∆",
                    colour = "WhiteSmoke",
                    fangji = "¡˘Œ∂µÿª∆ÕË°Ô°¢◊ÛπÈÕË",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 2,
                            name2 = " Ïµÿª∆",
                            colour = "WhiteSmoke",
                            fangji = "¡˘Œ∂µÿª∆ÕË°Ô°¢◊ÛπÈÕË",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = " ",
                                    value = 2,
                                    name2 = " Ïµÿª∆",
                                    colour = "WhiteSmoke",
                                    fangji = "¡˘Œ∂µÿª∆ÕË°Ô°¢◊ÛπÈÕË",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "…Ω“©",
                                            value = 2,
                                            name2 = "…Ω“©",
                                            colour = "WhiteSmoke",
                                            fangji = "¡˘Œ∂µÿª∆ÕË°Ô°¢◊ÛπÈÕË",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "…Ω‹Ô›«",
                                                    value = 2,
                                                    name2 = "…Ω‹Ô›«",
                                                    colour = "WhiteSmoke",
                                                    fangji = "¡˘Œ∂µÿª∆ÕË°Ô°¢◊ÛπÈÕË",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "ƒµµ§∆§",
                                                            value = 1,
                                                            name2 = "ƒµµ§∆§",
                                                            colour = "WhiteSmoke",
                                                            fangji = "¡˘Œ∂µÿª∆ÕË°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "‘Û–∫",
                                                                    value = 1,
                                                                    name2 = "‘Û–∫",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "¡˘Œ∂µÿª∆ÕË°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "‹Ú‹ﬂ",
                                                                            value = 1,
                                                                            name2 = "‹Ú‹ﬂ",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "¡˘Œ∂µÿª∆ÕË°Ô",
                                                                        },
                                                                    }
                                                                },
                                                            }
                                                        },
                                                        new Node
                                                        {
                                                            name = "πÍº◊Ω∫",
                                                            value = 1,
                                                            name2 = "πÍº◊Ω∫",
                                                            colour = "WhiteSmoke",
                                                            fangji = "◊ÛπÈÕË",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "≈£œ•",
                                                                    value = 1,
                                                                    name2 = "≈£œ•",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "◊ÛπÈÕË",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "›ÀÀø◊”",
                                                                            value = 1,
                                                                            name2 = "›ÀÀø◊”",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "◊ÛπÈÕË",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "Ë€ËΩ◊”",
                                                                                    value = 1,
                                                                                    name2 = "Ë€ËΩ◊”",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "◊ÛπÈÕË",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "¬πΩ«Ω∫",
                                                                                            value = 1,
                                                                                            name2 = "¬πΩ«Ω∫",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "◊ÛπÈÕË",
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
                    name2 = " Ïµÿª∆",
                    colour = "WhiteSmoke",
                    fangji = "¥Û≤π“ıÕË°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = " ",
                            value = 1,
                            name2 = " Ïµÿª∆",
                            colour = "WhiteSmoke",
                            fangji = "¥Û≤π“ıÕË°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "πÍº◊",
                                    value = 1,
                                    name2 = "πÍº◊",
                                    colour = "Blue",
                                    fangji = "¥Û≤π“ıÕË°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "ª∆∞ÿ",
                                            value = 1,
                                            name2 = "ª∆∞ÿ",
                                            colour = "WhiteSmoke",
                                            fangji = "¥Û≤π“ıÕË°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "÷™ƒ∏",
                                                    value = 1,
                                                    name2 = "÷™ƒ∏",
                                                    colour = "WhiteSmoke",
                                                    fangji = "¥Û≤π“ıÕË°Ô",
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
                    name = "…Ω‹Ô›«",
                    value = 1,
                    name2 = "…Ω‹Ô›«",
                    colour = "Blue",
                    fangji = "µÿª∆“˚◊”°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "»‚‹ »ÿ",
                            value = 1,
                            name2 = "»‚‹ »ÿ",
                            colour = "Blue",
                            fangji = "µÿª∆“˚◊”°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "∞ÕÍ™ÃÏ",
                                    value = 1,
                                    name2 = "∞ÕÍ™ÃÏ",
                                    colour = "Blue",
                                    fangji = "µÿª∆“˚◊”°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = " Øı˙",
                                            value = 1,
                                            name2 = " Øı˙",
                                            colour = "WhiteSmoke",
                                            fangji = "µÿª∆“˚◊”°Ô",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "¬Û∂¨",
                                                    value = 1,
                                                    name2 = "¬Û∂¨",
                                                    colour = "WhiteSmoke",
                                                    fangji = "µÿª∆“˚◊”°Ô",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "»‚π",
                                                            value = 1,
                                                            name2 = "»‚π",
                                                            colour = "WhiteSmoke",
                                                            fangji = "µÿª∆“˚◊”°Ô",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "∏Ω◊”",
                                                                    value = 1,
                                                                    name2 = "∏Ω◊”",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "µÿª∆“˚◊”°Ô",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = "‹Ú‹ﬂ",
                                                                            value = 1,
                                                                            name2 = "‹Ú‹ﬂ",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "µÿª∆“˚◊”°Ô",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "¥Û‘Ê",
                                                                                    value = 1,
                                                                                    name2 = "¥Û‘Ê",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "µÿª∆“˚◊”°Ô",
                                                                                    children = new Node[]
                                                                                    {
                                                                                        new Node
                                                                                        {
                                                                                            name = "ŒÂŒ∂◊”",
                                                                                            value = 1,
                                                                                            name2 = "ŒÂŒ∂◊”",
                                                                                            colour = "WhiteSmoke",
                                                                                            fangji = "µÿª∆“˚◊”°Ô",
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
            name = "¬πΩ«Ω∫",
            value = 2,
            name2 = "¬πΩ«Ω∫",
            colour = "Blue",
            fangji = "πÍ¬π∂˛œ…Ω∫°Ô°¢”“πÈÕË",
            children = new Node[]
            {
                new Node
                {
                    name = " ",
                    value = 1,
                    name2 = "¬πΩ«Ω∫",
                    colour = "WhiteSmoke",
                    fangji = "πÍ¬π∂˛œ…Ω∫°Ô",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "πÍº◊Ω∫",
                            value = 1,
                            name2 = "πÍº◊Ω∫",
                            colour = "Blue",
                            fangji = "πÍ¬π∂˛œ…Ω∫°Ô",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "»À≤Œ",
                                    value = 1,
                                    name2 = "»À≤Œ",
                                    colour = "WhiteSmoke",
                                    fangji = "πÍ¬π∂˛œ…Ω∫°Ô",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "Ë€ËΩ◊”",
                                            value = 1,
                                            name2 = "Ë€ËΩ◊”",
                                            colour = "WhiteSmoke",
                                            fangji = "πÍ¬π∂˛œ…Ω∫°Ô",
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
                new Node
                {
                    name = "»‚π",
                    value = 1,
                    name2 = "»‚π",
                    colour = "Blue",
                    fangji = "”“πÈÕË",
                    children = new Node[]
                    {
                        new Node
                        {
                            name = "∏Ω◊”",
                            value = 1,
                            name2 = "∏Ω◊”",
                            colour = "Blue",
                            fangji = "”“πÈÕË",
                            children = new Node[]
                            {
                                new Node
                                {
                                    name = "µ±πÈ",
                                    value = 1,
                                    name2 = "µ±πÈ",
                                    colour = "WhiteSmoke",
                                    fangji = "”“πÈÕË",
                                    children = new Node[]
                                    {
                                        new Node
                                        {
                                            name = "Ë€ËΩ◊”",
                                            value = 1,
                                            name2 = "Ë€ËΩ◊”",
                                            colour = "WhiteSmoke",
                                            fangji = "”“πÈÕË",
                                            children = new Node[]
                                            {
                                                new Node
                                                {
                                                    name = "›ÀÀø◊”",
                                                    value = 1,
                                                    name2 = "›ÀÀø◊”",
                                                    colour = "WhiteSmoke",
                                                    fangji = "”“πÈÕË",
                                                    children = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            name = "…Ω“©",
                                                            value = 1,
                                                            name2 = "…Ω“©",
                                                            colour = "WhiteSmoke",
                                                            fangji = "”“πÈÕË",
                                                            children = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    name = "∂≈÷Ÿ",
                                                                    value = 1,
                                                                    name2 = "∂≈÷Ÿ",
                                                                    colour = "WhiteSmoke",
                                                                    fangji = "”“πÈÕË",
                                                                    children = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            name = " Ïµÿª∆",
                                                                            value = 1,
                                                                            name2 = " Ïµÿª∆",
                                                                            colour = "WhiteSmoke",
                                                                            fangji = "”“πÈÕË",
                                                                            children = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    name = "…Ω‹Ô›«",
                                                                                    value = 1,
                                                                                    name2 = "…Ω‹Ô›«",
                                                                                    colour = "WhiteSmoke",
                                                                                    fangji = "”“πÈÕË",
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
