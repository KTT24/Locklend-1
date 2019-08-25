// ===========
// DO NOT EDIT - this file is automatically regenerated.
// ===========

using System;
using Improbable.Gdk.BuildSystem;
using Improbable.Gdk.BuildSystem.Configuration;
using Improbable.Gdk.Tools;
using UnityEditor;
using UnityEngine;

namespace Improbable
{
    internal static class BuildWorkerMenu
    {
        private const string LocalMenu = "Build for local";
        private const string CloudMenu = "Build for cloud";

        private static readonly string[] AllWorkers =
        {
        };


        [MenuItem(EditorConfig.ParentMenu + "/" + LocalMenu + "/All workers", false, EditorConfig.MenuOffset + 0)]
        public static void BuildLocalAll()
        {
            MenuBuildLocal(AllWorkers);
        }

        [MenuItem(EditorConfig.ParentMenu + "/" + CloudMenu + "/All workers", false, EditorConfig.MenuOffset + 0)]
        public static void BuildCloudAll()
        {
            MenuBuildCloud(AllWorkers);
        }

        [MenuItem(EditorConfig.ParentMenu + "/Clean all workers", false, EditorConfig.MenuOffset + 0)]
        public static void Clean()
        {
            MenuCleanAll();
        }

        private static void MenuBuildLocal(string[] filteredWorkerTypes)
        {
            WorkerBuilder.MenuBuild(BuildEnvironment.Local, filteredWorkerTypes);
        }

        private static void MenuBuildCloud(string[] filteredWorkerTypes)
        {
            WorkerBuilder.MenuBuild(BuildEnvironment.Cloud, filteredWorkerTypes);
        }

        private static void MenuCleanAll()
        {
            WorkerBuilder.Clean();
            Debug.Log("Clean completed");
        }
    }
}
