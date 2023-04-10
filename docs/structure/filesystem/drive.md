# [Filesystem](./README.md) - Drive

## Summary

Drive is a class that will create a host-OS located drive that will be accessible by Frostbyte.

## Usage

```cs
Drive drive = new Drive(new DriveConfig() {
    Label = "Example Drive",
    Host = HostPath.Root,
    Path = AppDomain.CurrentDomain.BaseDirectory,
    ReadOnly = false,
    System = false
});

// Example of how to use the drive

drive.Initialize()                  // Initializes the drive

     .Exists("file.txt")            // Returns true if file.txt exists in the drive
     .Touch("file.txt")             // Creates file.txt if it doesn't exist
     .Rm("file.txt")                // Deletes file.txt

     .ReadText("file.txt")          // Returns the contents of file.txt
     .Write("file.txt", "test")     // Writes "Hello World!" to file.txt, overwriting the contents

     .Mkdir("directory")            // Creates directory
     .Rmdir("directory")            // Deletes directory

     .List()                        // Returns a list of all files and directories in the drive
     .List("directory");            // Returns a list of all files and directories in the directory
```
