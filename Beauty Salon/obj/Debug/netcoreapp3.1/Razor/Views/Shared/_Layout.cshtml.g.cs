#pragma checksum "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fecfffdd7c45a2d9affba7409823dd0a2059042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fecfffdd7c45a2d9affba7409823dd0a2059042", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("is-preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a20590424874", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 4 "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("MetatagsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("CssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a20590426371", async() => {
                WriteLiteral("\r\n    <!-- Wrapper -->\r\n    <div id=\"wrapper\">\r\n        ");
#nullable restore
#line 12 "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!-- Main -->
        <section id=""main"" class=""wrapper"">
            <div class=""inner"">
                <h1 class=""major"">Elements</h1>

                <!-- Text -->
                <section>
                    <h2>Text</h2>
                    <p>
                        This is <b>bold</b> and this is <strong>strong</strong>. This is <i>italic</i> and this is <em>emphasized</em>.
                        This is <sup>superscript</sup> text and this is <sub>subscript</sub> text.
                        This is <u>underlined</u> and this is code: <code>for (;;) { ... }</code>. Finally, <a href=""#"">this is a link</a>.
                    </p>
                    <hr />
                    <p>Nunc lacinia ante nunc ac lobortis. Interdum adipiscing gravida odio porttitor sem non mi integer non faucibus ornare mi ut ante amet placerat aliquet. Volutpat eu sed ante lacinia sapien lorem accumsan varius montes viverra nibh in adipiscing blandit tempus accumsan.</p>
                    <");
                WriteLiteral(@"hr />
                    <h2>Heading Level 2</h2>
                    <h3>Heading Level 3</h3>
                    <h4>Heading Level 4</h4>
                    <hr />
                    <h3>Blockquote</h3>
                    <blockquote>Fringilla nisl. Donec accumsan interdum nisi, quis tincidunt felis sagittis eget tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan faucibus. Vestibulum ante ipsum primis in faucibus lorem ipsum dolor sit amet nullam adipiscing eu felis.</blockquote>
                    <h3>Preformatted</h3>
                    <pre><code>i = 0;

while (!deck.isInOrder()) {
    print 'Iteration ' + i;
    deck.shuffle();
    i++;
}

print 'It took ' + i + ' iterations to sort the deck.';</code></pre>
                </section>

                <!-- Lists -->
                <section>
                    <h2>Lists</h2>
                    <div class=""row"">
                        <div");
                WriteLiteral(@" class=""col-6 col-12-medium"">
                            <h3>Unordered</h3>
                            <ul>
                                <li>Dolor pulvinar etiam.</li>
                                <li>Sagittis adipiscing.</li>
                                <li>Felis enim feugiat.</li>
                            </ul>
                            <h3>Alternate</h3>
                            <ul class=""alt"">
                                <li>Dolor pulvinar etiam.</li>
                                <li>Sagittis adipiscing.</li>
                                <li>Felis enim feugiat.</li>
                            </ul>
                        </div>
                        <div class=""col-6 col-12-medium"">
                            <h3>Ordered</h3>
                            <ol>
                                <li>Dolor pulvinar etiam.</li>
                                <li>Etiam vel felis viverra.</li>
                                <li>Felis enim feugiat.</li>
     ");
                WriteLiteral(@"                           <li>Dolor pulvinar etiam.</li>
                                <li>Etiam vel felis lorem.</li>
                                <li>Felis enim et feugiat.</li>
                            </ol>
                            <h3>Icons</h3>
                            <ul class=""icons"">
                                <li><a href=""#"" class=""icon brands fa-twitter""><span class=""label"">Twitter</span></a></li>
                                <li><a href=""#"" class=""icon brands fa-facebook-f""><span class=""label"">Facebook</span></a></li>
                                <li><a href=""#"" class=""icon brands fa-instagram""><span class=""label"">Instagram</span></a></li>
                                <li><a href=""#"" class=""icon brands fa-github""><span class=""label"">Github</span></a></li>
                            </ul>
                        </div>
                    </div>
                    <h2>Actions</h2>
                    <div class=""row"">
                        <div class");
                WriteLiteral(@"=""col-6 col-12-medium"">
                            <ul class=""actions"">
                                <li><a href=""#"" class=""button primary"">Default</a></li>
                                <li><a href=""#"" class=""button"">Default</a></li>
                            </ul>
                            <ul class=""actions small"">
                                <li><a href=""#"" class=""button primary small"">Small</a></li>
                                <li><a href=""#"" class=""button small"">Small</a></li>
                            </ul>
                            <ul class=""actions stacked"">
                                <li><a href=""#"" class=""button primary"">Default</a></li>
                                <li><a href=""#"" class=""button"">Default</a></li>
                            </ul>
                            <ul class=""actions stacked"">
                                <li><a href=""#"" class=""button primary small"">Small</a></li>
                                <li><a href=""#"" class=""button");
                WriteLiteral(@" small"">Small</a></li>
                            </ul>
                        </div>
                        <div class=""col-6 col-12-medium"">
                            <ul class=""actions stacked"">
                                <li><a href=""#"" class=""button primary fit"">Default</a></li>
                                <li><a href=""#"" class=""button fit"">Default</a></li>
                            </ul>
                            <ul class=""actions stacked"">
                                <li><a href=""#"" class=""button primary small fit"">Small</a></li>
                                <li><a href=""#"" class=""button small fit"">Small</a></li>
                            </ul>
                        </div>
                    </div>
                </section>

                <!-- Table -->
                <section>
                    <h2>Table</h2>
                    <h3>Default</h3>
                    <div class=""table-wrapper"">
                        <table>
                   ");
                WriteLiteral(@"         <thead>
                                <tr>
                                    <th>Name</th>
                                    <th>Description</th>
                                    <th>Price</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Item One</td>
                                    <td>Ante turpis integer aliquet porttitor.</td>
                                    <td>29.99</td>
                                </tr>
                                <tr>
                                    <td>Item Two</td>
                                    <td>Vis ac commodo adipiscing arcu aliquet.</td>
                                    <td>19.99</td>
                                </tr>
                                <tr>
                                    <td>Item Three</td>
                                    <td> Morbi faucibus arc");
                WriteLiteral(@"u accumsan lorem.</td>
                                    <td>29.99</td>
                                </tr>
                                <tr>
                                    <td>Item Four</td>
                                    <td>Vitae integer tempus condimentum.</td>
                                    <td>19.99</td>
                                </tr>
                                <tr>
                                    <td>Item Five</td>
                                    <td>Ante turpis integer aliquet porttitor.</td>
                                    <td>29.99</td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td colspan=""2""></td>
                                    <td>100.00</td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>

        ");
                WriteLiteral(@"            <h3>Alternate</h3>
                    <div class=""table-wrapper"">
                        <table class=""alt"">
                            <thead>
                                <tr>
                                    <th>Name</th>
                                    <th>Description</th>
                                    <th>Price</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Item One</td>
                                    <td>Ante turpis integer aliquet porttitor.</td>
                                    <td>29.99</td>
                                </tr>
                                <tr>
                                    <td>Item Two</td>
                                    <td>Vis ac commodo adipiscing arcu aliquet.</td>
                                    <td>19.99</td>
                                </tr>
         ");
                WriteLiteral(@"                       <tr>
                                    <td>Item Three</td>
                                    <td> Morbi faucibus arcu accumsan lorem.</td>
                                    <td>29.99</td>
                                </tr>
                                <tr>
                                    <td>Item Four</td>
                                    <td>Vitae integer tempus condimentum.</td>
                                    <td>19.99</td>
                                </tr>
                                <tr>
                                    <td>Item Five</td>
                                    <td>Ante turpis integer aliquet porttitor.</td>
                                    <td>29.99</td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td colspan=""2""></td>
                                    <td>100.00</td>
    ");
                WriteLiteral(@"                            </tr>
                            </tfoot>
                        </table>
                    </div>
                </section>

                <!-- Buttons -->
                <section>
                    <h3>Buttons</h3>
                    <ul class=""actions"">
                        <li><a href=""#"" class=""button primary"">Primary</a></li>
                        <li><a href=""#"" class=""button"">Default</a></li>
                    </ul>
                    <ul class=""actions"">
                        <li><a href=""#"" class=""button large"">Large</a></li>
                        <li><a href=""#"" class=""button"">Default</a></li>
                        <li><a href=""#"" class=""button small"">Small</a></li>
                    </ul>
                    <ul class=""actions fit"">
                        <li><a href=""#"" class=""button primary fit"">Fit</a></li>
                        <li><a href=""#"" class=""button fit"">Fit</a></li>
                        <li><a href=""#"" c");
                WriteLiteral(@"lass=""button fit"">Fit</a></li>
                    </ul>
                    <ul class=""actions fit small"">
                        <li><a href=""#"" class=""button primary fit small"">Fit + Small</a></li>
                        <li><a href=""#"" class=""button fit small"">Fit + Small</a></li>
                        <li><a href=""#"" class=""button fit small"">Fit + Small</a></li>
                    </ul>
                    <ul class=""actions"">
                        <li><a href=""#"" class=""button primary icon solid fa-download"">Icon</a></li>
                        <li><a href=""#"" class=""button icon solid fa-upload"">Icon</a></li>
                        <li><a href=""#"" class=""button icon solid fa-save"">Icon</a></li>
                    </ul>
                    <ul class=""actions"">
                        <li><span class=""button primary disabled"">Disabled</span></li>
                        <li><span class=""button disabled"">Disabled</span></li>
                    </ul>
                </section>

");
                WriteLiteral("                <!-- Form -->\r\n                <section>\r\n                    <h2>Form</h2>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a205904219974", async() => {
                    WriteLiteral("\r\n                        <div class=\"row gtr-uniform\">\r\n                            <div class=\"col-6 col-12-xsmall\">\r\n                                <input type=\"text\" name=\"demo-name\" id=\"demo-name\"");
                    BeginWriteAttribute("value", " value=\"", 12903, "\"", 12911, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Name\" />\r\n                            </div>\r\n                            <div class=\"col-6 col-12-xsmall\">\r\n                                <input type=\"email\" name=\"demo-email\" id=\"demo-email\"");
                    BeginWriteAttribute("value", " value=\"", 13120, "\"", 13128, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Email\" />\r\n                            </div>\r\n                            <div class=\"col-12\">\r\n                                <select name=\"demo-category\" id=\"demo-category\">\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a205904221260", async() => {
                        WriteLiteral("- Category -");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a205904222590", async() => {
                        WriteLiteral("Manufacturing");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a205904223921", async() => {
                        WriteLiteral("Shipping");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a205904225247", async() => {
                        WriteLiteral("Administration");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fecfffdd7c45a2d9affba7409823dd0a205904226579", async() => {
                        WriteLiteral("Human Resources");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""col-4 col-12-small"">
                                <input type=""radio"" id=""demo-priority-low"" name=""demo-priority"" checked>
                                <label for=""demo-priority-low"">Low</label>
                            </div>
                            <div class=""col-4 col-12-small"">
                                <input type=""radio"" id=""demo-priority-normal"" name=""demo-priority"">
                                <label for=""demo-priority-normal"">Normal</label>
                            </div>
                            <div class=""col-4 col-12-small"">
                                <input type=""radio"" id=""demo-priority-high"" name=""demo-priority"">
                                <label for=""demo-priority-high"">High</label>
                            </div>
                            <div class=""col-6 col-12-small"">
                                <input type=""");
                    WriteLiteral(@"checkbox"" id=""demo-copy"" name=""demo-copy"">
                                <label for=""demo-copy"">Email me a copy</label>
                            </div>
                            <div class=""col-6 col-12-small"">
                                <input type=""checkbox"" id=""demo-human"" name=""demo-human"" checked>
                                <label for=""demo-human"">Not a robot</label>
                            </div>
                            <div class=""col-12"">
                                <textarea name=""demo-message"" id=""demo-message"" placeholder=""Enter your message"" rows=""6""></textarea>
                            </div>
                            <div class=""col-12"">
                                <ul class=""actions"">
                                    <li><input type=""submit"" value=""Send Message"" class=""primary"" /></li>
                                    <li><input type=""reset"" value=""Reset"" /></li>
                                </ul>
                            </div>
");
                    WriteLiteral("                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </section>

                <!-- Image -->
                <section>
                    <h2>Image</h2>
                    <h3>Fit</h3>
                    <div class=""box alt"">
                        <div class=""row gtr-uniform"">
                            <div class=""col-12""><span class=""image fit""><img src=""images/pic04.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 16171, "\"", 16177, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic01.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 16294, "\"", 16300, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic02.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 16417, "\"", 16423, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic03.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 16540, "\"", 16546, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic03.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 16663, "\"", 16669, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic01.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 16786, "\"", 16792, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic02.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 16909, "\"", 16915, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic02.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 17032, "\"", 17038, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic03.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 17155, "\"", 17161, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                            <div class=\"col-4\"><span class=\"image fit\"><img src=\"images/pic01.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 17278, "\"", 17284, 0);
                EndWriteAttribute();
                WriteLiteral(" /></span></div>\r\n                        </div>\r\n                    </div>\r\n                    <h3>Left &amp; Right</h3>\r\n                    <p><span class=\"image left\"><img src=\"images/pic05.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 17485, "\"", 17491, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></span>Fringilla nisl. Donec accumsan interdum nisi, quis tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent. Donec accumsan interdum nisi, quis tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu");
                WriteLiteral(@" faucibus. Integer ac pellentesque praesent tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent.</p>
                    <p><span class=""image right""><img src=""images/pic06.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 18856, "\"", 18862, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></span>Fringilla nisl. Donec accumsan interdum nisi, quis tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent. Donec accumsan interdum nisi, quis tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu");
                WriteLiteral(@" faucibus. Integer ac pellentesque praesent tincidunt felis sagittis eget. tempus euismod. Vestibulum ante ipsum primis in faucibus vestibulum. Blandit adipiscing eu felis iaculis volutpat ac adipiscing accumsan eu faucibus. Integer ac pellentesque praesent.</p>
                </section>
                ");
#nullable restore
#line 322 "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </section>\r\n        ");
#nullable restore
#line 325 "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("SidebarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 327 "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 328 "C:\Users\TheGamer\source\repos\Beauty Salon\Beauty Salon\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
