# hhadblock

This blocks some ads and maybe posible dangerous links

# What this program do?

This program replaces hosts file of the operating system and blocks this links

How to use?

Build with the command 

`dotnet build`

Run the program

dotnet run with sudo (Mac/Linux)

And if you are in Windows run the executable as administrator this it's because replaces the hosts file of your system.

# How to block this websites?

When you run the program probably detect your platform like:

Windows: Windows detected!
MacOS: macOS Detected!
Linux: Linux detected!

After this lines THE PROGRAM WAITS THE USER INPUT for start the program you can write this options.

block : Block the ads websites.
unlock: Unblock the ads websites.

# What happend if i need restore the original hosts file?

When replaces the hosts before the program do this, make a hosts.bak (backup in the same directory where is the hosts file)

For restore the original hosts file please write 'unlock' and the program restores the file. (MAKE SURE YOUR RUNNING AS ADMIN or SUDO)

