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
        // (1) ���� ��ü ���� (TCP ����)
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // (2) ������ ����
        var ep = new IPEndPoint(IPAddress.Parse("172.30.1.57"), 7000);
        sock.Connect(ep);

        string cmd = string.Empty;
        byte[] receiverBuff = new byte[8192];

        Console.WriteLine("Connected... Enter Q to exit");
        // Q �� ���� ������ ��� Echo ����
        while (true)
        {
            byte[] buff;

            string data;

            cmd = json;

            buff = Encoding.UTF8.GetBytes(cmd);

            // (3) ������ ����Ÿ ����
            sock.Send(buff, SocketFlags.None);

            // (4) �������� ����Ÿ ����
            int n = sock.Receive(receiverBuff);

            data = Encoding.UTF8.GetString(receiverBuff, 0, n);
            print(data);
        }

        // (5) ���� �ݱ�
        sock.Close();
    }

    private void Awake()
    {
        json = jsonPrinter.ToJson();
        print("������ ���Ƚ��ϴ�.");
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
