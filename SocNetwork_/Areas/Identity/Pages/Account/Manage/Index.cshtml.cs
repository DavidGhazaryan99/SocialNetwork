using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SocNetwork_.Models;

namespace SocNetwork_.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public string OldProfilePicture { get; set; }

        public class InputModel
        {

            [Display(Name = "Profile Picture")]
            public IFormFile NewProfilePicture { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "Date Of Birthday")]
            [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}")]
            public DateTime DateOfBirth { get; set; }

            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Address")]
            public string Address { get; set; }

            [Display(Name = "Male")]

            public bool GenderMale { get; set; }
            [Display(Name = "Female")]

            public bool GenderFemale { get; set; }

        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var firstName = user.firstName;
            var lastName = user.lastName;
            var dateOfBirth = user.DateOfBirth;
            OldProfilePicture = user.ProfilePicture;
            var address = user.Address;

            Username = userName;

            Input = new InputModel
            {
                Address=address,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                PhoneNumber = phoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            if (Input.NewProfilePicture != null)
            {
                var oldProfilePicture = user.ProfilePicture;
                if (UploadedFile(Input) != oldProfilePicture)
                {
                    user.ProfilePicture = UploadedFile(Input);
                }
            }

            if (Input.GenderFemale == true)
            {
                user.Gender = "Female";
            }
            if (Input.GenderMale == true)
            {
                user.Gender = "Male";
            }

            var firstName = user.firstName;
            if (Input.FirstName != firstName)
            {
                user.firstName = Input.FirstName;
            }

            var address = user.Address;
            if (Input.Address != address)
            {
                user.Address = Input.Address;
            }

            var lastName = user.lastName;
            if (Input.LastName != lastName)
            {
                user.lastName = Input.LastName;
            }

            var dateOfBirth = user.DateOfBirth;
            if (Input.DateOfBirth != dateOfBirth)
            {
                user.DateOfBirth = Input.DateOfBirth;
            }
            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
        private string UploadedFile(InputModel model)
        {
            var file = model.NewProfilePicture;
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                    return s;
                }
            }
            return null;
        }
    }
}
