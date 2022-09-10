using System;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    class Messages
    {
               
        private const string TITLE = "Digao Desk";

        public static void Error(string msg)
        {
            MessageBox.Show(msg, TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(string msg)
        {
            MessageBox.Show(msg, TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Info(string msg)
        {
            MessageBox.Show(msg, TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Question(string msg)
        {
            return MessageBox.Show(msg, TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        //

        public class MessageException : Exception
        {
            public MessageException(string message) : base(message)
            {
            }
        }

        public static void ThrowMsg(string msg)
        {
            throw new MessageException(msg);
        }

        public static bool SurroundMessageException(Action proc)
        {
            try
            {
                proc();                
            } 
            catch (MessageException msgEx)
            {
                Error(msgEx.Message);
                return true;
            }
            return false;
        }

        public static void SurroundExceptionThenThrowMessageException(Action proc)
        {
            try
            {
                proc();
            }
            catch (Exception ex)
            {
                throw new MessageException(ex.Message);
            }
        }

    }
}
