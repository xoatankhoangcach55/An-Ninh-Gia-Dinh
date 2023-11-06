using WebSocketSharp;

namespace AnNinhGiaDinh
{
    public partial class Form1 : Form
    {
        string url = "127.0.0.1:3000";
        public Form1()
        {
            InitializeComponent();
            var ws = new WebSocket($"ws://{this.url}/ws");
            ws.OnOpen += Ws_OnOpen;
            ws.OnMessage += Ws_OnMessage;
            ws.Connect();
            ws.Send("Hello World!");
        }

        private static void Ws_OnOpen(object? sender, EventArgs e)
        {
            MessageBox.Show("Connection");
        }

        private static void Ws_OnMessage(object? sender, MessageEventArgs e)
        {
            Console.WriteLine("Received from the server " + e.Data);
        }
    }
}