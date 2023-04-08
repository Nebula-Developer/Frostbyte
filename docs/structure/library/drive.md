# Drive

## Summary

Drive is a class that will create a host-OS located drive that will be accessible by Frostbyte.

## Usage

```cs
DriveConfig config = new DriveConfig() {
    string Name,
    string Path,
    int ProtectionLevel,
    bool ReadOnly
};

Drive drive = new Drive(DriveConfig config);
```
