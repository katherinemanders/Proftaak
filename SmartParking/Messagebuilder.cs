using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParking
{
    // Class to extract messages from a text feed (like serial port).
    // Feed all data from the feed to the MessageBuilder by using the Add() method.
    // Use the GetMessage() method to retrieve the messages found in the feed.
    public class MessageBuilder
    {
        // Message from which more characters are to be expected from the feed.
        private string partlyMessage;
        
        // Buffer to store messages found in the feed.
        // Needed because its possible that multiple messages are parsed from the data input.
        private Queue<string> messages;
        
        // Marker that marks the start of a message.
        public char MessageBeginMarker { get; private set; }

        // Marker that marks the mark the end of a message.
        public char MessageEndMarker { get; private set; }
        
        // The number of available messages which can be retrieved using GetNextMessage()
        public int MessageCount
        {
            get
            {
                return messages.Count;
            }
        }

        // Create a MessageBuilder instance.
        // <param name="messageBeginMarker">
        // Marker that is used to find the start of a message 
        // when trying to find messages in the buffered data.
        // </param>
        // <param name="messageEndMarker">
        // Marker that is used to find the end of a message 
        // when trying to find messages in the buffered data.
        // </param>
        public MessageBuilder(char messageBeginMarker, char messageEndMarker)
        {
            MessageBeginMarker = messageBeginMarker;
            MessageEndMarker = messageEndMarker;
            messages = new Queue<string>();
            partlyMessage = null;
        }
        
        // Feeds data containing (possible) messages to the MessageBuilder.
        // After using Add, use GetMessage() to retrieve messages contained in the data.
        // 
        // Its possible that an incomplete message is contained in the data.
        // <param name="data">
        // data from the feed containing possible messages.
        // </param>
        public void Add(string data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            string message;
            bool messageStarted;
            if (partlyMessage != null)
            {
                message = partlyMessage;
                messageStarted = true;
                partlyMessage = null;
            }
            else
            {
                message = "";
                messageStarted = false;
            }

            foreach (char character in data)
            {
                if (messageStarted)
                {
                    if (character != MessageEndMarker)
                    {
                        message += character;
                    }
                    else
                    {
                        messages.Enqueue(message);
                        message = "";
                        messageStarted = false;
                    }
                }
                else
                {
                    if (character == MessageBeginMarker)
                    {
                        messageStarted = true;
                    }
                }
            }

            if (messageStarted)
            {
                partlyMessage = message;
            }
        }

        // Gets the next message that was present in the MessageBuilder.
        // Use Add() to add data to the MessageBuilder from which messages should be extracted.
        // 
        // It's possible that multiple messages are present in the MessageBuilder. 
        // So call GetMessage() until it returns null after using Add().
        // <returns>
        // The next message, or null if no message was present in the builder.
        // </returns>
        public string GetNextMessage()
        {
            if (messages.Count > 0)
            {
                return messages.Dequeue();
            }
            return null;
        }
        
        // Clear all buffered messages and message data
        public void Clear()
        {
            messages.Clear();
            partlyMessage = null;
        }
    }
}
