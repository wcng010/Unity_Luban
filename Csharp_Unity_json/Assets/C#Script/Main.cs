using System.Collections.Generic;
using System.IO;
using UnityEngine;
using SimpleJSON;

public class Main : MonoBehaviour
{
    [SerializeField] private cfg.item.Item[] dataList ;
    // Start is called before the first frame update
    void Start()
    {
        dataList = new cfg.item.Item[100];
        var tables = new cfg.Tables(LoadByteBuf);
        tables.TbItem.DataList.CopyTo(dataList);
        foreach (var item in tables.TbItem.DataList)
        {
            
        }
        //tables.TbTestScriptableObject
    }

    private static JSONNode LoadByteBuf(string file)
    {
        return JSON.Parse(File.ReadAllText(Application.dataPath + "/GenerateDatas/json/" + file + ".json", System.Text.Encoding.UTF8));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
