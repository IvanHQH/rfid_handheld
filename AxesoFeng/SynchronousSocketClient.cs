using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace AxesoFeng
{
    class SynchronousSocketClient
    {
        public static void StartClient()
        {
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024];

            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // This example uses port 11000 on the local computer.
                //IPHostEntry ipHostInfo = Dns.GetHostEntry("queue.dev.smartwaresol.com");

                String hostIp = "queue.dev.smartwaresol.com";
                IPHostEntry ipHostInfo = Dns.GetHostEntry(hostIp);
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8080);

                // Create a TCP/IP  socket.
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.Connect(remoteEP);

                    // Send the data through the socket.
                    String request = "GET /v1.0/rfid/feng/epcs HTTP/1.0\r\n" +
                                        "Host: " + hostIp + ":8080\r\n" +
                                        "Content-length: 0\r\n" +
                                        "Content-Type: application/json\r\n" +
                                        "Accept: application/json\r\n" +
                                        "Authorization: Basic YWRtaW5fdXNlcjpwYXNzd29yZA==\r\n" +
                                        "Connection: Close\r\n" +
                                        "\r\n";


                    System.Console.WriteLine(request);
                    int bytesSent = sender.Send(Encoding.Default.GetBytes(request));


                    // Receive the response from the remote device.
                    int bytesRec = 0;
                    String response=string.Empty;
                    do
                    {
                        bytesRec = sender.Receive(bytes);
                        response += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        System.Console.WriteLine(response);
                    } while (bytesRec > 0);

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
