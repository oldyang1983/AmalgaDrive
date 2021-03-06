﻿using System.IO;

namespace AmalgaDrive.DavServer.FileSystem
{
    public interface IFileInfo : IFileSystemInfo
    {
        long Length { get; }

        Stream OpenRead();
        Stream OpenWrite();
    }
}
