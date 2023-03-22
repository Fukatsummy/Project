using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Text;


namespace Project
{
    public partial class Form1 : Form
    {
        Socket client;
        IPEndPoint point;
        public Form1()
        {
            InitializeComponent();
        }
        // Thread send = new Thread(new ThreadStart(Send));
        static string message = "";
        private void btn_con_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
                client.BeginConnect(point, (IAsyncResult result) =>
                {
                    Socket clientAsync = (Socket)result.AsyncState;
                    if (clientAsync.Connected)
                    {
                        byte[] buffer = new byte[1024];
                        int answerServer = client.Receive(buffer);
                        while (answerServer > 0)
                        {
                            rtb_client.Text += Encoding.UTF8.GetString(buffer);
                            answerServer = client.Receive(buffer);
                        }
                    }
                    client.EndConnect(result);
                }, client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text);
            ArraySegment<byte> segment = new ArraySegment<byte>(buffer, 0, buffer.Length);
            client.SendAsync(segment, SocketFlags.None);
            client.Send(System.Text.Encoding.Unicode.GetBytes(textBox1.Text));
            new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
            // client.Send(Encoding.UTF8.GetBytes(message));
        }
    }
}