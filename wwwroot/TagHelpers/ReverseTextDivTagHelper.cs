using System;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace BookCollection.TagHelpers
{

    //You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project.

    //[HtmlTargetElement("tag-name")] //Not using this.  
    //If you comment out the attribute, the default behavior is to automatically assume it will 
    //be a new tag used in the views. When used, the name of the new tag will have the “TagHelper” suffix dropped. 
    //Also, it will be converted to lower Kebab casing.

    public class ReverseTextDivTagHelper : TagHelper{

   private string _divData = string.Empty;
    public string DivData
    {
      get
      {
        char[] reversedData = _divData.ToCharArray();
        Array.Reverse(reversedData);
        String sDataReversed = new String(reversedData);
        return AllCaps ? sDataReversed.ToUpper() : sDataReversed;
      }
      set { _divData = value; }
    }
 
    public bool AllCaps { get; set; }

    //The first parameter, context, gives us access to the control and any contained elements and attributes. 
    //This allows us to programmatically manipulate it by adding, modifying, or removing child elements. 
    //The second parameter, output, is used to write content back into the webpage. 
    public override void Process(
      TagHelperContext context, 
      TagHelperOutput output)
    {
      output.TagName = "div";
      output.Content.SetContent(DivData);
    }


    }
}
