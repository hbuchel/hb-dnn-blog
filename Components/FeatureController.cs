/*
' Copyright (c) 2016 Heather Buchel
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace HB.Modules.Blog.Components
{

  /// -----------------------------------------------------------------------------
  /// <summary>
  /// The Controller class for Blog
  /// 
  /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
  /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
  /// 
  /// The IPortable interface is used to import/export content from a DNN module
  /// 
  /// The ISearchable interface is used by DNN to index the content of a module
  /// 
  /// The IUpgradeable interface allows module developers to execute code during the upgrade 
  /// process for a module.
  /// 
  /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
  /// </summary>
  /// -----------------------------------------------------------------------------

  //uncomment the interfaces to add the support.
  public class FeatureController //: IPortable, ISearchable, IUpgradeable
  {


    #region Optional Interfaces

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// ExportModule implements the IPortable ExportModule Interface
    /// </summary>
    /// <param name="ModuleID">The Id of the module to be exported</param>
    /// -----------------------------------------------------------------------------
    //public string ExportModule(int ModuleID)
    //{
    //string strXML = "";

    //List<BlogInfo> colBlogs = GetBlogs(ModuleID);
    //if (colBlogs.Count != 0)
    //{
    //    strXML += "<Blogs>";

    //    foreach (BlogInfo objBlog in colBlogs)
    //    {
    //        strXML += "<Blog>";
    //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objBlog.Content) + "</content>";
    //        strXML += "</Blog>";
    //    }
    //    strXML += "</Blogs>";
    //}

    //return strXML;

    //	throw new System.NotImplementedException("The method or operation is not implemented.");
    //}

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// ImportModule implements the IPortable ImportModule Interface
    /// </summary>
    /// <param name="ModuleID">The Id of the module to be imported</param>
    /// <param name="Content">The content to be imported</param>
    /// <param name="Version">The version of the module to be imported</param>
    /// <param name="UserId">The Id of the user performing the import</param>
    /// -----------------------------------------------------------------------------
    //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
    //{
    //XmlNode xmlBlogs = DotNetNuke.Common.Globals.GetContent(Content, "Blogs");
    //foreach (XmlNode xmlBlog in xmlBlogs.SelectNodes("Blog"))
    //{
    //    BlogInfo objBlog = new BlogInfo();
    //    objBlog.ModuleId = ModuleID;
    //    objBlog.Content = xmlBlog.SelectSingleNode("content").InnerText;
    //    objBlog.CreatedByUser = UserID;
    //    AddBlog(objBlog);
    //}

    //	throw new System.NotImplementedException("The method or operation is not implemented.");
    //}

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// GetSearchItems implements the ISearchable Interface
    /// </summary>
    /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
    /// -----------------------------------------------------------------------------
    //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
    //{
    //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

    //List<BlogInfo> colBlogs = GetBlogs(ModInfo.ModuleID);

    //foreach (BlogInfo objBlog in colBlogs)
    //{
    //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objBlog.Content, objBlog.CreatedByUser, objBlog.CreatedDate, ModInfo.ModuleID, objBlog.ItemId.ToString(), objBlog.Content, "ItemId=" + objBlog.ItemId.ToString());
    //    SearchItemCollection.Add(SearchItem);
    //}

    //return SearchItemCollection;

    //	throw new System.NotImplementedException("The method or operation is not implemented.");
    //}

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// UpgradeModule implements the IUpgradeable Interface
    /// </summary>
    /// <param name="Version">The current version of the module</param>
    /// -----------------------------------------------------------------------------
    //public string UpgradeModule(string Version)
    //{
    //	throw new System.NotImplementedException("The method or operation is not implemented.");
    //}

    #endregion

  }

}
