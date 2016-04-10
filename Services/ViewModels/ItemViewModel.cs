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

using HB.Modules.Blog.Components;
using Newtonsoft.Json;

namespace HB.Modules.Blog.Services.ViewModels
{
  [JsonObject(MemberSerialization.OptIn)]
  public class ItemViewModel
  {
    public ItemViewModel(Item t)
    {
      Id = t.ItemId;
      Title = t.ItemTitle;
      Summary = t.ItemSummary;
      Article = t.ItemArticle;
      AssignedUser = t.AssignedUserId;
    }

    public ItemViewModel(Item t, string editUrl)
    {
      Id = t.ItemId;
      Title = t.ItemTitle;
      Summary = t.ItemSummary;
      Article = t.ItemArticle;
      EditUrl = editUrl;
    }


    public ItemViewModel() { }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("summary")]
    public string Summary { get; set; }

    [JsonProperty("article")]
    public string Article { get; set; }

    [JsonProperty("assignedUser")]
    public int AssignedUser { get; set; }

    [JsonProperty("editUrl")]
    public string EditUrl { get; }
  }
}