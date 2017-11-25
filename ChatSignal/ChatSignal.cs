using System;

namespace ChatSignal
{
    public static class ChatSignal
    {
		public static byte ACK = 0;
		public static byte REQ_SEND_TEXT = 1;
		public static byte REQ_SEND_VID = 2;
		public static byte REQ_SEND_VCE = 3;
		public static byte REQ_SEND_IMG = 4;
		public static byte FIN_SEND;
    }
}
