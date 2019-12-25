using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocketApp
{
   public class P2PServer:WebSocketBehavior
    {
        WebSocketServer wss = null;
        public void start()
        {
            wss = new WebSocketServer($"ws://127.0.0.1:{Program.Port}");
            wss.AddWebSocketService<P2PServer>("/service");
            wss.Start();
          
            Console.WriteLine($"Started server at ws://127.0.0.1:{Program.Port}");
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
            Send($"Hi Client");
        }

    }
}
