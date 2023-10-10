using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Serialization;

namespace C_Script
{

    public struct JsonData
    {
        public List<PlayerMessage> JsonList;
    }
    [Serializable]
    public struct PlayerMessage
    {
        public int PlayerID;
        public string PlayerName;
    }

    public class JsonTest : MonoBehaviour
    {
        private string _path = Application.streamingAssetsPath+ "/JsonTest.json";
        [SerializeField]private List<PlayerMessage> writeDataList;
        [SerializeField]private List<PlayerMessage> readDataList;
        private void Awake()
        {
            Debug.Log(Application.streamingAssetsPath);
            InitData();
            WriteData();
            ReadData();
        }

        private void InitData()
        {
            writeDataList = new List<PlayerMessage>();
            PlayerMessage playerMessage = new PlayerMessage();
            playerMessage.PlayerID = 1;
            playerMessage.PlayerName = "wcng";
            writeDataList.Add(playerMessage);
        }

        private void WriteData()
        {
            JsonData jsonData = new JsonData();
            jsonData.JsonList = writeDataList;
            if (!File.Exists(_path))
            {
                File.Create(_path);
            }
            string json = JsonUtility.ToJson(jsonData, true);
            File.WriteAllText(_path,json);
        }

        private void ReadData()
        {
            if (!File.Exists(_path))
            {
                Debug.LogWarning("此文件不存在");
            }
            string json = File.ReadAllText(_path);
            var jsonData = JsonUtility.FromJson<JsonData>(json);
            readDataList.Add(jsonData.JsonList[0]);
        }
    }
}
