using System;
using System.IO;
using System.Linq;

namespace DirectoryHelperExtensions
{
    public static class CopyDirectoryHelper
    {
        #region [ -- Public Methods -- ] 

        public static bool DirectoryCopy(string sourceDirectory, string destinationDirectory)
        {
            try
            {
                // Check Directory
                ValidateExistsDirectory(sourceDirectory, destinationDirectory);

                //load directory info
                DirectoryInfo dirSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo[] subDirsSource = dirSource.GetDirectories();

                //get files directory origin
                FileInfo[] filesSource = dirSource.GetFiles();

                // Copy each file into it's new directory.
                filesSource.ToList().ForEach(file =>
                {
                    string tempPathFile = Path.Combine(destinationDirectory, file.Name);
                    ValidateExistsNewFileAndCopy(destinationDirectory, file, tempPathFile);
                });

                // Copy each subdirectory using recursion.
                subDirsSource.ToList().ForEach(subDir =>
                {
                    string tempSubPathFile = Path.Combine(destinationDirectory, subDir.Name);
                    DirectoryCopy(subDir.FullName, tempSubPathFile);
                });

                return true;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(
                    ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region [ -- Private Methods -- ] 

        private static void ValidateExistsNewFileAndCopy(string destinationDirectory, FileInfo fileSource, string tempPathFile)
        {
            //validate if the file already exists
            FileInfo newFile = new FileInfo(tempPathFile);
            if (newFile.Exists)
            {
                //ramdom Key never to duplicate records
                string keyRamdom = Guid.NewGuid().ToString("n").Substring(0, 8);
                tempPathFile = Path.Combine(destinationDirectory, keyRamdom + fileSource.Name);
                // validate the new directory using recursion.
                ValidateExistsNewFileAndCopy(destinationDirectory, fileSource, tempPathFile);
            }
            else
            {
                fileSource.CopyTo(tempPathFile, false);
            }
        }

        private static void ValidateExistsDirectory(string sourceDirectory, string destinationDirectory)
        {
                if (!Directory.Exists(sourceDirectory))
                {
                    throw new DirectoryNotFoundException(
                   "Failed to find source folder");
                }

                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }
        }

        #endregion

    }
}
