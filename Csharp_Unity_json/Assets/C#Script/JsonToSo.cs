using System.IO;
using cfg.item;
using SimpleJSON;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace C_Script
{
    public class JsonToSo : EditorWindow
    {
        private static string saveScriptableObjectPath = "Assets/Data";
        private static string JsonFilePath = "D:/UnityProject/Practice/Csharp_Unity_json/Assets/GenerateDatas/json";
        [MenuItem("EditorTools/JsonToSo")]
        public static void ReadJsonData()
        {
            DirectoryInfo direction = new DirectoryInfo(JsonFilePath);
            FileInfo[] files = direction.GetFiles("*", SearchOption.AllDirectories);

            foreach (var fileInfo in files)
            {
                if (fileInfo.Name.EndsWith(".meta"))
                {
                    continue;
                }
                JSONNode jsonNode = LoadByteBuf("item_tbitem");

                foreach (JSONNode _row in jsonNode)
                {
                    var So = CreateInstance<cfg.item.Item>();
                    So = cfg.item.Item.DeserializeItem(_row);
                    AssetDatabase.CreateAsset(So, saveScriptableObjectPath + "/" + So.Id + ".asset");
                }
                jsonNode = LoadByteBuf("demo_tbreward");
                foreach (JSONNode _row in jsonNode) 
                {
                    var So = CreateInstance<cfg.demo.Reward>();
                    So = cfg.demo.Reward.DeserializeReward(_row);
                    AssetDatabase.CreateAsset(So, saveScriptableObjectPath + "/" + So.Id + ".asset");
                }
            }
        }
        
        private static JSONNode LoadByteBuf(string file)
        {
            return JSON.Parse(File.ReadAllText(Application.dataPath + "/GenerateDatas/json/" + file + ".json", System.Text.Encoding.UTF8));
        }
    }
}
