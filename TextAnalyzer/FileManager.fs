namespace FileManager
    open System.IO;

    module Read =
        let GetFileContent filePath =
            File.ReadAllText(filePath);