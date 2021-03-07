using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class SocketTest : MonoBehaviour
{
    public JsonPrinter jsonPrinter;
    bool isExit = false;
    string json;

    private void Task()
    {
        // (1) 소켓 객체 생성 (TCP 소켓)
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // (2) 서버에 연결
        var ep = new IPEndPoint(IPAddress.Parse("172.30.1.57"), 7000);
        sock.Connect(ep);

        string cmd = string.Empty;
        byte[] receiverBuff = new byte[8192];

        Console.WriteLine("Connected... Enter Q to exit");
        // Q 를 누를 때까지 계속 Echo 실행
        while (true)
        {
            byte[] buff;

            string data;

            cmd = json;

            buff = Encoding.UTF8.GetBytes(cmd);

            // (3) 서버에 데이타 전송
            sock.Send(buff, SocketFlags.None);

            // (4) 서버에서 데이타 수신
            int n = sock.Receive(receiverBuff);

            data = Encoding.UTF8.GetString(receiverBuff, 0, n);
            print(data);
        }

        // (5) 소켓 닫기
        sock.Close();
    }

    private void Awake()
    {
        json = jsonPrinter.ToJson();
        print("소켓이 열렸습니다.");
        Thread socketThread = new Thread(() => 
        {
            Task();  
        }
        );

        socketThread.Start();

    }



    private void Update()
    {
        isExit = Input.GetKeyDown(KeyCode.Q);
    }
}
