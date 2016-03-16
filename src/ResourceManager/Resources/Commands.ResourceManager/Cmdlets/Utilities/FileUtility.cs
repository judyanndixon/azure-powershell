﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Utilities
{
    using Microsoft.Azure.Commands.Common.Authentication;
    using ProjectResources = Microsoft.Azure.Commands.ResourceManager.Cmdlets.Properties.Resources;
    using System;
    using System.IO;
    using System.Text;

    /// <summary>
    /// The file utility.
    /// </summary>
    public static class FileUtility
    {
        /// <summary>
        /// Saves a template file into specific directory.
        /// </summary>
        /// <param name="deploymentName">The deployment name</param>
        /// <param name="contents">The template contents</param>
        /// <param name="outputPath">The file output path</param>
        /// <param name="overwrite">Overrides existing file</param>
        /// <param name="confirmAction">The confirmation action</param>
        /// <returns>The file path</returns>
        public static string SaveTemplateFile(string deploymentName, string contents, string outputPath, bool overwrite, Action<bool, string, string, string, Action> confirmAction)
        {
            StringBuilder finalOutputPath = new StringBuilder();

            if (!FileUtilities.IsValidDirectoryPath(outputPath))
            {
                // Try create the directory if it does not exist.
                FileUtilities.DataStore.CreateDirectory(Path.GetDirectoryName(outputPath));
            }

            if (FileUtilities.IsValidDirectoryPath(outputPath))
            {
                finalOutputPath.Append(Path.Combine(outputPath, deploymentName + ".json"));
            }
            else
            {
                finalOutputPath.Append(outputPath);
                if (!outputPath.EndsWith(".json"))
                {
                    finalOutputPath.Append(".json");
                }
            }

            Action saveFile = () => FileUtilities.DataStore.WriteFile(finalOutputPath.ToString(), contents);

            if (FileUtilities.DataStore.FileExists(finalOutputPath.ToString()) && confirmAction != null)
            {
                confirmAction(
                    overwrite,
                    string.Format(ProjectResources.FileAlreadyExists, finalOutputPath.ToString()),
                    ProjectResources.OverrdingFile,
                    finalOutputPath.ToString(),
                    saveFile);
            }
            else
            {
                saveFile();
            }

            return finalOutputPath.ToString();
        }
    }
}
