using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace codekata
{
  [TestClass]
  public class UnitTest1
  {
    //SUT
    private FileSystemsDisplayer _fileSystemsDisplayer;

    [TestMethod]
    public void Lists_files_and_folders()
    {
      _fileSystemsDisplayer = new FileSystemsDisplayer(null);
    }
  }

  public class FileSystemsDisplayer
  {
    private readonly ISearchFileSystem _fileSystemSearcher;

    public FileSystemsDisplayer(ISearchFileSystem fileSystemSearcher)
    {
      _fileSystemSearcher = fileSystemSearcher;
    }


  }

  public interface ISearchFileSystem
  {
    List<string> GetFolders();
  }
}
