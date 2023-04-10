# [Root](./README.md) - Initialize

## Summary

The Initialize class is a static class used to initialize Frostbyte and start the boot sequence.

## Usage

```cs
Initialize.StoreLogs();             // Store logs temporarily, before the filesystem is initialized.
Initialize.MKFS();                  // Initialize the filesystem if it has not been initialized prior.
Initialize.SplashLogs();            // *Splash logs into the filesystem
```

* [Splash](/docs/terms/splash.md)
