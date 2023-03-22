using System.Net.Sockets;
using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace ServerPr
{
    public partial class Form1 : Form
    {
        Socket server;
        IPEndPoint point;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (server == null)
                return;
            server.Bind(point);
            server.Listen(100);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
        }
        void ServerAcceptDelegate(IAsyncResult result)
        {

            if (result != null)
            {
                Socket serv = (Socket)result.AsyncState;
                Socket clientsocket = serv.EndAccept(result);

                clientsocket.Send(Encoding.UTF8.GetBytes("Подключение установлено."));
                IAsyncResult updateText = rtb_chat.BeginInvoke(RichTextBoxOutputDelegate, clientsocket.RemoteEndPoint.ToString());
                rtb_chat.EndInvoke(updateText);

                byte[] buffer = new byte[1024];
                
                /*ArraySegment<byte> segment = new ArraySegment<byte>(buffer, 0, buffer.Length);
                Task<int> answer = clientsocket.ReceiveAsync(segment, SocketFlags.None);
                if (answer.IsCompleted)
                {
                    updateText = rtb_chat.BeginInvoke(RichTextBoxOutputDelegate, Encoding.UTF8.GetString(segment));
                    rtb_chat.EndInvoke(updateText);
                }*/
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
               
                clientsocket.Shutdown(SocketShutdown.Send);
                clientsocket.Close();
                serv.BeginAccept(ServerAcceptDelegate, serv);
            }

        }
        private void RichTextBoxOutputDelegate(object obj)
        {
            rtb_chat.Text += (string)obj;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                server.BeginAccept(ServerAcceptDelegate, server);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}