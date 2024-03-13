using MeetingNotes.Components;
using MudBlazor.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Identity.Web.UI;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Rewrite;

namespace MeetingNotes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddMudServices();
            builder.Services.AddHttpClient();

            builder.Services.AddControllersWithViews().AddMicrosoftIdentityUI();
            builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
                                            .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

            builder.Services.AddServerSideBlazor().AddMicrosoftIdentityConsentHandler();

            //builder.Services.AddMsalAuthentication(ops =>
            //{
            //    builder.Configuration.Bind("AzureAd", ops.ProviderOptions.Authentication);
            //    ops.ProviderOptions.LoginMode = "redirect";
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRewriter(
                new RewriteOptions().Add(ctx =>
                {
                    if (ctx.HttpContext.Request.Path == "/MicrosoftIdentity/Account/SignOut")
                    {
                        ctx.HttpContext.Response.Redirect("/");
                    }
                }));

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
