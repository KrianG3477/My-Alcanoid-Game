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
        //플레이어 데이터의 역직렬화
        PlayerData obj = JsonConvert.DeserializeObject<PlayerData>(json);
        Debug.Log($"player 데이터의 이름은 {obj.Name}이다.");
        Debug.Log($"player 데이터의 점수는 {obj.Score}이다.");

        return obj;
    }

    public string ToJson()
    {
        //플레이어 데이터의 직렬화
        PlayerData playerData = new PlayerData
        {
            Score = 1234,
            Name = "Kim"
        };
        string jsonString = JsonConvert.SerializeObject(playerData, Formatting.Indented);
        Debug.Log($"json 데이터 {jsonString}");

        return jsonString;
    }
}

public class PlayerData
{
    public string Name { get; set; }
    public uint Score { get; set; }
}