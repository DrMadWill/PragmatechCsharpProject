# Forget Password using Email Service 

## Stratup.cs
```cs
// Token Provider Add
services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<SomeDbContext>()
                .AddTokenProvider<DataProtectorTokenProvider<User>>(TokenOptions.DefaultProvider);
// Email Servic Add
services.AddScoped<IEmailService, EmailServices>();

```
## Controller
```cs
        // Dependency Injection 
        private readonly IEmailService _emailService;

        public AccountController(IEmailService _emailService)
        {
            emailService = _emailService;
        }

        // Forget GET
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            ForgetPasswordVM forgetPassword = new ForgetPasswordVM();
            return View(forgetPassword);
        }

        // Forget POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPassword)
        {
            
            if (!ModelState.IsValid) return View(forgetPassword);

            // User Find
            var user = await userManager.FindByEmailAsync(forgetPassword.Email);
            if(user == null)
            {
                ModelState.AddModelError("Email", "Don't Find This Email.");
                return View(forgetPassword);
            }

            // Create Special Token
            string token = await userManager.GeneratePasswordResetTokenAsync(user);
            // Create Url
            string url = Url.Action("ResetPassword", "Signin", new { token,email=user.Email },Request.Scheme);

            // Email body Create
            string body = string.Empty;
            // Html Email Template 
            using (StreamReader reader = new StreamReader("wwwroot/templates/forgetpasswod.html"))
                body = reader.ReadToEnd();
            // Url add Html
            body = body.Replace("{{url}}", url);
            // Email Servic Send
            emailService.Send(user.Email, "Reset Password", body);

            return Redirect("/");
        }

        [HttpGet]
        public IActionResult ResetPassword(string token,string email)
        {
            if(string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email)) return Redirect("/System/Error404");
            ResetPasswordVM resetPassword = new ResetPasswordVM
            {
                Token = token,
                Email = email
            };
            return View(resetPassword);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPassword)
        {
            if (!ModelState.IsValid) return View(resetPassword);

            // Check User 
            var user = await userManager.FindByEmailAsync(resetPassword.Email);
            if (user == null) return Redirect("/System/Error404"); 

            // Ckeck Password Usable
            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(userManager, null, resetPassword.Password);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("Password", result.Errors.First().Description);
                return View(resetPassword);
            }

            var resault = await userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);

            if (resault.Succeeded)
            {
                return Redirect("/");
            }
            ModelState.AddModelError("Password", "We Have Some Problem");
            return View(resetPassword);
        }
```



## Email Active
> - Create your gmail and active [Forwarding and POP/IMAP](https://mail.google.com/mail/u/0/?ogbl#settings/fwdandpop)
> and [Security](https://myaccount.google.com/u/2/lesssecureapps) 

<img src="https://i.postimg.cc/MTPwBGng/pop-Active.png"/>

> [Video Link](https://www.youtube.com/watch?v=D-NYmDWiFjU)

> - [Then Anouter App Connect Allow](https://accounts.google.com/DisplayUnlockCaptcha) 

## Extensions
```cs
    using MimeKit.Text;
    using MailKit.Net.Smtp;
    using MailKit.Security;

    public interface IEmailService
    {
        void Send(string to, string subject, string html);
    }

    public class EmailServices : IEmailService
    {

        public void Send(string to, string subject, string html)
        {
            //create messenge
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("[YourEmail]"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text=html};


            //Send Email
            var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com",587, SecureSocketOptions.StartTls);
            smtp.Authenticate("[YourEmail]", "[YourPassword]");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
```

[Link Project]()







