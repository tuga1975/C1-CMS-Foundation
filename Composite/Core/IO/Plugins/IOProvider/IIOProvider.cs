﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Composite.Core.Xml;
using System.Xml;
using System.Xml.Schema;
using Composite.Core.Implementation;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Security;
using System.Security.AccessControl;
using Composite.Core.IO.Plugins.IOProvider;
using Composite.Plugins.IO.IOProviders.LocalIOPorivder;
using Composite.Core.IO;
//using Composite.Core.IO;


namespace Composite.Core.Implementation
{
    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1DirectoryImplementation
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DirectoryInfo CreateDirectory(string path)
        {
            return IOFacade.C1Directory.CreateDirectory(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>        
        public virtual void Move(string sourceDirName, string destDirName)
        {
            IOFacade.C1Directory.Move(sourceDirName, destDirName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public virtual void Delete(string path)
        {
            IOFacade.C1Directory.Delete(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="recursive"></param>
        public virtual void Delete(string path, bool recursive)
        {
            IOFacade.C1Directory.Delete(path, recursive);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual bool Exists(string path)
        {
            return IOFacade.C1Directory.Exists(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public virtual string GetCurrentDirectory()
        {
            return IOFacade.C1Directory.GetCurrentDirectory();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public virtual void SetCurrentDirectory(string path)
        {
            IOFacade.C1Directory.SetCurrentDirectory(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DirectoryInfo GetParent(string path)
        {
            return IOFacade.C1Directory.GetParent(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual string GetDirectoryRoot(string path)
        {
            return IOFacade.C1Directory.GetDirectoryRoot(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual string[] GetDirectories(string path)
        {
            return IOFacade.C1Directory.GetDirectories(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        public virtual string[] GetDirectories(string path, string searchPattern)
        {
            return IOFacade.C1Directory.GetDirectories(path, searchPattern);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        public virtual string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return IOFacade.C1Directory.GetDirectories(path, searchPattern, searchOption);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual string[] GetFiles(string path)
        {
            return IOFacade.C1Directory.GetFiles(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        public virtual string[] GetFiles(string path, string searchPattern)
        {
            return IOFacade.C1Directory.GetFiles(path, searchPattern);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        public virtual string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return IOFacade.C1Directory.GetFiles(path, searchPattern, searchOption);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetCreationTime(string path)
        {
            return IOFacade.C1Directory.GetCreationTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetCreationTimeUtc(string path)
        {
            return IOFacade.C1Directory.GetCreationTimeUtc(path);
        }



        //public virtual IEnumerable<string> EnumerateDirectories(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateFiles(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateFileSystemEntries(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual string[] GetFileSystemEntries(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual string[] GetFileSystemEntries(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual DirectorySecurity GetAccessControl(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual void SetAccessControl(string path, DirectorySecurity directorySecurity)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual void SetCreationTime(string path, DateTime creationTime)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual string[] GetLogicalDrives()
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual DateTime GetLastAccessTime(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual DateTime GetLastAccessTimeUtc(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual DateTime GetLastWriteTime(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual DateTime GetLastWriteTimeUtc(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        //{ 
        //    throw new NotImplementedException(); 
        //}
    }



    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1FileImplementation
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual bool Exists(string path)
        {
            return IOFacade.C1File.Exists(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        public virtual void Copy(string sourceFileName, string destFileName)
        {
            IOFacade.C1File.Copy(sourceFileName, destFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        /// <param name="overwrite"></param>
        public virtual void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            IOFacade.C1File.Copy(sourceFileName, destFileName, overwrite);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        public virtual void Move(string sourceFileName, string destFileName)
        {
            IOFacade.C1File.Move(sourceFileName, destFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            IOFacade.C1File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        /// <param name="ignoreMetadataErrors"></param>
        public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            IOFacade.C1File.Replace(sourceFileName, destinationBackupFileName, destinationBackupFileName, ignoreMetadataErrors);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public virtual void Delete(string path)
        {
            IOFacade.C1File.Delete(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual C1FileStream Create(string path)
        {
            return IOFacade.C1File.Create(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        public virtual C1FileStream Create(string path, int bufferSize)
        {
            return IOFacade.C1File.Create(path, bufferSize);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bufferSize"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public virtual C1FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return IOFacade.C1File.Create(path, bufferSize, options);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual C1StreamWriter CreateText(string path)
        {
            return IOFacade.C1File.CreateText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual C1StreamWriter AppendText(string path)
        {
            return IOFacade.C1File.AppendText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public virtual void AppendAllText(string path, string contents)
        {
            IOFacade.C1File.AppendAllText(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public virtual void AppendAllText(string path, string contents, Encoding encoding)
        {
            IOFacade.C1File.AppendAllText(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public virtual void AppendAllLines(string path, IEnumerable<string> contents)
        {
            IOFacade.C1File.AppendAllLines(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public virtual void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            IOFacade.C1File.AppendAllLines(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public virtual C1FileStream Open(string path, FileMode mode)
        {
            return IOFacade.C1File.Open(path, mode);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <returns></returns>
        public virtual C1FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return IOFacade.C1File.Open(path, mode, access);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <returns></returns>
        public virtual C1FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return IOFacade.C1File.Open(path, mode, access, share);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual C1FileStream OpenRead(string path)
        {
            return IOFacade.C1File.OpenRead(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual C1StreamReader OpenText(string path)
        {
            return IOFacade.C1File.OpenText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual C1FileStream OpenWrite(string path)
        {
            return IOFacade.C1File.OpenWrite(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual byte[] ReadAllBytes(string path)
        {
            return IOFacade.C1File.ReadAllBytes(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual string[] ReadAllLines(string path)
        {
            return IOFacade.C1File.ReadAllLines(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public virtual string[] ReadAllLines(string path, Encoding encoding)
        {
            return IOFacade.C1File.ReadAllLines(path, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual string ReadAllText(string path)
        {
            return IOFacade.C1File.ReadAllText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public virtual string ReadAllText(string path, Encoding encoding)
        {
            return IOFacade.C1File.ReadAllText(path, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual IEnumerable<string> ReadLines(string path)
        {
            return IOFacade.C1File.ReadLines(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public virtual IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return IOFacade.C1File.ReadLines(path, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bytes"></param>
        public virtual void WriteAllBytes(string path, byte[] bytes)
        {
            IOFacade.C1File.WriteAllBytes(path, bytes);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public virtual void WriteAllLines(string path, IEnumerable<string> contents)
        {
            IOFacade.C1File.WriteAllLines(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public virtual void WriteAllLines(string path, string[] contents)
        {
            IOFacade.C1File.WriteAllLines(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public virtual void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            IOFacade.C1File.WriteAllLines(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public virtual void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            IOFacade.C1File.WriteAllLines(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public virtual void WriteAllText(string path, string contents)
        {
            IOFacade.C1File.WriteAllText(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public virtual void WriteAllText(string path, string contents, Encoding encoding)
        {
            IOFacade.C1File.WriteAllText(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual FileAttributes GetAttributes(string path)
        {
            return IOFacade.C1File.GetAttributes(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileAttributes"></param>
        public virtual void SetAttributes(string path, FileAttributes fileAttributes)
        {
            IOFacade.C1File.SetAttributes(path, fileAttributes);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetCreationTime(string path)
        {
            return IOFacade.C1File.GetCreationTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetCreationTimeUtc(string path)
        {
            return IOFacade.C1File.GetCreationTimeUtc(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTime"></param>
        public virtual void SetCreationTime(string path, DateTime creationTime)
        {
            IOFacade.C1File.SetCreationTime(path, creationTime);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTimeUtc"></param>
        public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            IOFacade.C1File.SetCreationTimeUtc(path, creationTimeUtc);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetLastAccessTime(string path)
        {
            return IOFacade.C1File.GetLastAccessTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetLastAccessTimeUtc(string path)
        {
            return IOFacade.C1File.GetLastAccessTimeUtc(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastAccessTime"></param>
        public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            IOFacade.C1File.SetLastAccessTime(path, lastAccessTime);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastAccessTimeUtc"></param>
        public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            IOFacade.C1File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetLastWriteTime(string path)
        {
            return IOFacade.C1File.GetLastWriteTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual DateTime GetLastWriteTimeUtc(string path)
        {
            return IOFacade.C1File.GetLastWriteTimeUtc(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastWriteTime"></param>
        public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            IOFacade.C1File.SetLastWriteTime(path, lastWriteTime);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastWriteTimeUtc"></param>
        public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            IOFacade.C1File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }



        //public virtual FileStream Create(string path, int bufferSize, System.IO.FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity)
        //{ 
        //    throw new NotImplementedException(); 
        //}




        //public virtual void Encrypt(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void Decrypt(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual System.Security.AccessControl.FileSecurity GetAccessControl(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity)
        //{ 
        //    throw new NotImplementedException(); 
        //}
    }




    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1FileStreamImplementation : IDisposable
    {
        private IC1FileStream _fileStream;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <param name="bufferSize"></param>
        /// <param name="options"></param>
        public C1FileStreamImplementation(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            _fileStream = IOFacade.CreateFileStream(path, mode, access, share, bufferSize, options);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual string Name
        {
            get
            {
                return _fileStream.Name;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual long Length
        {
            get
            {
                return _fileStream.Length;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void SetLength(long value)
        {
            _fileStream.SetLength(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual long Position
        {
            get
            {
                return _fileStream.Position;
            }
            set
            {
                _fileStream.Position = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual int Read([In, Out] byte[] array, int offset, int count)
        {
            return _fileStream.Read(array, offset, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public virtual int ReadByte()
        {
            return _fileStream.ReadByte();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        public virtual void Write(byte[] array, int offset, int count)
        {
            _fileStream.Write(array, offset, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteByte(byte value)
        {
            _fileStream.WriteByte(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        public virtual long Seek(long offset, SeekOrigin origin)
        {
            return _fileStream.Seek(offset, origin);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool CanRead
        {
            get
            {
                return _fileStream.CanRead;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool CanSeek
        {
            get
            {
                return _fileStream.CanSeek;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool CanWrite
        {
            get
            {
                return _fileStream.CanWrite;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void Flush()
        {
            _fileStream.Flush();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="flushToDisk"></param>
        public virtual void Flush(bool flushToDisk)
        {
            _fileStream.Flush(flushToDisk);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void Close()
        {
            _fileStream.Close();
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        ~C1FileStreamImplementation()
        {
            Dispose(false);
        }



        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _fileStream.Dispose();
            }
        }

        //public virtual bool IsAsync 
        //{ 
        //    get 
        //    { 
        //        throw new NotImplementedException(); 
        //    } 
        //}



        ////[Obsolete("This property has been deprecated.  Please use FileStream's SafeFileHandle property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        //public virtual IntPtr Handle 
        //{ 
        //    get 
        //    { 
        //        throw new NotImplementedException(); 
        //    } 
        //}



        //public virtual FileSecurity GetAccessControl() 
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void SetAccessControl(FileSecurity fileSecurity) 
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void Lock(long position, long length) 
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void Unlock(long position, long length) 
        //{ 
        //    throw new NotImplementedException(); 
        //}
    }





    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1FileSystemWatcherImplementation 
    {
        private IC1FileSystemWatcher _fileSystemWatcher;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filter"></param>
        public C1FileSystemWatcherImplementation(string path, string filter)
        {
            _fileSystemWatcher = IOFacade.CreateFileSystemWatcher(path, filter);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool EnableRaisingEvents
        {
            get
            {
                return _fileSystemWatcher.EnableRaisingEvents;
            }
            set
            {
                _fileSystemWatcher.EnableRaisingEvents = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual string Path
        {
            get
            {
                return _fileSystemWatcher.Path;
            }
            set
            {
                _fileSystemWatcher.Path = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual string Filter
        {
            get
            {
                return _fileSystemWatcher.Filter;
            }
            set
            {
                _fileSystemWatcher.Filter = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool IncludeSubdirectories
        {
            get
            {
                return _fileSystemWatcher.IncludeSubdirectories;
            }
            set
            {
                _fileSystemWatcher.IncludeSubdirectories = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual event FileSystemEventHandler Created
        {
            add
            {
                _fileSystemWatcher.Created += value;
            }
            remove
            {
                _fileSystemWatcher.Created -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual event FileSystemEventHandler Changed
        {
            add
            {
                _fileSystemWatcher.Changed += value;
            }
            remove
            {
                _fileSystemWatcher.Changed -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual event RenamedEventHandler Renamed
        {
            add
            {
                _fileSystemWatcher.Renamed += value;
            }
            remove
            {
                _fileSystemWatcher.Renamed -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual event FileSystemEventHandler Deleted
        {
            add
            {
                _fileSystemWatcher.Deleted += value;
            }
            remove
            {
                _fileSystemWatcher.Deleted -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual event ErrorEventHandler Error
        {
            add
            {
                _fileSystemWatcher.Error += value;
            }
            remove
            {
                _fileSystemWatcher.Error -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual NotifyFilters NotifyFilter
        {
            get
            {
                return _fileSystemWatcher.NotifyFilter;
            }
            set
            {
                _fileSystemWatcher.NotifyFilter = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void BeginInit()
        {
            _fileSystemWatcher.BeginInit();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void EndInit()
        {
            _fileSystemWatcher.EndInit();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="changeType"></param>
        /// <returns></returns>
        public virtual C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
        {
            return _fileSystemWatcher.WaitForChanged(changeType);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="changeType"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public virtual C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
        {
            return _fileSystemWatcher.WaitForChanged(changeType, timeout);
        }
    }






    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1StreamReaderImplementation : IDisposable
    {
        private IC1StreamReader _streamReader;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        /// <param name="bufferSize"></param>
        public C1StreamReaderImplementation(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            _streamReader = IOFacade.CreateC1StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        /// <param name="bufferSize"></param>
        public C1StreamReaderImplementation(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            _streamReader = IOFacade.CreateC1StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public virtual int Read()
        {
            return _streamReader.Read();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual int Read([In, Out] char[] buffer, int index, int count)
        {
            return _streamReader.Read(buffer, index, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public virtual string ReadLine()
        {
            return _streamReader.ReadLine();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public virtual string ReadToEnd()
        {
            return _streamReader.ReadToEnd();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual int ReadBlock(char[] buffer, int index, int count)
        {
            return _streamReader.ReadBlock(buffer, index, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public virtual int Peek()
        {
            return _streamReader.Peek();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool EndOfStream
        {
            get
            {
                return _streamReader.EndOfStream;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void Close()
        {
            _streamReader.Close();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual Stream BaseStream
        {
            get
            {
                return _streamReader.BaseStream;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual Encoding CurrentEncoding
        {
            get
            {
                return _streamReader.CurrentEncoding;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        ~C1StreamReaderImplementation()
        {
            Dispose(false);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _streamReader.Dispose();
            }
        }        
    }






    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1StreamWriterImplementation : IDisposable
    {
        private IC1StreamWriter _streamWriter;



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="append"></param>
        /// <param name="encoding"></param>
        /// <param name="bufferSize"></param>
        public C1StreamWriterImplementation(string path, bool append, Encoding encoding, int bufferSize)
        {
            _streamWriter = IOFacade.CreateStreamWriter(path, append, encoding, bufferSize);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <param name="bufferSize"></param>
        public C1StreamWriterImplementation(Stream stream, Encoding encoding, int bufferSize)
        {
            _streamWriter = IOFacade.CreateStreamWriter(stream, encoding, bufferSize);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(string value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        public virtual void Write(string format, object arg0)
        {
            _streamWriter.Write(format, arg0);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        public virtual void Write(string format, object arg0, object arg1)
        {
            _streamWriter.Write(format, arg0, arg1);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        public virtual void Write(string format, object arg0, object arg1, object arg2)
        {
            _streamWriter.Write(format, arg0, arg1, arg2);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg"></param>
        public virtual void Write(string format, params object[] arg)
        {
            _streamWriter.Write(format, arg);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(char value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        public virtual void Write(char[] buffer)
        {
            _streamWriter.Write(buffer);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public virtual void Write(char[] buffer, int index, int count)
        {
            _streamWriter.Write(buffer, index, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(bool value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(int value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(uint value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(long value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(ulong value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(float value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(double value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(decimal value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void Write(object value)
        {
            _streamWriter.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void WriteLine()
        {
            _streamWriter.WriteLine();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(string value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        public virtual void WriteLine(string format, object arg0)
        {
            _streamWriter.WriteLine(format, arg0);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        public virtual void WriteLine(string format, object arg0, object arg1)
        {
            _streamWriter.WriteLine(format, arg0, arg1);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            _streamWriter.WriteLine(format, arg0, arg1, arg2);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg"></param>
        public virtual void WriteLine(string format, params object[] arg)
        {
            _streamWriter.WriteLine(format, arg);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(char value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        public virtual void WriteLine(char[] buffer)
        {
            _streamWriter.WriteLine(buffer);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public virtual void WriteLine(char[] buffer, int index, int count)
        {
            _streamWriter.WriteLine(buffer, index, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(bool value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(int value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(uint value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(long value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(ulong value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(float value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(double value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(decimal value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public virtual void WriteLine(object value)
        {
            _streamWriter.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual string NewLine
        {
            get
            {
                return _streamWriter.NewLine;
            }
            set
            {
                _streamWriter.NewLine = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual IFormatProvider FormatProvider
        {
            get
            {
                return _streamWriter.FormatProvider;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void Flush()
        {
            _streamWriter.Flush();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool AutoFlush
        {
            get
            {
                return _streamWriter.AutoFlush;
            }
            set
            {
                _streamWriter.AutoFlush = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual void Close()
        {
            _streamWriter.Close();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual Stream BaseStream
        {
            get
            {
                return _streamWriter.BaseStream;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual Encoding Encoding
        {
            get
            {
                return _streamWriter.Encoding;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }



        ~C1StreamWriterImplementation()
        {
            Dispose(false);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _streamWriter.Dispose();
            }
        }
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


namespace Composite.Core.IO
{


    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public static class C1Directory
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DirectoryInfo CreateDirectory(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.CreateDirectory(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        public static void Move(string sourceDirName, string destDirName)
        {
            ImplementationFactory.CurrentFactory.StatelessC1Directory.Move(sourceDirName, destDirName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public static void Delete(string path)
        {
            ImplementationFactory.CurrentFactory.StatelessC1Directory.Delete(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="recursive"></param>
        public static void Delete(string path, bool recursive)
        {
            ImplementationFactory.CurrentFactory.StatelessC1Directory.Delete(path, recursive);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool Exists(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.Exists(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDirectory()
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetCurrentDirectory();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public static void SetCurrentDirectory(string path)
        {
            ImplementationFactory.CurrentFactory.StatelessC1Directory.SetCurrentDirectory(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DirectoryInfo GetParent(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetParent(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetDirectoryRoot(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetDirectoryRoot(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] GetDirectories(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetDirectories(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        public static string[] GetDirectories(string path, string searchPattern)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetDirectories(path, searchPattern);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetDirectories(path, searchPattern, searchOption);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] GetFiles(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetFiles(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        public static string[] GetFiles(string path, string searchPattern)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetFiles(path, searchPattern);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetFiles(path, searchPattern, searchOption);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetCreationTime(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetCreationTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetCreationTimeUtc(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1Directory.GetCreationTimeUtc(path);
        }



        //public static IEnumerable<string> EnumerateDirectories(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateFiles(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateFileSystemEntries(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public static string[] GetFileSystemEntries(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public static string[] GetFileSystemEntries(string path, string searchPattern)
        //{
        //    throw new NotImplementedException();
        //}



        //public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        //{
        //    throw new NotImplementedException();
        //}



        //public static DirectorySecurity GetAccessControl(string path)
        //{
        //    throw new NotImplementedException();
        //}



        //public static DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        //{
        //    throw new NotImplementedException();
        //}



        //public static void SetAccessControl(string path, DirectorySecurity directorySecurity)
        //{
        //    throw new NotImplementedException();
        //}



        //public static void SetCreationTime(string path, DateTime creationTime)
        //{
        //    throw new NotImplementedException();
        //}



        //public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static string[] GetLogicalDrives()
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static DateTime GetLastAccessTime(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static void SetLastAccessTime(string path, DateTime lastAccessTime)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static DateTime GetLastAccessTimeUtc(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static DateTime GetLastWriteTime(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static void SetLastWriteTime(string path, DateTime lastWriteTime)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static DateTime GetLastWriteTimeUtc(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        //{ 
        //    throw new NotImplementedException(); 
        //}
    }





    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public static class C1File
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool Exists(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.Exists(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        public static void Copy(string sourceFileName, string destFileName)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.Copy(sourceFileName, destFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        /// <param name="overwrite"></param>
        public static void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.Copy(sourceFileName, destFileName, overwrite);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        public static void Move(string sourceFileName, string destFileName)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.Move(sourceFileName, destFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        /// <param name="ignoreMetadataErrors"></param>
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public static void Delete(string path)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.Delete(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static C1FileStream Create(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.Create(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        public static C1FileStream Create(string path, int bufferSize)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.Create(path, bufferSize);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bufferSize"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static C1FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.Create(path, bufferSize, options);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static C1StreamWriter CreateText(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.CreateText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static C1StreamWriter AppendText(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.AppendText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public static void AppendAllText(string path, string contents)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.AppendAllText(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public static void AppendAllText(string path, string contents, Encoding encoding)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.AppendAllText(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public static void AppendAllLines(string path, IEnumerable<string> contents)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.AppendAllLines(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.AppendAllLines(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static C1FileStream Open(string path, FileMode mode)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.Open(path, mode);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <returns></returns>
        public static C1FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.Open(path, mode, access);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <returns></returns>
        public static C1FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.Open(path, mode, access, share);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static C1FileStream OpenRead(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.OpenRead(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static C1StreamReader OpenText(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.OpenText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static C1FileStream OpenWrite(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.OpenWrite(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static byte[] ReadAllBytes(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.ReadAllBytes(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] ReadAllLines(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.ReadAllLines(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string[] ReadAllLines(string path, Encoding encoding)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.ReadAllLines(path, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadAllText(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.ReadAllText(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string ReadAllText(string path, Encoding encoding)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.ReadAllText(path, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.ReadLines(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.ReadLines(path, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bytes"></param>
        public static void WriteAllBytes(string path, byte[] bytes)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.WriteAllBytes(path, bytes);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public static void WriteAllLines(string path, IEnumerable<string> contents)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.WriteAllLines(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public static void WriteAllLines(string path, string[] contents)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.WriteAllLines(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.WriteAllLines(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public static void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.WriteAllLines(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public static void WriteAllText(string path, string contents)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.WriteAllText(path, contents);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public static void WriteAllText(string path, string contents, Encoding encoding)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.WriteAllText(path, contents, encoding);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static FileAttributes GetAttributes(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.GetAttributes(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileAttributes"></param>
        public static void SetAttributes(string path, FileAttributes fileAttributes)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.SetAttributes(path, fileAttributes);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetCreationTime(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.GetCreationTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetCreationTimeUtc(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.GetCreationTimeUtc(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTime"></param>
        public static void SetCreationTime(string path, DateTime creationTime)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.SetCreationTime(path, creationTime);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTimeUtc"></param>
        public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.SetCreationTimeUtc(path, creationTimeUtc);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetLastAccessTime(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.GetLastAccessTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetLastAccessTimeUtc(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.GetLastAccessTimeUtc(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastAccessTime"></param>
        public static void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.SetLastAccessTime(path, lastAccessTime);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastAccessTimeUtc"></param>
        public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetLastWriteTime(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.GetLastWriteTime(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetLastWriteTimeUtc(string path)
        {
            return ImplementationFactory.CurrentFactory.StatelessC1File.GetLastWriteTimeUtc(path);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastWriteTime"></param>
        public static void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.SetLastWriteTime(path, lastWriteTime);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastWriteTimeUtc"></param>
        public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            ImplementationFactory.CurrentFactory.StatelessC1File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }



        //public static FileStream Create(string path, int bufferSize, System.IO.FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity)
        //{ 
        //    throw new NotImplementedException(); 
        //}




        //public static void Encrypt(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static void Decrypt(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static System.Security.AccessControl.FileSecurity GetAccessControl(string path)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections)
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public static void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity)
        //{ 
        //    throw new NotImplementedException(); 
        //}
    }




    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1FileStream : Stream, IDisposable
    {
        private ImplementationContainer<C1FileStreamImplementation> _implementation;



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        public C1FileStream(string path, FileMode mode)
            : this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.Read, 4096, FileOptions.None)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        public C1FileStream(string path, FileMode mode, FileAccess access)
            : this(path, mode, access, FileShare.Read, 4096, FileOptions.None)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        public C1FileStream(string path, FileMode mode, FileAccess access, FileShare share)
            : this(path, mode, access, share, 4096, FileOptions.None)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <param name="bufferSize"></param>
        public C1FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
            : this(path, mode, access, share, bufferSize, FileOptions.None)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <param name="bufferSize"></param>
        /// <param name="options"></param>
        public C1FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            _implementation = new ImplementationContainer<C1FileStreamImplementation>(() => ImplementationFactory.CurrentFactory.CreateC1FileStream(path, mode, access, share, bufferSize, options));
            _implementation.CreateImplementation();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public string Name
        {
            get
            {
                return _implementation.Implementation.Name;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override long Length
        {
            get
            {
                return _implementation.Implementation.Length;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void SetLength(long value)
        {
            _implementation.Implementation.SetLength(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override long Position
        {
            get
            {
                return _implementation.Implementation.Position;
            }
            set
            {
                _implementation.Implementation.Position = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public override int Read([In, Out] byte[] array, int offset, int count)
        {
            return _implementation.Implementation.Read(array, offset, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public override int ReadByte()
        {
            return _implementation.Implementation.ReadByte();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        public override void Write(byte[] array, int offset, int count)
        {
            _implementation.Implementation.Write(array, offset, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteByte(byte value)
        {
            _implementation.Implementation.WriteByte(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        public override long Seek(long offset, SeekOrigin origin)
        {
            return _implementation.Implementation.Seek(offset, origin);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override bool CanRead
        {
            get
            {
                return _implementation.Implementation.CanRead;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override bool CanSeek
        {
            get
            {
                return _implementation.Implementation.CanSeek;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override bool CanWrite
        {
            get
            {
                return _implementation.Implementation.CanWrite;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void Flush()
        {
            _implementation.Implementation.Flush();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="flushToDisk"></param>
        public virtual void Flush(bool flushToDisk)
        {
            _implementation.Implementation.Flush(flushToDisk);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void Close()
        {
            _implementation.Implementation.Close();
        }
        


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        ~C1FileStream()
        {
            Dispose(false);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _implementation.DisposeImplementation();
            }
        }



        //public virtual bool IsAsync 
        //{ 
        //    get 
        //    { 
        //        throw new NotImplementedException(); 
        //    } 
        //}



        ////[Obsolete("This property has been deprecated.  Please use FileStream's SafeFileHandle property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        //public virtual IntPtr Handle 
        //{ 
        //    get 
        //    { 
        //        throw new NotImplementedException(); 
        //    } 
        //}



        //public FileSecurity GetAccessControl() 
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public void SetAccessControl(FileSecurity fileSecurity) 
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void Lock(long position, long length) 
        //{ 
        //    throw new NotImplementedException(); 
        //}



        //public virtual void Unlock(long position, long length) 
        //{ 
        //    throw new NotImplementedException(); 
        //}
    }





    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1FileSystemWatcher : ImplementationContainer<C1FileSystemWatcherImplementation>
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public C1FileSystemWatcher(string path)
            : this(path, null)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filter"></param>
        public C1FileSystemWatcher(string path, string filter)
            : base(() => ImplementationFactory.CurrentFactory.CreateC1FileSystemWatcher(path, filter))
        {            
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public bool EnableRaisingEvents
        {
            get
            {
                return this.Implementation.EnableRaisingEvents;
            }
            set
            {
                this.Implementation.EnableRaisingEvents = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public string Path
        {
            get
            {
                return this.Implementation.Path;
            }
            set
            {
                this.Implementation.Path = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public string Filter
        {
            get
            {
                return this.Implementation.Filter;
            }
            set
            {
                this.Implementation.Filter = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public bool IncludeSubdirectories
        {
            get
            {
                return this.Implementation.IncludeSubdirectories;
            }
            set
            {
                this.Implementation.IncludeSubdirectories = value;
            }
        }
        


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public event FileSystemEventHandler Created
        {
            add
            {
                this.Implementation.Created += value;
            }
            remove
            {
                this.Implementation.Created -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public event FileSystemEventHandler Changed
        {
            add
            {
                this.Implementation.Changed += value;
            }
            remove
            {
                this.Implementation.Changed -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public event RenamedEventHandler Renamed
        {
            add
            {
                this.Implementation.Renamed += value;
            }
            remove
            {
                this.Implementation.Renamed -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public event FileSystemEventHandler Deleted
        {
            add
            {
                this.Implementation.Deleted += value;
            }
            remove
            {
                this.Implementation.Deleted -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public event ErrorEventHandler Error
        {
            add
            {
                this.Implementation.Error += value;
            }
            remove
            {
                this.Implementation.Error -= value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public NotifyFilters NotifyFilter
        {
            get
            {
                return this.Implementation.NotifyFilter;
            }
            set
            {
                this.Implementation.NotifyFilter = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public void BeginInit()
        {
            this.Implementation.BeginInit();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public void EndInit()
        {
            this.Implementation.EndInit();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="changeType"></param>
        /// <returns></returns>
        public C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
        {
            return this.Implementation.WaitForChanged(changeType);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="changeType"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
        {
            return this.Implementation.WaitForChanged(changeType, timeout);
        }
    }




    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct C1WaitForChangedResult
    {
        public string Name { get; set; }
        public string OldName { get; set; }
        public WatcherChangeTypes ChangeType { get; set; }        
        public bool TimedOut { get; set; }
    }




    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1StreamReader : TextReader, IDisposable
    {
        private ImplementationContainer<C1StreamReaderImplementation> _implementation;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public C1StreamReader(string path)
            : this(path, Encoding.UTF8, true, 1024)
        {
        }

        
        
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        public C1StreamReader(string path, bool detectEncodingFromByteOrderMarks)
            : this(path, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        public C1StreamReader(string path, Encoding encoding)
            : this(path, encoding, true, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        public C1StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
            : this(path, encoding, detectEncodingFromByteOrderMarks, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        /// <param name="bufferSize"></param>
        public C1StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            _implementation = new ImplementationContainer<C1StreamReaderImplementation>(() => ImplementationFactory.CurrentFactory.CreateC1StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize));
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        public C1StreamReader(Stream stream)
            : this(stream, Encoding.UTF8, true, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        public C1StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
            : this(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024)
        { 
        }        



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        public C1StreamReader(Stream stream, Encoding encoding)
            : this(stream, encoding, true, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        public C1StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
            : this(stream, encoding, detectEncodingFromByteOrderMarks, 1024)
        { 
        }

      
        
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <param name="detectEncodingFromByteOrderMarks"></param>
        /// <param name="bufferSize"></param>
        public C1StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            _implementation = new ImplementationContainer<C1StreamReaderImplementation>(() => ImplementationFactory.CurrentFactory.CreateC1StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize));
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public override int Read()
        {
            return _implementation.Implementation.Read();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public override int Read([In, Out] char[] buffer, int index, int count)
        {
            return _implementation.Implementation.Read(buffer, index, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public override string ReadLine()
        {
            return _implementation.Implementation.ReadLine();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public override string ReadToEnd()
        {
            return _implementation.Implementation.ReadToEnd();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public override int ReadBlock(char[] buffer, int index, int count)
        {
            return _implementation.Implementation.ReadBlock(buffer, index, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        public override int Peek()
        {
            return _implementation.Implementation.Peek();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public bool EndOfStream
        {
            get
            {
                return _implementation.Implementation.EndOfStream;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void Close()
        {
            _implementation.Implementation.Close();
        }


        
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual Stream BaseStream 
        { 
            get
            {
                return _implementation.Implementation.BaseStream;
            } 
        }
        

        
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual Encoding CurrentEncoding 
        { 
            get
            {
                return _implementation.Implementation.CurrentEncoding;
            } 
        }
        


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        ~C1StreamReader()
        {
            Dispose(false);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _implementation.DisposeImplementation();
            }
        }


        
        //public void DiscardBufferedData()
        //{ 
        //    throw new NotImplementedException(); 
        //}
    }





    
    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public class C1StreamWriter : TextWriter, IDisposable
    {
        private ImplementationContainer<C1StreamWriterImplementation> _implementation;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        public C1StreamWriter(string path)
            : this(path, false, Encoding.UTF8, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="append"></param>
        public C1StreamWriter(string path, bool append)
            : this(path, append, Encoding.UTF8, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="append"></param>
        /// <param name="encoding"></param>
        public C1StreamWriter(string path, bool append, Encoding encoding)
            : this(path, append, encoding, 1024)
        {
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="append"></param>
        /// <param name="encoding"></param>
        /// <param name="bufferSize"></param>
        public C1StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
        {
            _implementation = new ImplementationContainer<C1StreamWriterImplementation>(() => ImplementationFactory.CurrentFactory.CreateC1StreamWriter(path, append, encoding, bufferSize));
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        public C1StreamWriter(Stream stream)
            : this(stream, Encoding.UTF8, 1024)
        {            
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        public C1StreamWriter(Stream stream, Encoding encoding)
            : this(stream, encoding, 1024)
        {
        }

        
        
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <param name="bufferSize"></param>
        public C1StreamWriter(Stream stream, Encoding encoding, int bufferSize)
        {
            _implementation = new ImplementationContainer<C1StreamWriterImplementation>(() => ImplementationFactory.CurrentFactory.CreateC1StreamWriter(stream, encoding, bufferSize));
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(string value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        public override void Write(string format, object arg0)
        {
            _implementation.Implementation.Write(format, arg0);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        public override void Write(string format, object arg0, object arg1)
        {
            _implementation.Implementation.Write(format, arg0, arg1);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        public override void Write(string format, object arg0, object arg1, object arg2)
        {
            _implementation.Implementation.Write(format, arg0, arg1, arg2);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg"></param>
        public override void Write(string format, params object[] arg)
        {
            _implementation.Implementation.Write(format, arg);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(char value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        public override void Write(char[] buffer)
        {
            _implementation.Implementation.Write(buffer);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public override void Write(char[] buffer, int index, int count)
        {
            _implementation.Implementation.Write(buffer, index, count);
        }


        
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(bool value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(int value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(uint value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(long value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(ulong value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(float value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(double value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(decimal value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void Write(object value)
        {
            _implementation.Implementation.Write(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void WriteLine()
        {
            _implementation.Implementation.WriteLine();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(string value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        public override void WriteLine(string format, object arg0)
        {
            _implementation.Implementation.WriteLine(format, arg0);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        public override void WriteLine(string format, object arg0, object arg1)
        {
            _implementation.Implementation.WriteLine(format, arg0, arg1);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        public override void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            _implementation.Implementation.WriteLine(format, arg0, arg1, arg2);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg"></param>
        public override void WriteLine(string format, params object[] arg)
        {
            _implementation.Implementation.WriteLine(format, arg);
        }

        

        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(char value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        public override void WriteLine(char[] buffer)
        {
            _implementation.Implementation.WriteLine(buffer);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public override void WriteLine(char[] buffer, int index, int count)
        {
            _implementation.Implementation.WriteLine(buffer, index, count);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(bool value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(int value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(uint value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(long value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(ulong value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(float value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(double value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(decimal value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(object value)
        {
            _implementation.Implementation.WriteLine(value);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override string NewLine
        {
            get
            {
                return _implementation.Implementation.NewLine;
            }
            set
            {
                _implementation.Implementation.NewLine = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override IFormatProvider FormatProvider
        {
            get
            {
                return _implementation.Implementation.FormatProvider;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void Flush()
        {
            _implementation.Implementation.Flush();
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual bool AutoFlush
        {
            get
            {
                return _implementation.Implementation.AutoFlush;
            }
            set
            {
                _implementation.Implementation.AutoFlush = value;
            }
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override void Close()
        {
            _implementation.Implementation.Close();
        }


        
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public virtual Stream BaseStream 
        { 
            get
            {
                return _implementation.Implementation.BaseStream;
            } 
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        public override Encoding Encoding
        {
            get
            {
                return _implementation.Implementation.Encoding;
            }
        }



        ~C1StreamWriter()
        {
            Dispose(false);
        }



        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _implementation.DisposeImplementation();
            }
        }
    }
}



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Composite.Plugins.IO.IOProviders.LocalIOPorivder
{
    public class LocalC1Directory : IC1Directory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public DirectoryInfo CreateDirectory(string path)
        {
            return System.IO.Directory.CreateDirectory(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public void Delete(string path)
        {
            System.IO.Directory.Delete(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public void Delete(string path, bool recursive)
        {
            System.IO.Directory.Delete(path, recursive);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public void Move(string sourceDirName, string destDirName)
        {
            System.IO.Directory.Move(sourceDirName, destDirName);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public bool Exists(string path)
        {
            return System.IO.Directory.Exists(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string GetCurrentDirectory()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public void SetCurrentDirectory(string path)
        {
            System.IO.Directory.SetCurrentDirectory(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public DirectoryInfo GetParent(string path)
        {
            return System.IO.Directory.GetParent(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string GetDirectoryRoot(string path)
        {
            return System.IO.Directory.GetDirectoryRoot(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string[] GetDirectories(string path)
        {
            return System.IO.Directory.GetDirectories(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string[] GetDirectories(string path, string searchPattern)
        {
            return System.IO.Directory.GetDirectories(path, searchPattern);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetDirectories(path, searchPattern, searchOption);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string[] GetFiles(string path)
        {
            return System.IO.Directory.GetFiles(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string[] GetFiles(string path, string searchPattern)
        {
            return System.IO.Directory.GetFiles(path, searchPattern);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFiles(path, searchPattern, searchOption);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public DateTime GetCreationTime(string path)
        {
            return System.IO.Directory.GetCreationTime(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseDirecotryClass:DoNotUseDirecotryClass")]
        public DateTime GetCreationTimeUtc(string path)
        {
            return System.IO.Directory.GetCreationTimeUtc(path);
        }
    }



    public class LocalC1File : IC1File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public bool Exists(string path)
        {
            return File.Exists(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void Copy(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void Move(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void Delete(string path)
        {
            File.Delete(path);
        }



        public C1FileStream Create(string path)
        {
            return new C1FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
        }



        public C1FileStream Create(string path, int bufferSize)
        {
            return new C1FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize);
        }



        public C1FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return new C1FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, options);
        }



        public C1StreamWriter CreateText(string path)
        {
            return new C1StreamWriter(path, false);
        }



        public C1StreamWriter AppendText(string path)
        {
            return new C1StreamWriter(path, true);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void AppendAllLines(string path, IEnumerable<string> contents)
        {
            File.AppendAllLines(path, contents);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            File.AppendAllLines(path, contents, encoding);
        }



        public C1FileStream Open(string path, FileMode mode)
        {
            return new C1FileStream(path, mode);
        }



        public C1FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return new C1FileStream(path, mode, access);
        }



        public C1FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return new C1FileStream(path, mode, access, share);
        }



        public C1FileStream OpenRead(string path)
        {
            return new C1FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        }



        public C1StreamReader OpenText(string path)
        {
            return new C1StreamReader(path);
        }



        public C1FileStream OpenWrite(string path)
        {
            return new C1FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public string[] ReadAllLines(string path, Encoding encoding)
        {
            return File.ReadAllLines(path, encoding);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public string ReadAllText(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public IEnumerable<string> ReadLines(string path)
        {
            return File.ReadLines(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return File.ReadLines(path, encoding);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void WriteAllBytes(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void WriteAllLines(string path, IEnumerable<string> contents)
        {
            File.WriteAllLines(path, contents);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void WriteAllLines(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void WriteAllText(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public FileAttributes GetAttributes(string path)
        {
            return File.GetAttributes(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void SetAttributes(string path, FileAttributes fileAttributes)
        {
            File.SetAttributes(path, fileAttributes);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public DateTime GetCreationTime(string path)
        {
            return File.GetCreationTime(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public DateTime GetCreationTimeUtc(string path)
        {
            return File.GetCreationTimeUtc(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void SetCreationTime(string path, DateTime creationTime)
        {
            File.SetCreationTime(path, creationTime);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            File.SetCreationTimeUtc(path, creationTimeUtc);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public DateTime GetLastAccessTime(string path)
        {
            return File.GetLastAccessTime(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public DateTime GetLastAccessTimeUtc(string path)
        {
            return File.GetLastAccessTimeUtc(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            File.SetLastAccessTime(path, lastAccessTime);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public DateTime GetLastWriteTime(string path)
        {
            return File.GetLastWriteTime(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public DateTime GetLastWriteTimeUtc(string path)
        {
            return File.GetLastWriteTimeUtc(path);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            File.SetLastWriteTime(path, lastWriteTime);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass")]
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }
    }



    public class LocalC1FileStream : IC1FileStream
    {
        private FileStream _fileStream;



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public LocalC1FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            _fileStream = new System.IO.FileStream(path, mode, access, share, bufferSize, options);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public string Name
        {
            get
            {
                return _fileStream.Name;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public long Length
        {
            get
            {
                return _fileStream.Length;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void SetLength(long value)
        {
            _fileStream.SetLength(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public long Position
        {
            get
            {
                return _fileStream.Position;
            }
            set
            {
                _fileStream.Position = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public int Read(byte[] array, int offset, int count)
        {
            return _fileStream.Read(array, offset, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public int ReadByte()
        {
            return _fileStream.ReadByte();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Write(byte[] array, int offset, int count)
        {
            _fileStream.Write(array, offset, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void WriteByte(byte value)
        {
            _fileStream.WriteByte(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public long Seek(long offset, SeekOrigin origin)
        {
            return _fileStream.Seek(offset, origin);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public bool CanRead
        {
            get
            {
                return _fileStream.CanRead;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public bool CanSeek
        {
            get
            {
                return _fileStream.CanSeek;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public bool CanWrite
        {
            get
            {
                return _fileStream.CanWrite;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Flush()
        {
            _fileStream.Flush();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Flush(bool flushToDisk)
        {
            _fileStream.Flush(flushToDisk);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Close()
        {
            _fileStream.Close();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Dispose()
        {
            _fileStream.Dispose();
        }
    }



    public class LocalC1FileSystemWatcher : IC1FileSystemWatcher
    {
        private FileSystemWatcher _fileSystemWatcher;


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public LocalC1FileSystemWatcher(string path, string filter)
        {
            _fileSystemWatcher = new FileSystemWatcher(path, filter);
        }




        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public bool EnableRaisingEvents 
        {
            get
            {
                return _fileSystemWatcher.EnableRaisingEvents;
            }
            set
            {
                _fileSystemWatcher.EnableRaisingEvents = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public string Path 
        {
            get
            {
                return _fileSystemWatcher.Path;
            }
            set
            {
                _fileSystemWatcher.Path = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public string Filter 
        {
            get
            {
                return _fileSystemWatcher.Filter;
            }
            set
            {
                _fileSystemWatcher.Filter = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public bool IncludeSubdirectories 
        {
            get
            {
                return _fileSystemWatcher.IncludeSubdirectories;
            }
            set
            {
                _fileSystemWatcher.IncludeSubdirectories = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public event FileSystemEventHandler Created
        {
            add
            {
                _fileSystemWatcher.Created += value;
            }
            remove
            {
                _fileSystemWatcher.Created -= value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public event FileSystemEventHandler Changed
        {
            add
            {
                _fileSystemWatcher.Changed += value;
            }
            remove
            {
                _fileSystemWatcher.Changed -= value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public event RenamedEventHandler Renamed
        {
            add
            {
                _fileSystemWatcher.Renamed += value;
            }
            remove
            {
                _fileSystemWatcher.Renamed -= value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public event FileSystemEventHandler Deleted
        {
            add
            {
                _fileSystemWatcher.Deleted += value;
            }
            remove
            {
                _fileSystemWatcher.Deleted -= value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public event ErrorEventHandler Error
        {
            add
            {
                _fileSystemWatcher.Error += value;
            }
            remove
            {
                _fileSystemWatcher.Error -= value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public NotifyFilters NotifyFilter 
        {
            get
            {
                return _fileSystemWatcher.NotifyFilter;
            }
            set
            {
                _fileSystemWatcher.NotifyFilter = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public void BeginInit()
        {
            _fileSystemWatcher.BeginInit();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        public void EndInit()
        {
            _fileSystemWatcher.EndInit();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseWaitForChangedResultClass:DoNotUseWaitForChangedResultClass")]
        public C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
        {
            WaitForChangedResult result = _fileSystemWatcher.WaitForChanged(changeType);

            return new C1WaitForChangedResult
            {
                Name = result.Name,
                OldName = result.OldName, 
                ChangeType = result.ChangeType,
                TimedOut = result.TimedOut
            };
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileSystemWatcherClass:DoNotUseFileSystemWatcherClass")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseWaitForChangedResultClass:DoNotUseWaitForChangedResultClass")]
        public C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
        {
            WaitForChangedResult result = _fileSystemWatcher.WaitForChanged(changeType, timeout);

            return new C1WaitForChangedResult
            {
                Name = result.Name,
                OldName = result.OldName,
                ChangeType = result.ChangeType,
                
                TimedOut = result.TimedOut
            };
        }
    }



    public class LocalC1StreamReader : IC1StreamReader
    {
        private StreamReader _streamReader;


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public LocalC1StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            _streamReader = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public LocalC1StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            _streamReader = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public int Read()
        {
            return _streamReader.Read();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public int Read(char[] buffer, int index, int count)
        {
            return _streamReader.Read(buffer, index, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public string ReadLine()
        {
            return _streamReader.ReadLine();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public string ReadToEnd()
        {
            return _streamReader.ReadToEnd();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public int ReadBlock(char[] buffer, int index, int count)
        {
            return _streamReader.ReadBlock(buffer, index, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public int Peek()
        {
            return _streamReader.Peek();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public bool EndOfStream
        {
            get 
            {
                return _streamReader.EndOfStream;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public void Close()
        {
            _streamReader.Close();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public Stream BaseStream
        {
            get 
            {
                return _streamReader.BaseStream;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public Encoding CurrentEncoding
        {
            get 
            {
                return _streamReader.CurrentEncoding;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamReaderClass:DotNotUseStreamReaderClass")]
        public void Dispose()
        {
            _streamReader.Dispose();
        }        
    }



    public class LocalC1StreamWriter : IC1StreamWriter
    {
        private StreamWriter _streamWriter;


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public LocalC1StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
        {
            _streamWriter = new StreamWriter(path, append, encoding, bufferSize);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public LocalC1StreamWriter(Stream stream, Encoding encoding, int bufferSize)
        {
            _streamWriter = new StreamWriter(stream, encoding, bufferSize);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(string value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(string format, object arg0)
        {
            _streamWriter.Write(format, arg0);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(string format, object arg0, object arg1)
        {
            _streamWriter.Write(format, arg0, arg1);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(string format, object arg0, object arg1, object arg2)
        {
            _streamWriter.Write(format, arg0, arg1, arg2);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(string format, params object[] arg)
        {
            _streamWriter.Write(format, arg);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(char value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(char[] buffer)
        {
            _streamWriter.Write(buffer);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(char[] buffer, int index, int count)
        {
            _streamWriter.Write(buffer, index, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(bool value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(int value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(uint value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(long value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(ulong value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(float value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(double value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(decimal value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Write(object value)
        {
            _streamWriter.Write(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine()
        {
            _streamWriter.WriteLine();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(string value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(string format, object arg0)
        {
            _streamWriter.WriteLine(format, arg0);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(string format, object arg0, object arg1)
        {
            _streamWriter.WriteLine(format, arg0, arg1);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            _streamWriter.WriteLine(format, arg0, arg1, arg2);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(string format, params object[] arg)
        {
            _streamWriter.WriteLine(format, arg);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(char value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(char[] buffer)
        {
            _streamWriter.WriteLine(buffer);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(char[] buffer, int index, int count)
        {
            _streamWriter.WriteLine(buffer, index, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(bool value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(int value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(uint value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(long value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(ulong value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(float value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(double value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(decimal value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void WriteLine(object value)
        {
            _streamWriter.WriteLine(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public string NewLine
        {
            get
            {
                return _streamWriter.NewLine;
            }
            set
            {
                _streamWriter.NewLine = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public IFormatProvider FormatProvider
        {
            get 
            {
                return _streamWriter.FormatProvider;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public bool AutoFlush
        {
            get
            {
                return _streamWriter.AutoFlush;
            }
            set
            {
                _streamWriter.AutoFlush = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Flush()
        {
            _streamWriter.Flush();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Close()
        {
            _streamWriter.Close();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public Stream BaseStream
        {
            get 
            {
                return _streamWriter.BaseStream;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public Encoding Encoding
        {
            get 
            {
                return _streamWriter.Encoding;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DotNotUseStreamWriterClass:DotNotUseStreamWriterClass")]
        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





namespace Composite.Core.IO.Plugins.IOProvider
{
    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public interface IC1Directory
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DirectoryInfo CreateDirectory(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        void Delete(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="recursive"></param>
        void Delete(string path, bool recursive);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        void Move(string sourceDirName, string destDirName);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        bool Exists(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        string GetCurrentDirectory();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        void SetCurrentDirectory(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DirectoryInfo GetParent(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string GetDirectoryRoot(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string[] GetDirectories(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        string[] GetDirectories(string path, string searchPattern);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string[] GetFiles(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        string[] GetFiles(string path, string searchPattern);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="searchOption"></param>
        /// <returns></returns>
        string[] GetFiles(string path, string searchPattern, SearchOption searchOption);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetCreationTime(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetCreationTimeUtc(string path);
    }



    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public interface IC1File
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        bool Exists(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        void Copy(string sourceFileName, string destFileName);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        /// <param name="overwrite"></param>
        void Copy(string sourceFileName, string destFileName, bool overwrite);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destFileName"></param>
        void Move(string sourceFileName, string destFileName);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        /// <param name="ignoreMetadataErrors"></param>
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        void Delete(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        C1FileStream Create(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        C1FileStream Create(string path, int bufferSize);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bufferSize"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        C1FileStream Create(string path, int bufferSize, FileOptions options);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        C1StreamWriter CreateText(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        C1StreamWriter AppendText(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        void AppendAllText(string path, string contents);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        void AppendAllText(string path, string contents, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        void AppendAllLines(string path, IEnumerable<string> contents);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        C1FileStream Open(string path, FileMode mode);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <returns></returns>
        C1FileStream Open(string path, FileMode mode, FileAccess access);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <returns></returns>
        C1FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        C1FileStream OpenRead(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        C1StreamReader OpenText(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        C1FileStream OpenWrite(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        byte[] ReadAllBytes(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string[] ReadAllLines(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        string[] ReadAllLines(string path, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string ReadAllText(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        string ReadAllText(string path, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        IEnumerable<string> ReadLines(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        IEnumerable<string> ReadLines(string path, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bytes"></param>
        void WriteAllBytes(string path, byte[] bytes);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        void WriteAllLines(string path, IEnumerable<string> contents);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        void WriteAllLines(string path, string[] contents);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        void WriteAllLines(string path, string[] contents, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        void WriteAllText(string path, string contents);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        void WriteAllText(string path, string contents, Encoding encoding);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        FileAttributes GetAttributes(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileAttributes"></param>
        void SetAttributes(string path, FileAttributes fileAttributes);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetCreationTime(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetCreationTimeUtc(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTime"></param>
        void SetCreationTime(string path, DateTime creationTime);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTimeUtc"></param>
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetLastAccessTime(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetLastAccessTimeUtc(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastAccessTime"></param>
        void SetLastAccessTime(string path, DateTime lastAccessTime);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastAccessTimeUtc"></param>
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetLastWriteTime(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetLastWriteTimeUtc(string path);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastWriteTime"></param>
        void SetLastWriteTime(string path, DateTime lastWriteTime);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lastWriteTimeUtc"></param>
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
    }



    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public interface IC1FileStream : IDisposable
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        string Name { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        long Length { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void SetLength(long value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        long Position { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        int Read(byte[] array, int offset, int count);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        int ReadByte();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        void Write(byte[] array, int offset, int count);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteByte(byte value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        long Seek(long offset, System.IO.SeekOrigin origin);
        

        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        bool CanRead { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        bool CanSeek { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        bool CanWrite { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void Flush();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="flushToDisk"></param>
        void Flush(bool flushToDisk);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void Close();
    }



    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public interface IC1FileSystemWatcher
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        bool EnableRaisingEvents { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        string Path { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        string Filter { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        bool IncludeSubdirectories { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        event FileSystemEventHandler Created;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        event FileSystemEventHandler Changed;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        event RenamedEventHandler Renamed;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        event FileSystemEventHandler Deleted;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        event ErrorEventHandler Error;


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>        
        NotifyFilters NotifyFilter { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void BeginInit();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void EndInit();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="changeType"></param>
        /// <returns></returns>
        C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="changeType"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        C1WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout);
    }




    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public interface IC1StreamReader : IDisposable
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        int Read();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        int Read(char[] buffer, int index, int count);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        string ReadLine();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        string ReadToEnd();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        int ReadBlock(char[] buffer, int index, int count);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <returns></returns>
        int Peek();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        bool EndOfStream { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void Close();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        Stream BaseStream { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        Encoding CurrentEncoding { get; }
    }




    /// <summary>
    /// IOLayer - documentation pending
    /// </summary>
    public interface IC1StreamWriter : IDisposable
    {
        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(string value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg"></param>
        void Write(string format, params object[] arg);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        void Write(string format, object arg0);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        void Write(string format, object arg0, object arg1);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        void Write(string format, object arg0, object arg1, object arg2);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(char value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        void Write(char[] buffer);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        void Write(char[] buffer, int index, int count);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(bool value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(int value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(uint value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(long value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(ulong value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(float value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(double value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(decimal value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void Write(object value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void WriteLine();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(string value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        void WriteLine(string format, object arg0);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        void WriteLine(string format, object arg0, object arg1);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        void WriteLine(string format, object arg0, object arg1, object arg2);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg"></param>
        void WriteLine(string format, params object[] arg);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(char value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        void WriteLine(char[] buffer);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        void WriteLine(char[] buffer, int index, int count);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(bool value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(int value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(uint value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(long value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(ulong value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(float value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(double value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(decimal value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        /// <param name="value"></param>
        void WriteLine(object value);


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        string NewLine { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        IFormatProvider FormatProvider { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        bool AutoFlush { get; set; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void Flush();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        void Close();


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        Stream BaseStream { get; }


        /// <summary>
        /// IOLayer - documentation pending
        /// </summary>
        Encoding Encoding { get; }
    }





    internal interface IIOProvider
    {
        IC1Directory C1Directory { get; }
        IC1File C1File { get; }


        IC1FileStream CreateFileStream(string path, FileMode mode, FileAccess access, FileShare share);
        IC1FileSystemWatcher CreateFileSystemWatcher(string path, string filter);
        IC1StreamReader CreateStreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize);
        IC1StreamReader CreateStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize);
        IC1StreamWriter CreateStreamWriter(string path, bool append, Encoding encoding, int bufferSize);
        IC1StreamWriter CreateStreamWriter(Stream stream, Encoding encoding, int bufferSize);

        // --- Classes/Structs ---
        // static Directory
        // static File
        // FileStream
        // FileSystemWatcher
        // StreamReader
        // StreamWriter
        // WaitForChangedResult
        // Configuration
        // FileConfigurationSource
        // FileConfigurationSourceImplementation??


        // --- Methods ---
        // XDocumentUtils.Load
        // XDocumentUtils.Save
        // XElementUtils.Load
        // XElementUtils.SaveToPath
        // XmlReaderUtils.Create
        // XmlSchemaSetUtils.AddFromPath
        // XmlWriterUtils.Create
        // XslCompiledTransformUtils.LoadFromPath 
    }

}



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



namespace Composite.Core.IO
{
    internal static class IOFacade
    {
        public static IC1Directory C1Directory
        {
            get
            {
                return new LocalC1Directory();
            }
        }



        public static IC1File C1File
        {
            get
            {
                return new LocalC1File();
            }
        }



        public static IC1FileStream CreateFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            return new LocalC1FileStream(path, mode, access, share, bufferSize, options);
        }



        public static IC1FileSystemWatcher CreateFileSystemWatcher(string path, string filter)
        {
            return new LocalC1FileSystemWatcher(path, filter);
        }



        public static IC1StreamReader CreateC1StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            return new LocalC1StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }



        public static IC1StreamReader CreateC1StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            return new LocalC1StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }



        public static IC1StreamWriter CreateStreamWriter(string path, bool append, Encoding encoding, int bufferSize)
        {
            return new LocalC1StreamWriter(path, append, encoding, bufferSize);
        }



        public static IC1StreamWriter CreateStreamWriter(Stream stream, Encoding encoding, int bufferSize)
        {
            return new LocalC1StreamWriter(stream, encoding, bufferSize);
        }
    }
}


