using Microsoft.AspNetCore.Identity;
using CsrfDemo.Models;

namespace CsrfDemo.Data;
public class Seeder
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        // Check if a user with a specific email exists, and create one if not
        var userName = "Elvis";
        var user = await userManager.FindByNameAsync(userName);
        if (user == null)
        {
            user = new ApplicationUser
            {
                UserName = userName,
                Email = "elvis@email.com",
            };
            await userManager.CreateAsync(user, "P@ssw0rd");
        }
    }

}