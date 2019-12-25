using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;

namespace WebSocketApp
{
   public class P2PClient
    {
     
        public void Connect(string url)
        {
           
                WebSocket ws = new WebSocket(url);
                ws.OnMessage += (sender, e) =>
                {
                    if (e.Data == "Hi Client")
                    {
                        Console.WriteLine(e.Data);
                    }

                };
                ws.Connect();
                ws.Send($"Hi Server");
         
        }


        public void Close()
        {

        }
       
    }
}
