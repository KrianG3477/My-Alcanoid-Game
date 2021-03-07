using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class JsonPrinter : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;

    private void Awake()
    {
        PrintJson();
    }

    public void PrintJson()
    {
        string json = ToJson();
        ToObject(json);
    }

    public PlayerData ToObject(string json) 
    {
        //�÷��̾� �������� ������ȭ
        PlayerData obj = JsonConvert.DeserializeObject<PlayerData>(json);
        Debug.Log($"player �������� �̸��� {obj.Name}�̴�.");
        Debug.Log($"player �������� ������ {obj.Score}�̴�.");

        return obj;
    }

    public string ToJson()
    {
        //�÷��̾� �������� ����ȭ
        PlayerData playerData = new PlayerData
        {
            Score = 1234,
            Name = "Kim"
        };
        string jsonString = JsonConvert.SerializeObject(playerData, Formatting.Indented);
        Debug.Log($"json ������ {jsonString}");

        return jsonString;
    }
}

public class PlayerData
{
    public string Name { get; set; }
    public uint Score { get; set; }
}