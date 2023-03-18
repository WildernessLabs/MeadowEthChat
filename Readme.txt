This is a very simple C# app intended only to show that Ethernet is working on Meadow.

In the Meadow.OS code
1. Include the Echo Server in the Meadow.OS build (see hcom_shared_common.h).
2. Build and flash OS.
3. Use CLI to sent a 'developer 2' command with any value. This put the Echo Server thread in a forever loop (preventing CLI commands from read).

To use this Ethernet Chat application
1. Build the code.
2. After the 'developer 2' CLI command has been sent, click the 'Connect' button.
3. There are 2 modes of operation:
	- For sending random binary data of lengths (1 - 2048 bytes). Check the 'Generate Random' check box.
	- To send the text in the 'Text to Send' field uncheck the 'Generate Random' check box.
4. Adjust the 'Send Count' field if more than one iteration is desired.
5. Click the 'Start' button to begin sending data.

The Chat Server will receive the data and echo it back to this application.
Once received it will be compared with the data sent (length and contents)
If the data matches the #Success text box is incremented. If the data does not match the data sent the #Errors text box is incremented.
When the number of messages sent matches the Send Count text box entry the total time taken will be displayed.

To Exit testing, Restart Meadow, there is no other way to kill the Chat Server.