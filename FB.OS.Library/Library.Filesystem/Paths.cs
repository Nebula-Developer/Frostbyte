using System.IO;

namespace FB.OS.Library.Filesystem;

/// <summary>
/// A class that provides a set of static methods and baseplates for working with paths.
/// </summary>
public static class Paths {
    /// <summary>
    /// Combines two or more strings into a path.
    /// </summary>
    public static string Join(params string[] paths) => Path.Combine(paths);
    
    /// <summary>
    /// A path that is relative to the project executable.
    /// </summary>
    public static string RelativeToExecutable(string path) => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);

    /// <summary>
    /// The root directory of all drives.
    /// </summary>
    public static Func<string> GetRoot = () => RelativeToExecutable("root");

    /// <summary>
    /// The root directory of all drives.
    /// </summary>
    public static string Root => GetRoot();
}