using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TheFinalSheDriverTrainingHub.Areas.Identity.Data;

namespace TheFinalSheDriverTrainingHub.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<TheFinalSheDriverTrainingHubUser> _signInManager;
        private readonly UserManager<TheFinalSheDriverTrainingHubUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<TheFinalSheDriverTrainingHubUser> userManager,
            SignInManager<TheFinalSheDriverTrainingHubUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "Suburb")]
            public string Suburb { get; set; }

            [Required]
            [Display(Name = "City")]
            public string City { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string EmailAddress { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "License Number")]
            public string LicenseNumber { get; set; }

            [Required]
            [Display(Name = "License Version")]
            public int LicenseVersion { get; set; }

            [Required]
            [Display(Name = "Do you have a current I Endorsement?")]
            public bool IsEndorsed { get; set; }

            [Required]
            [Display(Name = "Monday")]
            public bool Monday { get; set; }

            [Required]
            [Display(Name = "Tuesday")]
            public bool Tuesday { get; set; }

            [Required]
            [Display(Name = "Wednesday")]
            public bool Wednesday { get; set; }

            [Required]
            [Display(Name = "Thursday")]
            public bool Thursday { get; set; }

            [Required]
            [Display(Name = "Friday")]
            public bool Friday { get; set; }

            [Required]
            [Display(Name = "Saturday")]
            public bool Saturday { get; set; }

            [Required]
            [Display(Name = "Sunday")]
            public bool Sunday { get; set; }

            [Required]
            [Display(Name = "What are your available times?")]
            public string AvailableTimes { get; set; }

            [Required]
            [Display(Name = "Lesson Costs Per Hour?")]
            public int PricePerHour { get; set; }

            [Required]
            [Display(Name = "Please write a bit about yourself")]
            public string AboutInstructor { get; set; }

              [Display(Name = "Profile Image")]
            public string ImageFileName { get; set; }

            [Required]
            public bool isAuthorised { get; set; }
            [Required]
            public bool isAdmin { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new TheFinalSheDriverTrainingHubUser {
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    Suburb = Input.Suburb,
                    City = Input.City,
                    PhoneNumber = Input.PhoneNumber,
                    UserName = Input.EmailAddress,
                    Email = Input.EmailAddress,
                    LicenseNumber = Input.LicenseNumber,
                    LicenseVersion = Input.LicenseVersion,
                    IsEndorsed = Input.IsEndorsed,
                    Monday = Input.Monday,
                    Tuesday = Input.Tuesday,
                    Wednesday = Input.Wednesday,
                    Thursday = Input.Thursday,
                    Friday = Input.Friday,
                    Saturday = Input.Saturday,
                    Sunday = Input.Sunday,
                    AvailableTimes = Input.AvailableTimes,
                    PricePerHour = Input.PricePerHour,
                    AboutInstructor = Input.AboutInstructor,
                    ImageFileName = Input.ImageFileName,
                    isAuthorised = false,
                    isAdmin = false
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.EmailAddress, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
