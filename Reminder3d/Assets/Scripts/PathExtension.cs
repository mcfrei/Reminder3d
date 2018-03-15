using UnityEngine;
using System.Collections.Generic;
using System.IO;

class PathExtension
{
    public static string Combine(params string[] paths)
    {
        if (paths.Length == 0)
            return string.Empty;
        string curr = null;
        int i = 0;
        do
        {
            curr = paths[i++];
        }
        while (string.IsNullOrEmpty(curr) || i >= paths.Length);
        if (string.IsNullOrEmpty(curr))
            return string.Empty;
        while (i < paths.Length)
        {
            if (!string.IsNullOrEmpty(paths[i]))
                curr = Path.Combine(curr, paths[i]);
            ++i;
        }
        return curr;
    }
}
