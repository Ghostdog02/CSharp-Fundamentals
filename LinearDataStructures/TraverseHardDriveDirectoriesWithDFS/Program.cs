﻿using System;
using System.IO;

namespace TraverseHardDriveDirectoriesWithDFS
{
    /// <summary>
    /// Sample class, which traverses recursively given directory
    /// based on the Depth-First-Search (DFS) algorithm
    /// </summary>
    public static class DirectoryTraverserDFS
    {
        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="dir">the directory to be traversed</param>
        /// <param name="spaces">the spaces used for representation
        /// of the parent-child relation</param>
        private static void TraverseDir(DirectoryInfo dir,
        string spaces)
        {
            // Visit the current directory
            Console.WriteLine(spaces + dir.FullName);
            DirectoryInfo[] children = dir.GetDirectories();
            // For each child go and visit its sub-tree
            foreach (DirectoryInfo child in children)
            {
                TraverseDir(child, spaces + " ");
            }
        }
        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="directoryPath">the path to the directory
        /// which should be traversed</param>
        static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath),
            string.Empty);
        }
        static void Main()
        {
            TraverseDir("C:\\");
        }
    }

}