#pragma checksum "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be3c62c461cfda07d4b62b02382c929e9385d05c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Status), @"mvc.1.0.view", @"/Views/Items/Status.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Status.cshtml", typeof(AspNetCore.Views_Items_Status))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3c62c461cfda07d4b62b02382c929e9385d05c", @"/Views/Items/Status.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35637e76b85c4316bc78e95a1bdf0b6192c624e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Status : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FridgePZ.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
  
    ViewData["Title"] = "Status";

#line default
#line hidden
            BeginContext(86, 87, true);
            WriteLiteral("\r\n<h1>Twoje przeterminowane produkty</h1>\r\n\r\n<table class=\"table\">\r\n    \r\n    <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(224, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 16 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
                  
                    fridgepzContext data = new fridgepzContext();
                    var query3 = from itempattern in data.Itempattern
                                 join _item in data.Item on itempattern.ItemPatternId equals item.ItemPatternId
                                 where _item.ItemPatternId == item.ItemPatternId && _item.NotificationId == 1
                                 select itempattern;
                    Itempattern product = query3.Distinct().FirstOrDefault();
                    DateTime date = item.ExpirationDate ?? DateTime.Now;
                    String only_date = date.ToString("dd/MM/yyyy");
                

#line default
#line hidden
            BeginContext(919, 118, true);
            WriteLiteral("\r\n                <td>\r\n                    <div class=\"alert alert-danger\">\r\n                        <strong>Produkt ");
            EndContext();
            BeginContext(1038, 42, false);
#line 29 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
                                   Write(Html.DisplayFor(modelItem => product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 35, true);
            WriteLiteral(": </strong> został przeterminowany ");
            EndContext();
            BeginContext(1116, 9, false);
#line 29 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
                                                                                                                 Write(only_date);

#line default
#line hidden
            EndContext();
            BeginContext(1125, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
        }

#line default
#line hidden
            BeginContext(1210, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 35 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
          
            String email = User.Identity.Name;
            fridgepzContext db = new fridgepzContext();
            var query = from p in db.User where p.Email.Equals(email) select p;
            User cur_user = query.Single();
            fridgepzContext _context = new fridgepzContext();
            var query2 = from itempattern in _context.Itempattern
                         join item in _context.Item on itempattern.ItemPatternId equals item.ItemPatternId
                         join shelf in _context.Shelf on item.ShelfId equals shelf.ShelfId
                         join storage in _context.Storage on shelf.StorageId equals storage.StorageId
                         join privelege in _context.Privilege on storage.StorageId equals privelege.StorageId
                         join user in _context.User on privelege.UserId equals user.UserId
                         where user == cur_user && item.NotificationId == 3
                         select item;
            List<Item> item_not3 = query2.ToList();


            foreach (var not3 in item_not3)
            {


#line default
#line hidden
            BeginContext(2324, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 56 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
                      
                        var query4 = from itempattern in db.Itempattern
                                     join _item in db.Item on itempattern.ItemPatternId equals _item.ItemPatternId
                                     where _item.ItemPatternId == not3.ItemPatternId && _item.NotificationId == 3
                                     select itempattern;
                        Itempattern product = query4.Distinct().FirstOrDefault();
                        DateTime date = not3.ExpirationDate ?? DateTime.Now;
                        DateTime nowdate = DateTime.Now.Date;
                        double diff = (date - nowdate).TotalDays;

                    

#line default
#line hidden
            BeginContext(3048, 126, true);
            WriteLiteral("                    <td>\r\n                        <div class=\"alert alert-info\">\r\n                            <strong>Produkt ");
            EndContext();
            BeginContext(3175, 42, false);
#line 69 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
                                       Write(Html.DisplayFor(modelItem => product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3217, 40, true);
            WriteLiteral(": </strong> zostanie przeterminowany za ");
            EndContext();
            BeginContext(3258, 4, false);
#line 69 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
                                                                                                                          Write(diff);

#line default
#line hidden
            EndContext();
            BeginContext(3262, 90, true);
            WriteLiteral(" dni\r\n                        </div>\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Items\Status.cshtml"
            }

        

#line default
#line hidden
            BeginContext(3380, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FridgePZ.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
