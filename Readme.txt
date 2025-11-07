This is a simple C# app intended only to show that Ethernet is working on the breakout board.
1. Include the Chat Server in the Meadow.OS build (see hcom_shared_common.h).
2. Build and flash OS to Meadow
3. Use CLI to send 'developer -p 5 -v 0' command (value is not used). This step
	will create a thread in a forever loop. Receiving messages from this app
	and echoing them back to this app.
5. Restart Meadow to kill thread and exit.